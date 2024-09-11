using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using RabbitMQ.Client.Exceptions;
using RabbitMQClient.RMQ_Entities;
using System.ComponentModel;
using System.Configuration;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Channels;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace RabbitMQClient
{
    public partial class FormProducer : Form
    {
        IConnection? _connection;
        IModel? _channel;
        byte[]? _body;
        BackgroundWorker _worker;

        public FormProducer()
        {
            InitializeComponent();

            _worker = new BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };

            _worker.DoWork += Worker_DoWork;
            _worker.RunWorkerCompleted += RunWorkerCompleted;
        }

        private void SetProperties(PublisherConfig config)
        {
            textBoxServer.Text = config.Server;
            textBoxLogin.Text = config.Login;
            textBoxPassword.Text = config.Password;
            textBoxQueue.Text = config.Queue;
            textBoxExchange.Text = config.Exchange;
            textBoxRoutingKey.Text = config.RoutingKey;
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            ConnectionFactory? factory = new ConnectionFactory
            {
                HostName = textBoxServer.Text,
                UserName = textBoxLogin.Text,
                Password = textBoxPassword.Text,
                Port = (!string.IsNullOrEmpty(textBoxPort.Text)) ? int.Parse(textBoxPort.Text) : 5672
            };

            try
            {
                _connection = factory.CreateConnection();
            }
            catch (BrokerUnreachableException ex)
            {
                MessageBox.Show($"Connection faild\n {ex.Message}", "Connection faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _channel = _connection.CreateModel();

            _body = Encoding.UTF8.GetBytes(textBoxMessage.Text);

            if (!_worker.IsBusy)
            {
                _worker.RunWorkerAsync();
            }

            buttonSend.Enabled = false;

        }

        private void Worker_DoWork(object? sender, DoWorkEventArgs e)
        {
            do
            {
                _channel.BasicPublish(exchange: textBoxExchange.Text,
                routingKey: textBoxRoutingKey.Text,
                                     basicProperties: null,
                                     body: _body);

                Thread.Sleep((int)numericUpDownDelay.Value);
            } while (checkBoxRepeatSend.Checked);
        }

        private void RunWorkerCompleted(object? sender, RunWorkerCompletedEventArgs e)
        {
            buttonSend.Enabled = true;
            _channel.Close();
            _connection.Close();
        }

        private void saveProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PublisherConfig config = new PublisherConfig
            {
                Server = textBoxServer.Text,
                Login = textBoxLogin.Text,
                Password = textBoxPassword.Text,
                Queue = textBoxQueue.Text,
                Exchange = textBoxExchange.Text,
                RoutingKey = textBoxRoutingKey.Text
            };

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Producer Profile(*.pcon)|*.pcon|All Files|*.*";
            sfd.RestoreDirectory = true;
            sfd.Title = "Safe producer configuratiom";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                JsonFileConfigHandler jfch = new JsonFileConfigHandler(config, sfd.FileName);
                jfch.WriteConfig();
            }
        }

        private void loadProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            PublisherConfig config = new PublisherConfig();

            ofd.Filter = "Producer Profile(*.pcon)|*.pcon|All Files|*.*";
            ofd.RestoreDirectory = true;
            ofd.Title = "Select producer configuration";
            ofd.Multiselect = false;
            ofd.DefaultExt = "pcon";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                JsonFileConfigHandler jfch = new JsonFileConfigHandler(ofd.FileName);
                config = jfch.ReadConfig<PublisherConfig>();
                SetProperties(config);
            }
        }

        private void textBoxRoutingKey_TextChanged(object sender, EventArgs e)
        {
            ChangeFormTitle();
        }

        private void ChangeFormTitle()
        {
            this.Text = $"Producer | {textBoxExchange.Text} | {textBoxRoutingKey.Text}";
        }

        private void textBoxExchange_TextChanged(object sender, EventArgs e)
        {
            ChangeFormTitle();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormProducer_FormClosing(object sender, FormClosingEventArgs e)
        {
            _worker.CancelAsync();
        }

        private void textBoxPort_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (int.TryParse(tb.Text, out int result))
            {
                return;
            }
            else
            {
                MessageBox.Show("Port must be an integer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //Exchange ex = new Exchange();
            //ex.Name = "root";
            //ex.Text = "root";
            //treeView1.Nodes.Add(ex);


            var client = new HttpClient();

            // Benutzername und Passwort f�r die Authentifizierung
            var username = "tester";
            var password = "1234";

            // Base64-kodierte Authentifizierungsdaten
            var authToken = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{username}:{password}"));

            // Authorization-Header hinzuf�gen
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authToken);

            var url = "https://rabbit.michael-bohn.net/api/vhosts";

            // Anfrage senden
            var response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                JsonArray? jsonArray = JsonNode.Parse(content).AsArray();

                foreach (JsonObject jo in jsonArray)
                {
                    //treeView1.Nodes.Add((string)jo["name"]);
                    RabbitMQVirtualHost vh = new RabbitMQVirtualHost();
                    vh.Text = (string)jo["name"];
                    treeView1.Nodes.Add(vh);
                }


                //MessageBox.Show(response.StatusCode.ToString());
            }

        }

    }
}

