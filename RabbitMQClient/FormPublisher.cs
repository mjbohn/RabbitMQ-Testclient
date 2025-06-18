using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using RabbitMQ.Client.Exceptions;
using RabbitMQClient.ConfigHandling;
using RabbitMQClient.RMQ_Entities;
using ScintillaNET;
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
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Interoperability", "CA1416:Plattformkompatibilität überprüfen", Justification = "<Ausstehend>")]
    public partial class FormPublisher : Form
    {
        IConnection? _connection;
        IModel? _channel;
        byte[]? _body;
        BackgroundWorker _worker;

        int lastCaretPos = 0;

        public FormPublisher()
        {
            InitializeComponent();
            InitializeScintilla();

            _worker = new BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };

            _worker.DoWork += Worker_DoWork;
            _worker.RunWorkerCompleted += RunWorkerCompleted;
        }

        // Action starts here
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

            _body = Encoding.UTF8.GetBytes(scintillaPublisher.Text);

            if (!_worker.IsBusy)
            {
                _worker.RunWorkerAsync();
            }

            buttonSend.Enabled = false;

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

        #region EventHandler

        private void saveProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PublisherConfig config = new PublisherConfig
            {
                Server = textBoxServer.Text,
                Login = textBoxLogin.Text,
                Password = textBoxPassword.Text,
                //Queue = textBoxQueue.Text,
                Exchange = textBoxExchange.Text,
                VHost = textBoxVhost.Text,
                RoutingKey = textBoxRoutingKey.Text,
                Port = textBoxPort.Text,
                ApiPort = textBoxApiPort.Text,

            };

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Producer Profile(*.pcon)|*.pcon|All Files|*.*";
            sfd.DefaultExt = "pcon";
            sfd.RestoreDirectory = true;
            sfd.Title = "Safe publisher configuratiom";
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

            ofd.Filter = "Publisher Profile(*.pcon)|*.pcon|All Files|*.*";
            ofd.RestoreDirectory = true;
            ofd.Title = "Select publisher configuration";
            ofd.Multiselect = false;
            ofd.DefaultExt = "pcon";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                JsonFileConfigHandler jfch = new JsonFileConfigHandler(ofd.FileName);
                config = jfch.ReadConfig<PublisherConfig>();
                SetProperties(config);
                ChangeFormTitle(ofd.SafeFileName);
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

        private void ExplorerNoSsltoolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowExplorer(false);
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
            if (int.TryParse(tb.Text, out _))
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

        private void buttonLoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "JSON(*.json)|*.json|Textfile(*.txt)|*.txt|CSV(*.csv)|*.csv|All Files|*.*";
            ofd.RestoreDirectory = true;
            ofd.Title = "Select file";
            ofd.Multiselect = false;
            ofd.DefaultExt = ".json";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    scintillaPublisher.Text = File.ReadAllText(ofd.FileName);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
        }
        #endregion

        private void ShowExplorer(bool ssl)
        {
            if (textBoxLogin.Text != string.Empty && textBoxPassword.Text != string.Empty)
            {
                FormRabbitMQExplorer explorer = new FormRabbitMQExplorer(textBoxServer.Text, textBoxLogin.Text, textBoxPassword.Text, textBoxApiPort.Text, ssl);
                explorer.Show();
            }
            else
            {
                MessageBox.Show("Please enter Servername, Login & Password", "Missing credentils", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ChangeFormTitle(string fileName = null)
        {
            this.Text = $"Publisher | {textBoxExchange.Text} | {textBoxRoutingKey.Text} | profile:<{fileName}>";
        }

        private void SetProperties(PublisherConfig config)
        {
            textBoxServer.Text = config.Server;
            textBoxLogin.Text = config.Login;
            textBoxPassword.Text = config.Password;
            //textBoxQueue.Text = config.Queue;
            textBoxExchange.Text = config.Exchange;
            textBoxRoutingKey.Text = config.RoutingKey;
            textBoxVhost.Text = config.VHost;
            textBoxApiPort.Text = config.ApiPort;
            textBoxPort.Text = config.Port;
        }

        private void InitializeScintilla()
        {
            // Set the lexer
            scintillaPublisher.LexerName = "cpp";

            // Instruct the lexer to calculate folding
            scintillaPublisher.SetProperty("fold", "1");
            scintillaPublisher.SetProperty("fold.compact", "1");

            // Configure a margin to display folding symbols
            scintillaPublisher.Margins[2].Type = MarginType.Symbol;
            scintillaPublisher.Margins[2].Mask = Marker.MaskFolders;
            scintillaPublisher.Margins[2].Sensitive = true;
            scintillaPublisher.Margins[2].Width = 20;

            // show line numbers
            scintillaPublisher.Margins[0].Width = 32;

            // Set colors for all folding markers
            for (int i = 25; i <= 31; i++)
            {
                scintillaPublisher.Markers[i].SetForeColor(SystemColors.ControlLightLight);
                scintillaPublisher.Markers[i].SetBackColor(SystemColors.ControlDark);
            }

            // Configure folding markers with respective symbols
            scintillaPublisher.Markers[Marker.Folder].Symbol = MarkerSymbol.BoxPlus;
            scintillaPublisher.Markers[Marker.FolderOpen].Symbol = MarkerSymbol.BoxMinus;
            scintillaPublisher.Markers[Marker.FolderEnd].Symbol = MarkerSymbol.BoxPlusConnected;
            scintillaPublisher.Markers[Marker.FolderMidTail].Symbol = MarkerSymbol.TCorner;
            scintillaPublisher.Markers[Marker.FolderOpenMid].Symbol = MarkerSymbol.BoxMinusConnected;
            scintillaPublisher.Markers[Marker.FolderSub].Symbol = MarkerSymbol.VLine;
            scintillaPublisher.Markers[Marker.FolderTail].Symbol = MarkerSymbol.LCorner;

            // Enable automatic folding
            scintillaPublisher.AutomaticFold = (AutomaticFold.Show | AutomaticFold.Click | AutomaticFold.Change);

            scintillaPublisher.BackColor = System.Drawing.Color.LightGray;
            scintillaPublisher.Styles[Style.Default].BackColor = Color.SteelBlue;


            scintillaPublisher.StyleClearAll();

            // Set styles for matching braces
            scintillaPublisher.Styles[Style.BraceLight].BackColor = Color.LightGray;
            scintillaPublisher.Styles[Style.BraceLight].ForeColor = Color.BlueViolet;
            scintillaPublisher.Styles[Style.BraceBad].ForeColor = Color.Red;
                        
        }
        
        private static bool IsBrace(int c)
        {
            switch (c)
            {
                case '(':
                case ')':
                case '[':
                case ']':
                case '{':
                case '}':
                case '<':
                case '>':
                    return true;
            }

            return false;
        }
        private void scintillaPublisher_UpdateUI(object sender, UpdateUIEventArgs e)
        {
            int caretPos = scintillaPublisher.CurrentPosition;

            if (lastCaretPos != caretPos)
            {
                lastCaretPos = caretPos;
                var bracePos1 = -1;
                var bracePos2 = -1;

                // Is there a brace to the left or right?
                if (caretPos > 0 && IsBrace(scintillaPublisher.GetCharAt(caretPos - 1)))
                    bracePos1 = (caretPos - 1);
                else if (IsBrace(scintillaPublisher.GetCharAt(caretPos)))
                    bracePos1 = caretPos;

                if (bracePos1 >= 0)
                {
                    // Find the matching brace
                    bracePos2 = scintillaPublisher.BraceMatch(bracePos1);
                    if (bracePos2 == Scintilla.InvalidPosition)
                        scintillaPublisher.BraceBadLight(bracePos1);
                    else
                        scintillaPublisher.BraceHighlight(bracePos1, bracePos2);
                }
                else
                {
                    // Turn off brace matching
                    scintillaPublisher.BraceHighlight(Scintilla.InvalidPosition, Scintilla.InvalidPosition);
                }
            }
        }
    }
}

