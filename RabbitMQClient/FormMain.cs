using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Configuration;
using System.Reflection;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RabbitMQClient
{
    public partial class FormMain : Form
    {
        Configuration cfg = null;
        public FormMain()
        {
            InitializeComponent();
            cfg = ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);
            InitTextBoxes();

        }

        private void InitTextBoxes()
        {
            textBoxServer.Text = cfg.AppSettings.Settings["Server"] != null ? cfg.AppSettings.Settings["Server"].Value : string.Empty;
            textBoxLogin.Text = cfg.AppSettings.Settings["Login"] != null ? cfg.AppSettings.Settings["Login"].Value : string.Empty;
            textBoxPassword.Text = cfg.AppSettings.Settings["Password"] != null ? cfg.AppSettings.Settings["Password"].Value : string.Empty;
            textBoxQueue.Text = cfg.AppSettings.Settings["Queue"] != null ? cfg.AppSettings.Settings["Queue"].Value : string.Empty;
            textBoxExchange.Text = cfg.AppSettings.Settings["Exchange"] != null ? cfg.AppSettings.Settings["Exchange"].Value : string.Empty;
            textBoxRoutingKey.Text = cfg.AppSettings.Settings["RoutingKey"] != null ? cfg.AppSettings.Settings["RoutingKey"].Value : string.Empty;
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

        private void WriteChangeToConfigFile(object sender, EventArgs e)
        {
            TextBox? tb = sender as TextBox;
            if (tb != null && tb.Tag != null)
            {
                if (cfg.AppSettings.Settings[tb.Tag.ToString()] != null)
                {
                    cfg.AppSettings.Settings[tb.Tag.ToString()].Value = tb.Text;
                }
                else
                {
                    cfg.AppSettings.Settings.Add(tb.Tag.ToString(), tb.Text);
                }

                cfg.Save();
            }
        }

        private void buttonFetch_Click(object sender, EventArgs e)
        {
            ConnectionFactory factory = new ConnectionFactory();
            factory.ClientProvidedName = "Client #1";
            factory.HostName = textBoxServer.Text;
            factory.UserName = "client1";
            factory.Password = textBoxPassword.Text;

            IConnection clientconnection = factory.CreateConnection();
            IModel channel = clientconnection.CreateModel();
            channel.BasicQos(prefetchSize: 0, prefetchCount: 1, global: false);

            var consumer = new EventingBasicConsumer(channel);

            consumer.Received += (sender, args) =>
            {
                var body = args.Body.ToArray();
                string message =Encoding.UTF8.GetString(body);
                BeginInvoke(() => { textBoxReceivedMessage.Text = message; });
            };

            channel.BasicConsume(queue: "q.articles.update",autoAck: true,consumer);   

        }

        private void Consumer_Received1(object? sender, BasicDeliverEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Consumer_Received(object? sender, BasicDeliverEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
