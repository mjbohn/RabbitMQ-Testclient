namespace RabbitMQClient
{
    partial class FormPublisher
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPublisher));
            buttonSend = new Button();
            labelRoutingKey = new Label();
            textBoxRoutingKey = new TextBox();
            textBoxExchange = new TextBox();
            labelExchange = new Label();
            panelTop = new Panel();
            textBoxPort = new TextBox();
            labelPort = new Label();
            textBoxPassword = new TextBox();
            textBoxLogin = new TextBox();
            textBoxServer = new TextBox();
            labelPassword = new Label();
            labelLogin = new Label();
            labelServer = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            loadProfileToolStripMenuItem = new ToolStripMenuItem();
            saveProfileToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            ExplorertoolStripMenuItem = new ToolStripMenuItem();
            ExplorerNoSsltoolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            closeToolStripMenuItem = new ToolStripMenuItem();
            saveFileDialog1 = new SaveFileDialog();
            panel2nd = new Panel();
            textBoxApiPort = new TextBox();
            textBoxVhost = new TextBox();
            labelApiPort = new Label();
            labelVhost = new Label();
            numericUpDownDelay = new NumericUpDown();
            checkBoxRepeatSend = new CheckBox();
            panelSendButton = new Panel();
            panelSendFile = new Panel();
            buttonSendFile = new Button();
            scintilla = new ScintillaNET.Scintilla();
            splitContainer1 = new SplitContainer();
            panelTop.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel2nd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDelay).BeginInit();
            panelSendButton.SuspendLayout();
            panelSendFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSend
            // 
            buttonSend.Location = new Point(16, 6);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(102, 23);
            buttonSend.TabIndex = 6;
            buttonSend.Text = "Send";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click;
            // 
            // labelRoutingKey
            // 
            labelRoutingKey.AutoSize = true;
            labelRoutingKey.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelRoutingKey.Location = new Point(649, 8);
            labelRoutingKey.Name = "labelRoutingKey";
            labelRoutingKey.Size = new Size(78, 15);
            labelRoutingKey.TabIndex = 1;
            labelRoutingKey.Text = "Routing Key:";
            // 
            // textBoxRoutingKey
            // 
            textBoxRoutingKey.Location = new Point(729, 6);
            textBoxRoutingKey.Name = "textBoxRoutingKey";
            textBoxRoutingKey.Size = new Size(190, 23);
            textBoxRoutingKey.TabIndex = 5;
            textBoxRoutingKey.Tag = "RoutingKey";
            textBoxRoutingKey.TextChanged += textBoxRoutingKey_TextChanged;
            // 
            // textBoxExchange
            // 
            textBoxExchange.Location = new Point(455, 5);
            textBoxExchange.Name = "textBoxExchange";
            textBoxExchange.Size = new Size(190, 23);
            textBoxExchange.TabIndex = 4;
            textBoxExchange.Tag = "Exchange";
            textBoxExchange.TextChanged += textBoxExchange_TextChanged;
            // 
            // labelExchange
            // 
            labelExchange.AutoSize = true;
            labelExchange.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelExchange.Location = new Point(388, 8);
            labelExchange.Name = "labelExchange";
            labelExchange.Size = new Size(63, 15);
            labelExchange.TabIndex = 3;
            labelExchange.Text = "Exchange:";
            // 
            // panelTop
            // 
            panelTop.BorderStyle = BorderStyle.FixedSingle;
            panelTop.Controls.Add(textBoxPort);
            panelTop.Controls.Add(labelPort);
            panelTop.Controls.Add(textBoxPassword);
            panelTop.Controls.Add(textBoxLogin);
            panelTop.Controls.Add(textBoxServer);
            panelTop.Controls.Add(labelPassword);
            panelTop.Controls.Add(labelLogin);
            panelTop.Controls.Add(labelServer);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 24);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1110, 37);
            panelTop.TabIndex = 9;
            // 
            // textBoxPort
            // 
            textBoxPort.Location = new Point(291, 6);
            textBoxPort.Name = "textBoxPort";
            textBoxPort.PlaceholderText = "default 5672";
            textBoxPort.Size = new Size(74, 23);
            textBoxPort.TabIndex = 3;
            textBoxPort.TabStop = false;
            textBoxPort.Tag = "Login";
            textBoxPort.Validating += textBoxPort_Validating;
            // 
            // labelPort
            // 
            labelPort.AutoSize = true;
            labelPort.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelPort.Location = new Point(251, 9);
            labelPort.Name = "labelPort";
            labelPort.Size = new Size(34, 15);
            labelPort.TabIndex = 4;
            labelPort.Text = "Port:";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(729, 6);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.PlaceholderText = "Password";
            textBoxPassword.Size = new Size(190, 23);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.Tag = "Password";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(455, 6);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.PlaceholderText = "Login name";
            textBoxLogin.Size = new Size(190, 23);
            textBoxLogin.TabIndex = 1;
            textBoxLogin.Tag = "Login";
            // 
            // textBoxServer
            // 
            textBoxServer.Location = new Point(57, 6);
            textBoxServer.Name = "textBoxServer";
            textBoxServer.PlaceholderText = "FQDN or IP";
            textBoxServer.Size = new Size(190, 23);
            textBoxServer.TabIndex = 0;
            textBoxServer.Tag = "Server";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelPassword.Location = new Point(663, 9);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(62, 15);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Password:";
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelLogin.Location = new Point(409, 9);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(40, 15);
            labelLogin.TabIndex = 1;
            labelLogin.Text = "Login:";
            // 
            // labelServer
            // 
            labelServer.AutoSize = true;
            labelServer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelServer.Location = new Point(3, 9);
            labelServer.Name = "labelServer";
            labelServer.Size = new Size(48, 15);
            labelServer.TabIndex = 0;
            labelServer.Text = "Server:";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1110, 24);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadProfileToolStripMenuItem, saveProfileToolStripMenuItem, toolStripSeparator3, ExplorertoolStripMenuItem, ExplorerNoSsltoolStripMenuItem, toolStripSeparator1, closeToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // loadProfileToolStripMenuItem
            // 
            loadProfileToolStripMenuItem.Name = "loadProfileToolStripMenuItem";
            loadProfileToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.L;
            loadProfileToolStripMenuItem.Size = new Size(188, 22);
            loadProfileToolStripMenuItem.Text = "&Load Profile";
            loadProfileToolStripMenuItem.Click += loadProfileToolStripMenuItem_Click;
            // 
            // saveProfileToolStripMenuItem
            // 
            saveProfileToolStripMenuItem.Name = "saveProfileToolStripMenuItem";
            saveProfileToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveProfileToolStripMenuItem.Size = new Size(188, 22);
            saveProfileToolStripMenuItem.Text = "&Save Profile";
            saveProfileToolStripMenuItem.Click += saveProfileToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(185, 6);
            // 
            // ExplorertoolStripMenuItem
            // 
            ExplorertoolStripMenuItem.Name = "ExplorertoolStripMenuItem";
            ExplorertoolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
            ExplorertoolStripMenuItem.Size = new Size(188, 22);
            ExplorertoolStripMenuItem.Text = "&Explorer (SSL)";
            ExplorertoolStripMenuItem.Click += ExplorertoolStripMenuItem_Click;
            // 
            // ExplorerNoSsltoolStripMenuItem
            // 
            ExplorerNoSsltoolStripMenuItem.Name = "ExplorerNoSsltoolStripMenuItem";
            ExplorerNoSsltoolStripMenuItem.Size = new Size(188, 22);
            ExplorerNoSsltoolStripMenuItem.Text = "Explorer (No SSL)";
            ExplorerNoSsltoolStripMenuItem.Click += ExplorerNoSsltoolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(185, 6);
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            closeToolStripMenuItem.Size = new Size(188, 22);
            closeToolStripMenuItem.Text = "close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // panel2nd
            // 
            panel2nd.BorderStyle = BorderStyle.FixedSingle;
            panel2nd.Controls.Add(textBoxApiPort);
            panel2nd.Controls.Add(textBoxVhost);
            panel2nd.Controls.Add(labelApiPort);
            panel2nd.Controls.Add(labelVhost);
            panel2nd.Controls.Add(textBoxExchange);
            panel2nd.Controls.Add(labelExchange);
            panel2nd.Controls.Add(textBoxRoutingKey);
            panel2nd.Controls.Add(labelRoutingKey);
            panel2nd.Dock = DockStyle.Top;
            panel2nd.Location = new Point(0, 61);
            panel2nd.Name = "panel2nd";
            panel2nd.Size = new Size(1110, 37);
            panel2nd.TabIndex = 14;
            // 
            // textBoxApiPort
            // 
            textBoxApiPort.Location = new Point(57, 5);
            textBoxApiPort.Name = "textBoxApiPort";
            textBoxApiPort.Size = new Size(74, 23);
            textBoxApiPort.TabIndex = 5;
            textBoxApiPort.TabStop = false;
            textBoxApiPort.Tag = "Login";
            // 
            // textBoxVhost
            // 
            textBoxVhost.Location = new Point(257, 5);
            textBoxVhost.Name = "textBoxVhost";
            textBoxVhost.PlaceholderText = "default /";
            textBoxVhost.Size = new Size(108, 23);
            textBoxVhost.TabIndex = 7;
            textBoxVhost.Tag = "Exchange";
            // 
            // labelApiPort
            // 
            labelApiPort.AutoSize = true;
            labelApiPort.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelApiPort.Location = new Point(-1, 8);
            labelApiPort.Name = "labelApiPort";
            labelApiPort.Size = new Size(52, 15);
            labelApiPort.TabIndex = 6;
            labelApiPort.Text = "ApiPort:";
            // 
            // labelVhost
            // 
            labelVhost.AutoSize = true;
            labelVhost.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelVhost.Location = new Point(197, 8);
            labelVhost.Name = "labelVhost";
            labelVhost.Size = new Size(43, 15);
            labelVhost.TabIndex = 6;
            labelVhost.Text = "vHost:";
            // 
            // numericUpDownDelay
            // 
            numericUpDownDelay.Increment = new decimal(new int[] { 250, 0, 0, 0 });
            numericUpDownDelay.Location = new Point(245, 9);
            numericUpDownDelay.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownDelay.Minimum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDownDelay.Name = "numericUpDownDelay";
            numericUpDownDelay.Size = new Size(52, 23);
            numericUpDownDelay.TabIndex = 8;
            numericUpDownDelay.TextAlign = HorizontalAlignment.Center;
            numericUpDownDelay.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // checkBoxRepeatSend
            // 
            checkBoxRepeatSend.AutoSize = true;
            checkBoxRepeatSend.Location = new Point(124, 10);
            checkBoxRepeatSend.Name = "checkBoxRepeatSend";
            checkBoxRepeatSend.Size = new Size(117, 19);
            checkBoxRepeatSend.TabIndex = 7;
            checkBoxRepeatSend.Text = "repeat / delay ms";
            checkBoxRepeatSend.UseVisualStyleBackColor = true;
            checkBoxRepeatSend.CheckedChanged += checkBoxRepeatSend_CheckedChanged;
            // 
            // panelSendButton
            // 
            panelSendButton.BorderStyle = BorderStyle.FixedSingle;
            panelSendButton.Controls.Add(numericUpDownDelay);
            panelSendButton.Controls.Add(buttonSend);
            panelSendButton.Controls.Add(checkBoxRepeatSend);
            panelSendButton.Dock = DockStyle.Top;
            panelSendButton.Location = new Point(0, 0);
            panelSendButton.Name = "panelSendButton";
            panelSendButton.Size = new Size(719, 37);
            panelSendButton.TabIndex = 15;
            // 
            // panelSendFile
            // 
            panelSendFile.BorderStyle = BorderStyle.FixedSingle;
            panelSendFile.Controls.Add(buttonSendFile);
            panelSendFile.Dock = DockStyle.Top;
            panelSendFile.Location = new Point(0, 37);
            panelSendFile.Name = "panelSendFile";
            panelSendFile.Size = new Size(719, 37);
            panelSendFile.TabIndex = 16;
            // 
            // buttonSendFile
            // 
            buttonSendFile.Location = new Point(16, 6);
            buttonSendFile.Name = "buttonSendFile";
            buttonSendFile.Size = new Size(102, 23);
            buttonSendFile.TabIndex = 6;
            buttonSendFile.TabStop = false;
            buttonSendFile.Text = "Load File";
            buttonSendFile.UseVisualStyleBackColor = true;
            buttonSendFile.Click += buttonLoadFile_Click;
            // 
            // scintilla
            // 
            scintilla.AutocompleteListSelectedBackColor = Color.FromArgb(0, 120, 215);
            scintilla.Dock = DockStyle.Fill;
            scintilla.LexerName = null;
            scintilla.Location = new Point(0, 0);
            scintilla.Name = "scintilla";
            scintilla.ScrollWidth = 164;
            scintilla.Size = new Size(383, 441);
            scintilla.TabIndex = 17;
            scintilla.Text = "{\r\n\"greeting\" : \"Hello World :-)\"\r\n} ";
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.FixedSingle;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 98);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(scintilla);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panelSendFile);
            splitContainer1.Panel2.Controls.Add(panelSendButton);
            splitContainer1.Size = new Size(1110, 443);
            splitContainer1.SplitterDistance = 385;
            splitContainer1.TabIndex = 18;
            // 
            // FormPublisher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 541);
            Controls.Add(splitContainer1);
            Controls.Add(panel2nd);
            Controls.Add(panelTop);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormPublisher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Publisher";
            FormClosing += FormProducer_FormClosing;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2nd.ResumeLayout(false);
            panel2nd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDelay).EndInit();
            panelSendButton.ResumeLayout(false);
            panelSendButton.PerformLayout();
            panelSendFile.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSend;
        private Label labelRoutingKey;
        private TextBox textBoxRoutingKey;
        private TextBox textBoxExchange;
        private Label labelExchange;
        private Panel panelTop;
        private TextBox textBoxPassword;
        private TextBox textBoxLogin;
        private TextBox textBoxServer;
        private Label labelPassword;
        private Label labelLogin;
        private Label labelServer;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveProfileToolStripMenuItem;
        private ToolStripMenuItem loadProfileToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private Panel panel2nd;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem closeToolStripMenuItem;
        private NumericUpDown numericUpDownDelay;
        private CheckBox checkBoxRepeatSend;
        private TextBox textBoxPort;
        private Label labelPort;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem ExplorertoolStripMenuItem;
        private Panel panelSendButton;
        private Panel panelSendFile;
        private Button buttonSendFile;
        private ToolStripMenuItem ExplorerNoSsltoolStripMenuItem;
        private TextBox textBoxVhost;
        private Label labelVhost;
        private ScintillaNET.Scintilla scintilla;
        private TextBox textBoxApiPort;
        private Label labelApiPort;
        private SplitContainer splitContainer1;
    }
}
