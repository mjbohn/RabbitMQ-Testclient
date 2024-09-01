using RabbitMQ.Client.Events;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RabbitMQClient
{
    public partial class FormConsumer : Form
    {
        ConnectionFactory factory = new ConnectionFactory();
        public FormConsumer()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.Enabled = false;
            buttonStop.Enabled = true;

            
            factory.ClientProvidedName = textBoxClientName.Text;
            factory.HostName = textBoxServer.Text;
            factory.UserName = textBoxLogin.Text;
            factory.Password = textBoxPassword.Text;

            IConnection clientconnection = factory.CreateConnection();
            IModel channel = clientconnection.CreateModel();
            channel.BasicQos(prefetchSize: 0, prefetchCount: 1, global: false);

            var consumer = new EventingBasicConsumer(channel);

            consumer.Received += (sender, args) =>
            {
                var body = args.Body.ToArray();
                string message = Encoding.UTF8.GetString(body);
                if (checkBoxAddLF.Checked) { message += "\n"; }
                
                BeginInvoke( () => { rtbReceivedMessages.AppendText(message); });
            };

            channel.BasicConsume(queue: textBoxQueue.Text, autoAck: true, consumer);



        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.Enabled = false;
            buttonStart.Enabled = true;
        }
    }
}
