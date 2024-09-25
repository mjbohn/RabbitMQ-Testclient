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
    public partial class FormPublisher : Form
    {
        IConnection? _connection;
        IModel? _channel;
        byte[]? _body;
        BackgroundWorker _worker;

        public FormPublisher()
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
            textBoxVhost.Text = config.VHost;
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            ConnectionFactory? factory = new ConnectionFactory
            {
                HostName = textBoxServer.Text,
                UserName = textBoxLogin.Text,
                Password = textBoxPassword.Text,
                VirtualHost = (string.IsNullOrEmpty(textBoxVhost.Text)) ? "/" : textBoxVhost.Text,
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
        private void buttonSendFile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet");
        }
        private void Worker_DoWork(object? sender, DoWorkEventArgs e)
        {
            IBasicProperties _basicProperties = _channel.CreateBasicProperties();
            _basicProperties.Persistent = true;

            do
            {
                _channel.BasicPublish(exchange: textBoxExchange.Text,
                routingKey: textBoxRoutingKey.Text,
                                     basicProperties: _basicProperties,
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
                VHost = textBoxVhost.Text,
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

        private void ExplorertoolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowExplorer(true);
        }

        private void ShowExplorer(bool ssl)
        {
            if (textBoxLogin.Text != string.Empty && textBoxPassword.Text != string.Empty)
            {
                FormRabbitMQExplorer explorer = new FormRabbitMQExplorer(textBoxServer.Text, textBoxLogin.Text, textBoxPassword.Text, ssl);
                explorer.Show();
            }
            else
            {
                MessageBox.Show("Please enter Servername, Login & Password", "Missing credentils", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ExplorerNoSsltoolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowExplorer(false);
        }


        private void ChangeFormTitle()
        {
            this.Text = $"Publisher | {textBoxExchange.Text} | {textBoxRoutingKey.Text}";
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

        private void checkBoxRepeatSend_CheckedChanged(object sender, EventArgs e)
        {
            buttonSendFile.Enabled = !(sender as CheckBox).Checked;
        }


    }
}

