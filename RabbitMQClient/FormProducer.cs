using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Configuration;
using System.Reflection;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RabbitMQClient
{
    public partial class FormProducer : Form
    {
        public FormProducer()
        {
            InitializeComponent();
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
                Password = textBoxPassword.Text
            };
            using IConnection? connection = factory.CreateConnection();
            using IModel? channel = connection.CreateModel();

            byte[]? body = Encoding.UTF8.GetBytes(textBoxMessage.Text);


            channel.BasicPublish(exchange: textBoxExchange.Text,
                                 routingKey: textBoxRoutingKey.Text,
                                 basicProperties: null,
                                 body: body);
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
    }
}
