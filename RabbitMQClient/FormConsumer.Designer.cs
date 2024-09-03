namespace RabbitMQClient
{
    partial class FormConsumer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsumer));
            panel1 = new Panel();
            textBoxClientName = new TextBox();
            labelClientName = new Label();
            textBoxQueue = new TextBox();
            labelQueue = new Label();
            textBoxPassword = new TextBox();
            textBoxLogin = new TextBox();
            textBoxServer = new TextBox();
            labelPassword = new Label();
            labelLogin = new Label();
            labelServer = new Label();
            panel2 = new Panel();
            panelAck = new Panel();
            checkBoxMultiple = new CheckBox();
            buttonApply = new Button();
            checkBoxRequeue = new CheckBox();
            radioButtonReject = new RadioButton();
            radioButtonNack = new RadioButton();
            radioButtonAck = new RadioButton();
            buttonStop = new Button();
            buttonStart = new Button();
            rtbReceivedMessages = new RichTextBox();
            checkBoxAddLF = new CheckBox();
            panel3 = new Panel();
            labelPrefetch = new Label();
            numericUpDownPrefetch = new NumericUpDown();
            checkBoxAutoAck = new CheckBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            loadProfileToolStripMenuItem = new ToolStripMenuItem();
            saveProfileToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            closeToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panelAck.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrefetch).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBoxClientName);
            panel1.Controls.Add(labelClientName);
            panel1.Controls.Add(textBoxQueue);
            panel1.Controls.Add(labelQueue);
            panel1.Controls.Add(textBoxPassword);
            panel1.Controls.Add(textBoxLogin);
            panel1.Controls.Add(textBoxServer);
            panel1.Controls.Add(labelPassword);
            panel1.Controls.Add(labelLogin);
            panel1.Controls.Add(labelServer);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(1014, 68);
            panel1.TabIndex = 10;
            // 
            // textBoxClientName
            // 
            textBoxClientName.Location = new Point(299, 38);
            textBoxClientName.Name = "textBoxClientName";
            textBoxClientName.PlaceholderText = "Client #42";
            textBoxClientName.Size = new Size(190, 23);
            textBoxClientName.TabIndex = 4;
            textBoxClientName.Tag = "";
            // 
            // labelClientName
            // 
            labelClientName.AutoSize = true;
            labelClientName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelClientName.Location = new Point(218, 41);
            labelClientName.Name = "labelClientName";
            labelClientName.Size = new Size(75, 15);
            labelClientName.TabIndex = 8;
            labelClientName.Text = "ClientName:";
            // 
            // textBoxQueue
            // 
            textBoxQueue.Location = new Point(805, 6);
            textBoxQueue.Name = "textBoxQueue";
            textBoxQueue.PlaceholderText = "Queue Name";
            textBoxQueue.Size = new Size(190, 23);
            textBoxQueue.TabIndex = 3;
            textBoxQueue.Tag = "";
            textBoxQueue.TextChanged += textBoxQueue_TextChanged;
            // 
            // labelQueue
            // 
            labelQueue.AutoSize = true;
            labelQueue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelQueue.Location = new Point(754, 9);
            labelQueue.Name = "labelQueue";
            labelQueue.Size = new Size(47, 15);
            labelQueue.TabIndex = 6;
            labelQueue.Text = "Queue:";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(561, 6);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(190, 23);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.Tag = "";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(299, 6);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.PlaceholderText = "User Name";
            textBoxLogin.Size = new Size(190, 23);
            textBoxLogin.TabIndex = 1;
            textBoxLogin.Tag = "";
            // 
            // textBoxServer
            // 
            textBoxServer.Location = new Point(57, 6);
            textBoxServer.Name = "textBoxServer";
            textBoxServer.PlaceholderText = "RabbitMQ Server";
            textBoxServer.Size = new Size(190, 23);
            textBoxServer.TabIndex = 0;
            textBoxServer.Tag = "";
            textBoxServer.TextChanged += textBoxServer_TextChanged;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelPassword.Location = new Point(495, 9);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(62, 15);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Password:";
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelLogin.Location = new Point(253, 9);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(40, 15);
            labelLogin.TabIndex = 1;
            labelLogin.Text = "Login:";
            // 
            // labelServer
            // 
            labelServer.AutoSize = true;
            labelServer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelServer.Location = new Point(12, 9);
            labelServer.Name = "labelServer";
            labelServer.Size = new Size(48, 15);
            labelServer.TabIndex = 0;
            labelServer.Text = "Server:";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(panelAck);
            panel2.Controls.Add(buttonStop);
            panel2.Controls.Add(buttonStart);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 92);
            panel2.Name = "panel2";
            panel2.Size = new Size(1014, 37);
            panel2.TabIndex = 11;
            // 
            // panelAck
            // 
            panelAck.BackColor = Color.Wheat;
            panelAck.BorderStyle = BorderStyle.FixedSingle;
            panelAck.Controls.Add(checkBoxMultiple);
            panelAck.Controls.Add(buttonApply);
            panelAck.Controls.Add(checkBoxRequeue);
            panelAck.Controls.Add(radioButtonReject);
            panelAck.Controls.Add(radioButtonNack);
            panelAck.Controls.Add(radioButtonAck);
            panelAck.Location = new Point(267, 1);
            panelAck.Name = "panelAck";
            panelAck.Size = new Size(573, 33);
            panelAck.TabIndex = 2;
            panelAck.Visible = false;
            // 
            // checkBoxMultiple
            // 
            checkBoxMultiple.AutoSize = true;
            checkBoxMultiple.CheckAlign = ContentAlignment.MiddleRight;
            checkBoxMultiple.Location = new Point(443, 6);
            checkBoxMultiple.Name = "checkBoxMultiple";
            checkBoxMultiple.Size = new Size(70, 19);
            checkBoxMultiple.TabIndex = 5;
            checkBoxMultiple.TabStop = false;
            checkBoxMultiple.Text = "Multiple";
            checkBoxMultiple.UseVisualStyleBackColor = true;
            // 
            // buttonApply
            // 
            buttonApply.Enabled = false;
            buttonApply.Location = new Point(347, 3);
            buttonApply.Name = "buttonApply";
            buttonApply.Size = new Size(75, 23);
            buttonApply.TabIndex = 4;
            buttonApply.Text = "Apply";
            buttonApply.UseVisualStyleBackColor = true;
            buttonApply.Click += buttonApply_Click;
            // 
            // checkBoxRequeue
            // 
            checkBoxRequeue.AutoSize = true;
            checkBoxRequeue.CheckAlign = ContentAlignment.MiddleRight;
            checkBoxRequeue.Enabled = false;
            checkBoxRequeue.Location = new Point(239, 6);
            checkBoxRequeue.Name = "checkBoxRequeue";
            checkBoxRequeue.Size = new Size(72, 19);
            checkBoxRequeue.TabIndex = 3;
            checkBoxRequeue.TabStop = false;
            checkBoxRequeue.Text = "Requeue";
            checkBoxRequeue.UseVisualStyleBackColor = true;
            // 
            // radioButtonReject
            // 
            radioButtonReject.AutoSize = true;
            radioButtonReject.CheckAlign = ContentAlignment.MiddleRight;
            radioButtonReject.Location = new Point(160, 5);
            radioButtonReject.Name = "radioButtonReject";
            radioButtonReject.Size = new Size(57, 19);
            radioButtonReject.TabIndex = 2;
            radioButtonReject.Text = "Reject";
            radioButtonReject.UseVisualStyleBackColor = true;
            // 
            // radioButtonNack
            // 
            radioButtonNack.AutoSize = true;
            radioButtonNack.CheckAlign = ContentAlignment.MiddleRight;
            radioButtonNack.Location = new Point(86, 5);
            radioButtonNack.Name = "radioButtonNack";
            radioButtonNack.Size = new Size(52, 19);
            radioButtonNack.TabIndex = 1;
            radioButtonNack.Text = "Nack";
            radioButtonNack.UseVisualStyleBackColor = true;
            radioButtonNack.CheckedChanged += radioButtonNack_CheckedChanged;
            // 
            // radioButtonAck
            // 
            radioButtonAck.AutoSize = true;
            radioButtonAck.CheckAlign = ContentAlignment.MiddleRight;
            radioButtonAck.Checked = true;
            radioButtonAck.Location = new Point(19, 5);
            radioButtonAck.Name = "radioButtonAck";
            radioButtonAck.Size = new Size(45, 19);
            radioButtonAck.TabIndex = 0;
            radioButtonAck.TabStop = true;
            radioButtonAck.Text = "Ack";
            radioButtonAck.UseVisualStyleBackColor = true;
            radioButtonAck.CheckedChanged += radioButtonAck_CheckedChanged;
            // 
            // buttonStop
            // 
            buttonStop.BackColor = Color.IndianRed;
            buttonStop.Enabled = false;
            buttonStop.Location = new Point(92, 7);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(75, 23);
            buttonStop.TabIndex = 1;
            buttonStop.TabStop = false;
            buttonStop.Text = "Stop";
            buttonStop.UseVisualStyleBackColor = false;
            buttonStop.Click += ButtonStop_Click;
            // 
            // buttonStart
            // 
            buttonStart.BackColor = Color.YellowGreen;
            buttonStart.Location = new Point(11, 7);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(75, 23);
            buttonStart.TabIndex = 0;
            buttonStart.TabStop = false;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += ButtonStart_Click;
            // 
            // rtbReceivedMessages
            // 
            rtbReceivedMessages.BackColor = Color.Wheat;
            rtbReceivedMessages.Dock = DockStyle.Fill;
            rtbReceivedMessages.Location = new Point(0, 129);
            rtbReceivedMessages.Name = "rtbReceivedMessages";
            rtbReceivedMessages.ReadOnly = true;
            rtbReceivedMessages.Size = new Size(1014, 412);
            rtbReceivedMessages.TabIndex = 12;
            rtbReceivedMessages.TabStop = false;
            rtbReceivedMessages.Text = "";
            // 
            // checkBoxAddLF
            // 
            checkBoxAddLF.AutoSize = true;
            checkBoxAddLF.CheckAlign = ContentAlignment.MiddleRight;
            checkBoxAddLF.Checked = true;
            checkBoxAddLF.CheckState = CheckState.Checked;
            checkBoxAddLF.Location = new Point(3, 8);
            checkBoxAddLF.Name = "checkBoxAddLF";
            checkBoxAddLF.Size = new Size(67, 19);
            checkBoxAddLF.TabIndex = 2;
            checkBoxAddLF.TabStop = false;
            checkBoxAddLF.Text = "add '\\n'";
            checkBoxAddLF.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(labelPrefetch);
            panel3.Controls.Add(numericUpDownPrefetch);
            panel3.Controls.Add(checkBoxAutoAck);
            panel3.Controls.Add(checkBoxAddLF);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 501);
            panel3.Name = "panel3";
            panel3.Size = new Size(1014, 40);
            panel3.TabIndex = 13;
            // 
            // labelPrefetch
            // 
            labelPrefetch.AutoSize = true;
            labelPrefetch.Location = new Point(153, 9);
            labelPrefetch.Name = "labelPrefetch";
            labelPrefetch.Size = new Size(51, 15);
            labelPrefetch.TabIndex = 5;
            labelPrefetch.Text = "prefetch";
            // 
            // numericUpDownPrefetch
            // 
            numericUpDownPrefetch.Location = new Point(210, 7);
            numericUpDownPrefetch.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownPrefetch.Name = "numericUpDownPrefetch";
            numericUpDownPrefetch.Size = new Size(45, 23);
            numericUpDownPrefetch.TabIndex = 4;
            numericUpDownPrefetch.TabStop = false;
            numericUpDownPrefetch.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // checkBoxAutoAck
            // 
            checkBoxAutoAck.AutoSize = true;
            checkBoxAutoAck.CheckAlign = ContentAlignment.MiddleRight;
            checkBoxAutoAck.Checked = true;
            checkBoxAutoAck.CheckState = CheckState.Checked;
            checkBoxAutoAck.Location = new Point(76, 8);
            checkBoxAutoAck.Name = "checkBoxAutoAck";
            checkBoxAutoAck.Size = new Size(71, 19);
            checkBoxAutoAck.TabIndex = 3;
            checkBoxAutoAck.TabStop = false;
            checkBoxAutoAck.Text = "auto ack";
            checkBoxAutoAck.UseVisualStyleBackColor = true;
            checkBoxAutoAck.CheckedChanged += checkBoxAutoAck_CheckedChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1014, 24);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadProfileToolStripMenuItem, saveProfileToolStripMenuItem, toolStripSeparator1, closeToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // loadProfileToolStripMenuItem
            // 
            loadProfileToolStripMenuItem.Name = "loadProfileToolStripMenuItem";
            loadProfileToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.L;
            loadProfileToolStripMenuItem.Size = new Size(179, 22);
            loadProfileToolStripMenuItem.Text = "&Load Profile";
            loadProfileToolStripMenuItem.Click += loadProfileToolStripMenuItem_Click;
            // 
            // saveProfileToolStripMenuItem
            // 
            saveProfileToolStripMenuItem.Name = "saveProfileToolStripMenuItem";
            saveProfileToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveProfileToolStripMenuItem.Size = new Size(179, 22);
            saveProfileToolStripMenuItem.Text = "&Save Profile";
            saveProfileToolStripMenuItem.Click += saveProfileToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(176, 6);
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            closeToolStripMenuItem.Size = new Size(179, 22);
            closeToolStripMenuItem.Text = "close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // FormConsumer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 541);
            Controls.Add(panel3);
            Controls.Add(rtbReceivedMessages);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormConsumer";
            Text = "Consumer";
            FormClosing += FormConsumer_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panelAck.ResumeLayout(false);
            panelAck.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrefetch).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBoxPassword;
        private TextBox textBoxLogin;
        private TextBox textBoxServer;
        private Label labelPassword;
        private Label labelLogin;
        private Label labelServer;
        private TextBox textBoxQueue;
        private Label labelQueue;
        private Panel panel2;
        private Button buttonStart;
        private RichTextBox rtbReceivedMessages;
        private Button buttonStop;
        private CheckBox checkBoxAddLF;
        private Panel panel3;
        private TextBox textBoxClientName;
        private Label labelClientName;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveProfileToolStripMenuItem;
        private ToolStripMenuItem loadProfileToolStripMenuItem;
        private CheckBox checkBoxAutoAck;
        private Label labelPrefetch;
        private NumericUpDown numericUpDownPrefetch;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem closeToolStripMenuItem;
        private Panel panelAck;
        private RadioButton radioButtonReject;
        private RadioButton radioButtonNack;
        private RadioButton radioButtonAck;
        private CheckBox checkBoxRequeue;
        private Button buttonApply;
        private CheckBox checkBoxMultiple;
    }
}