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
                buttonStop.Enabled = false;
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

        private void saveProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsumerConfig config = new ConsumerConfig
            {
                Server = textBoxServer.Text,
                Login = textBoxLogin.Text,
                Password = textBoxPassword.Text,
                Queue = textBoxQueue.Text,
                ClientName = textBoxClientName.Text,
                AddLineFeed = checkBoxAddLF.Checked,
                AutoAck = checkBoxAutoAck.Checked,
                Prefetch = numericUpDownPrefetch.Value
            };

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Consumer Profile(*.ccon)|*.ccon|All Files|*.*";
            sfd.RestoreDirectory = true;
            sfd.Title = "Safe consumer configuratiom";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                JsonFileConfigHandler jfch = new JsonFileConfigHandler(config, sfd.FileName);
                jfch.WriteConfig();
            }
        }

        private void loadProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ConsumerConfig config = new ConsumerConfig();

            ofd.Filter = "Consumer Profile(*.ccon)|*.ccon|All Files|*.*";
            ofd.RestoreDirectory = true;
            ofd.Title = "Select consumer configuration";
            ofd.Multiselect = false;
            ofd.DefaultExt = "ccon";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                JsonFileConfigHandler jfch = new JsonFileConfigHandler(ofd.FileName);
                config = jfch.ReadConfig<ConsumerConfig>();
                SetProperties(config);
            }
        }

        private void SetProperties(ConsumerConfig config)
        {
            textBoxServer.Text = config.Server;
            textBoxLogin.Text = config.Login;
            textBoxPassword.Text = config.Password;
            textBoxQueue.Text = config.Queue;
            textBoxClientName.Text = config.ClientName;
            checkBoxAddLF.Checked = config.AddLineFeed;
            checkBoxAutoAck.Checked = config.AutoAck;
            numericUpDownPrefetch.Value = config.Prefetch;
        }

        private void FormConsumer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_channel != null && _channel.IsOpen)
            {
                _channel.Close();
            }

            if (_clientconnection != null && _clientconnection.IsOpen)
            {
                _clientconnection.Close();
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxQueue_TextChanged(object sender, EventArgs e)
        {
            ChangeFormTitle();
        }

        private void textBoxServer_TextChanged(object sender, EventArgs e)
        {
            ChangeFormTitle();
        }

        private void ChangeFormTitle()
        {
            this.Text = $"Consumer | {textBoxServer.Text} | {textBoxQueue.Text} | ";
        }

        
    }
}
