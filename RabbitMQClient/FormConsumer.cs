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
using System.CodeDom;
using RabbitMQClient.ConfigHandling;

namespace RabbitMQClient
{
    public partial class FormConsumer : Form
    {
        ConnectionFactory _factory = new ConnectionFactory();
        IConnection _clientconnection;
        IModel _channel;
        ulong _deliveryTag = 0;


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

            _factory.ClientProvidedName = textBoxClientName.Text;
            _factory.HostName = textBoxServer.Text;
            _factory.UserName = textBoxLogin.Text;
            _factory.Password = textBoxPassword.Text;
            _factory.Port = (!string.IsNullOrEmpty(textBoxPort.Text)) ? int.Parse(textBoxPort.Text) : 5672;
            _factory.VirtualHost = (string.IsNullOrEmpty(textBoxVhost.Text)) ? "/" : textBoxVhost.Text;

            // try to connect
            try
            {
                _clientconnection = _factory.CreateConnection();
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
            _channel.BasicQos(prefetchSize: 0, prefetchCount: (ushort)numericUpDownPrefetch.Value, global: false);

            EventingBasicConsumer? consumer = new EventingBasicConsumer(_channel);

            FetchMessages(consumer);
        }

        private void FetchMessages(EventingBasicConsumer consumer)
        {
            // start consumer
            try
            {
                _channel.BasicConsume(queue: textBoxQueue.Text, autoAck: false, consumer);

            }
            catch (Exception ex)
            {
                StringBuilder sb = new();
                sb.Append(ex.Message);
                sb.Append(Environment.NewLine);
                MessageBox.Show(sb.ToString(), "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBoxesEnabled(true);
                buttonStart.Enabled = true;
                buttonStop.Enabled = false;
                return;
            }

            consumer.Received += (sender, args) =>
            {
                byte[]? body = args.Body.ToArray();
                _deliveryTag = args.DeliveryTag;

                string message = Encoding.UTF8.GetString(body);

                if (checkBoxAddLF.Checked) { message += "\n"; }

                BeginInvoke(() =>
                {
                    rtbReceivedMessages.AppendText(message);
                    rtbReceivedMessages.ScrollToCaret();
                });

                if (!checkBoxAutoAck.Checked)
                {
                    BeginInvoke(() => { buttonApply.Enabled = true; });
                }
                else
                {
                    if (_channel.IsOpen)
                    {
                        _channel.BasicAck(_deliveryTag, checkBoxMultiple.Checked); 
                    }
                    Thread.Sleep((int)numericUpDownDelay.Value);
                }

            };
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
        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (radioButtonAck.Checked)
            {
                _channel.BasicAck(_deliveryTag, checkBoxMultiple.Checked);
            }

            if (radioButtonNack.Checked)
            {
                _channel.BasicNack(_deliveryTag, checkBoxMultiple.Checked, checkBoxRequeue.Checked);
            }

            if (radioButtonReject.Checked)
            {
                _channel.BasicReject(_deliveryTag, checkBoxRequeue.Checked);
            }


            BeginInvoke(() => { buttonApply.Enabled = false; });
        }

        #region handle_config
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
                Prefetch = numericUpDownPrefetch.Value,
                VHost = textBoxVhost.Text,
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

        #endregion handle_config

        #region helper
        private void TextBoxesEnabled(bool value)
        {
            textBoxServer.Enabled = value;
            textBoxLogin.Enabled = value;
            textBoxPassword.Enabled = value;
            textBoxQueue.Enabled = value;
            textBoxClientName.Enabled = value;
            textBoxVhost.Enabled = value;

            checkBoxAutoAck.Enabled = value;

            numericUpDownPrefetch.Enabled = value;
            labelPrefetch.Enabled = value;
        }
        private void SetProperties(ConsumerConfig config)
        {
            textBoxServer.Text = config.Server;
            textBoxLogin.Text = config.Login;
            textBoxPassword.Text = config.Password;
            textBoxQueue.Text = config.Queue;
            textBoxClientName.Text = config.ClientName;
            textBoxVhost.Text = config.VHost;
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

        private void checkBoxAutoAck_CheckedChanged(object sender, EventArgs e)
        {
            panelAck.Visible = !checkBoxAutoAck.Checked;
        }

        private void radioButtonAck_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                checkBoxRequeue.Checked = false;
                checkBoxRequeue.Enabled = false;
            }
            else { checkBoxRequeue.Enabled = true; }
        }

        private void radioButtonNack_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                checkBoxRequeue.Checked = true;
                //checkBoxRequeue.Enabled = false;
            }
            else { checkBoxRequeue.Enabled = true; }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="toolStripItem"></param>
        /// <returns>T</returns>
        private T GetToolStripItemParent<T>(ToolStripItem toolStripItem) where T : Control
        {
            T _returnObject;
            ContextMenuStrip owner = toolStripItem.Owner as ContextMenuStrip;
            _returnObject = owner.SourceControl as T;
            return _returnObject;
        }

        private void textBoxPort_Validated(object sender, EventArgs e)
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

        #endregion helper

        #region RTB ContexMenuEvents

        private void MenuItemSelectAll_Click(object sender, EventArgs e)
        {
            ToolStripItem toolStripItem = sender as ToolStripItem;
            RichTextBox rtb = GetToolStripItemParent<RichTextBox>(toolStripItem);
            rtb.Focus();
            rtb.SelectAll();
        }

        private void MenuItemCopy_Click(object sender, EventArgs e)
        {
            ToolStripItem toolStripItem = sender as ToolStripItem;
            RichTextBox rtb = GetToolStripItemParent<RichTextBox>(toolStripItem);
            rtb.Copy();
        }

        private void MenuItemPaste_Click(object sender, EventArgs e)
        {
            ToolStripItem toolStripItem = sender as ToolStripItem;
            RichTextBox rtb = GetToolStripItemParent<RichTextBox>(toolStripItem);
            rtb.Paste();
        }

        private void MenuItemClear_Click(object sender, EventArgs e)
        {
            ToolStripItem toolStripItem = sender as ToolStripItem;
            RichTextBox rtb = GetToolStripItemParent<RichTextBox>(toolStripItem);
            rtb.Clear();
        }

        #endregion RTB ContexMenuEvents


    }
}
