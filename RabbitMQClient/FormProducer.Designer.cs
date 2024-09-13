namespace RabbitMQClient
{
    partial class FormProducer
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProducer));
            buttonSend = new Button();
            labelRoutingKey = new Label();
            textBoxRoutingKey = new TextBox();
            textBoxExchange = new TextBox();
            labelExchange = new Label();
            textBoxQueue = new TextBox();
            labelQueue = new Label();
            textBoxMessage = new TextBox();
            panel1 = new Panel();
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
            panel2 = new Panel();
            numericUpDownDelay = new NumericUpDown();
            checkBoxRepeatSend = new CheckBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            seleceAllToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            clearToolStripMenuItem = new ToolStripMenuItem();
            panel3 = new Panel();
            panel4 = new Panel();
            buttonSendFile = new Button();
            textBoxVhost = new TextBox();
            labelVhost = new Label();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDelay).BeginInit();
            contextMenuStrip1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
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
            textBoxRoutingKey.Location = new Point(729, 3);
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
            // textBoxQueue
            // 
            textBoxQueue.Location = new Point(58, 6);
            textBoxQueue.Name = "textBoxQueue";
            textBoxQueue.Size = new Size(28, 23);
            textBoxQueue.TabIndex = 3;
            textBoxQueue.Tag = "Queue";
            textBoxQueue.Visible = false;
            // 
            // labelQueue
            // 
            labelQueue.AutoSize = true;
            labelQueue.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Strikeout);
            labelQueue.Location = new Point(5, 9);
            labelQueue.Name = "labelQueue";
            labelQueue.Size = new Size(47, 15);
            labelQueue.TabIndex = 5;
            labelQueue.Text = "Queue:";
            labelQueue.Visible = false;
            // 
            // textBoxMessage
            // 
            textBoxMessage.BackColor = Color.SteelBlue;
            textBoxMessage.Dock = DockStyle.Left;
            textBoxMessage.Font = new Font("Courier New", 11F);
            textBoxMessage.Location = new Point(0, 98);
            textBoxMessage.Multiline = true;
            textBoxMessage.Name = "textBoxMessage";
            textBoxMessage.Size = new Size(552, 443);
            textBoxMessage.TabIndex = 0;
            textBoxMessage.TabStop = false;
            textBoxMessage.Text = "Hello World!";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBoxPort);
            panel1.Controls.Add(labelPort);
            panel1.Controls.Add(textBoxPassword);
            panel1.Controls.Add(textBoxLogin);
            panel1.Controls.Add(textBoxServer);
            panel1.Controls.Add(labelPassword);
            panel1.Controls.Add(labelLogin);
            panel1.Controls.Add(labelServer);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(1110, 37);
            panel1.TabIndex = 9;
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
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(textBoxVhost);
            panel2.Controls.Add(labelVhost);
            panel2.Controls.Add(labelQueue);
            panel2.Controls.Add(textBoxQueue);
            panel2.Controls.Add(textBoxExchange);
            panel2.Controls.Add(labelExchange);
            panel2.Controls.Add(textBoxRoutingKey);
            panel2.Controls.Add(labelRoutingKey);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(1110, 37);
            panel2.TabIndex = 14;
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
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { seleceAllToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, toolStripSeparator2, clearToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(122, 98);
            // 
            // seleceAllToolStripMenuItem
            // 
            seleceAllToolStripMenuItem.Name = "seleceAllToolStripMenuItem";
            seleceAllToolStripMenuItem.Size = new Size(121, 22);
            seleceAllToolStripMenuItem.Text = "selece all";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(121, 22);
            copyToolStripMenuItem.Text = "copy";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(121, 22);
            pasteToolStripMenuItem.Text = "paste";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(118, 6);
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(121, 22);
            clearToolStripMenuItem.Text = "clear";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(numericUpDownDelay);
            panel3.Controls.Add(buttonSend);
            panel3.Controls.Add(checkBoxRepeatSend);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(552, 98);
            panel3.Name = "panel3";
            panel3.Size = new Size(558, 37);
            panel3.TabIndex = 15;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(buttonSendFile);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(552, 135);
            panel4.Name = "panel4";
            panel4.Size = new Size(558, 37);
            panel4.TabIndex = 16;
            // 
            // buttonSendFile
            // 
            buttonSendFile.Location = new Point(16, 6);
            buttonSendFile.Name = "buttonSendFile";
            buttonSendFile.Size = new Size(102, 23);
            buttonSendFile.TabIndex = 6;
            buttonSendFile.TabStop = false;
            buttonSendFile.Text = "Send File";
            buttonSendFile.UseVisualStyleBackColor = true;
            buttonSendFile.Click += buttonSendFile_Click;
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
            // labelVhost
            // 
            labelVhost.AutoSize = true;
            labelVhost.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelVhost.Location = new Point(208, 8);
            labelVhost.Name = "labelVhost";
            labelVhost.Size = new Size(43, 15);
            labelVhost.TabIndex = 6;
            labelVhost.Text = "vHost:";
            // 
            // FormProducer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 541);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(textBoxMessage);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormProducer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Producer";
            FormClosing += FormProducer_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDelay).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSend;
        private Label labelRoutingKey;
        private TextBox textBoxRoutingKey;
        private TextBox textBoxExchange;
        private Label labelExchange;
        private TextBox textBoxQueue;
        private Label labelQueue;
        private TextBox textBoxMessage;
        private Panel panel1;
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
        private Panel panel2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem seleceAllToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem clearToolStripMenuItem;
        private NumericUpDown numericUpDownDelay;
        private CheckBox checkBoxRepeatSend;
        private TextBox textBoxPort;
        private Label labelPort;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem ExplorertoolStripMenuItem;
        private Panel panel3;
        private Panel panel4;
        private Button buttonSendFile;
        private ToolStripMenuItem ExplorerNoSsltoolStripMenuItem;
        private TextBox textBoxVhost;
        private Label labelVhost;
    }
}
