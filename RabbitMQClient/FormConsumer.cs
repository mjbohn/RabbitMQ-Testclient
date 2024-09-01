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
using System.Threading.Channels;
using RabbitMQ.Client.Exceptions;

namespace RabbitMQClient
{
    public partial class FormConsumer : Form
    {
        ConnectionFactory factory = new ConnectionFactory();
        IConnection _clientconnection;
        IModel _channel;
        public FormConsumer()
        {
            InitializeComponent();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.Enabled = false;
            buttonStop.Enabled = true;

            TextBoxesEnabled(false);

            factory.ClientProvidedName = textBoxClientName.Text;
            factory.HostName = textBoxServer.Text;
            factory.UserName = textBoxLogin.Text;
            factory.Password = textBoxPassword.Text;

            try
            {
                _clientconnection = factory.CreateConnection();
            }
            catch (BrokerUnreachableException ex)
            {
                StringBuilder sb = new();
                sb.Append(ex.Message);
                sb.Append(Environment.NewLine);
                sb.Append($"Hostname: {textBoxServer.Text} {Environment.NewLine} Login: {textBoxLogin.Text}");
                MessageBox.Show(sb.ToString(), "BrokerUnreachableExeption", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBoxesEnabled(true);
                btn.Enabled = true;
                buttonStop.Enabled= false;
                return;
            }
            _channel = _clientconnection.CreateModel();
            _channel.BasicQos(prefetchSize: 0, prefetchCount: 1, global: false);

            var consumer = new EventingBasicConsumer(_channel);

            consumer.Received += (sender, args) =>
            {
                var body = args.Body.ToArray();
                string message = Encoding.UTF8.GetString(body);
                if (checkBoxAddLF.Checked) { message += "\n"; }

                BeginInvoke(() => { rtbReceivedMessages.AppendText(message); });
            };

            try
            {
                _channel.BasicConsume(queue: textBoxQueue.Text, autoAck: true, consumer);
            }
            catch (Exception ex)
            {
                StringBuilder sb = new();
                sb.Append(ex.Message);
                sb.Append(Environment.NewLine);
                MessageBox.Show(sb.ToString(), "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBoxesEnabled(true);
                btn.Enabled = true;
                buttonStop.Enabled = false;
                return;
            }



        }

        private void TextBoxesEnabled(bool v)
        {
            textBoxServer.Enabled = v;
            textBoxLogin.Enabled = v;
            textBoxPassword.Enabled = v;
            textBoxQueue.Enabled = v;
            textBoxClientName.Enabled = v;
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.Enabled = false;
            buttonStart.Enabled = true;

            _channel.Close();
            _clientconnection.Close();

            TextBoxesEnabled(true);
        }
    }
}
