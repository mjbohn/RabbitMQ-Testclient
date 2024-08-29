using RabbitMQ.Client;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RabbitMQClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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


            channel.QueueDeclare("lala",false,false,false,null);

            //QueueDeclareOk qdo = channel.QueueDeclare(queue: textBoxQueue.Text,
            //                     durable: true,
            //                     exclusive: false,
            //                     autoDelete: false,
            //                     arguments: null);

            //const string message = "Hello World!";
            byte[]? body = Encoding.UTF8.GetBytes(textBoxMessage.Text);


            channel.BasicPublish(exchange: textBoxExchange.Text,
                                 routingKey: textBoxRoutingKey.Text,
                                 basicProperties: null,
                                 body: body);
             
            //MessageBox.Show($" [x] Sent {message}");


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
