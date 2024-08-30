using RabbitMQ.Client;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Init_Queue();
        }

        private void Init_Queue()
        {
            var factory = new ConnectionFactory
            {
                HostName = "rabbit.michael-bohn.net",
                UserName = "csc",
                Password = "1im2bribm"
            };
            using IConnection? connection = factory.CreateConnection();
            using IModel? channel = connection.CreateModel();


            channel.QueueDeclare("lala", false, false, false, null);

            //QueueDeclareOk qdo = channel.QueueDeclare(queue: textBoxQueue.Text,
            //                     durable: true,
            //                     exclusive: false,
            //                     autoDelete: false,
            //                     arguments: null);


            byte[]? body = Encoding.UTF8.GetBytes(textBoxMessage.Text);


            channel.BasicPublish(exchange: textBoxExchange.Text,
                                 routingKey: textBoxRoutingKey.Text,
                                 basicProperties: null,
                                 body: body);

            //MessageBox.Show($" [x] Sent {message}");


        }

        private void WriteChangeToConfigFile(object sender, EventArgs e)
        {
            TextBox? tb = sender as TextBox;
            if (tb != null && tb.Tag != null)
            {
                //ConfigurationManager.AppSettings.Set(tb.Tag.ToString(), tb.Text);
                //ConfigurationManager.AppSettings["Server"] = tb.Text;
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
    }
}
