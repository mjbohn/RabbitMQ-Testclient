﻿namespace RabbitMQClient
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
            toolStripSeparator1 = new ToolStripSeparator();
            closeToolStripMenuItem = new ToolStripMenuItem();
            saveFileDialog1 = new SaveFileDialog();
            panel2 = new Panel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            seleceAllToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            clearToolStripMenuItem = new ToolStripMenuItem();
            checkBoxRepeatSend = new CheckBox();
            numericUpDown1 = new NumericUpDown();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // buttonSend
            // 
            buttonSend.Location = new Point(790, 4);
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
            labelRoutingKey.Location = new Point(514, 12);
            labelRoutingKey.Name = "labelRoutingKey";
            labelRoutingKey.Size = new Size(74, 15);
            labelRoutingKey.TabIndex = 1;
            labelRoutingKey.Text = "Routing Key:";
            // 
            // textBoxRoutingKey
            // 
            textBoxRoutingKey.Location = new Point(594, 4);
            textBoxRoutingKey.Name = "textBoxRoutingKey";
            textBoxRoutingKey.Size = new Size(190, 23);
            textBoxRoutingKey.TabIndex = 5;
            textBoxRoutingKey.Tag = "RoutingKey";
            textBoxRoutingKey.TextChanged += textBoxRoutingKey_TextChanged;
            // 
            // textBoxExchange
            // 
            textBoxExchange.Location = new Point(320, 6);
            textBoxExchange.Name = "textBoxExchange";
            textBoxExchange.Size = new Size(190, 23);
            textBoxExchange.TabIndex = 4;
            textBoxExchange.Tag = "Exchange";
            textBoxExchange.TextChanged += textBoxExchange_TextChanged;
            // 
            // labelExchange
            // 
            labelExchange.AutoSize = true;
            labelExchange.Location = new Point(253, 12);
            labelExchange.Name = "labelExchange";
            labelExchange.Size = new Size(61, 15);
            labelExchange.TabIndex = 3;
            labelExchange.Text = "Exchange:";
            // 
            // textBoxQueue
            // 
            textBoxQueue.Location = new Point(58, 6);
            textBoxQueue.Name = "textBoxQueue";
            textBoxQueue.Size = new Size(190, 23);
            textBoxQueue.TabIndex = 3;
            textBoxQueue.Tag = "Queue";
            textBoxQueue.Visible = false;
            // 
            // labelQueue
            // 
            labelQueue.AutoSize = true;
            labelQueue.Location = new Point(13, 12);
            labelQueue.Name = "labelQueue";
            labelQueue.Size = new Size(45, 15);
            labelQueue.TabIndex = 5;
            labelQueue.Text = "Queue:";
            labelQueue.Visible = false;
            // 
            // textBoxMessage
            // 
            textBoxMessage.BackColor = Color.SteelBlue;
            textBoxMessage.Dock = DockStyle.Fill;
            textBoxMessage.Font = new Font("Courier New", 11F);
            textBoxMessage.Location = new Point(0, 98);
            textBoxMessage.Multiline = true;
            textBoxMessage.Name = "textBoxMessage";
            textBoxMessage.Size = new Size(1076, 443);
            textBoxMessage.TabIndex = 0;
            textBoxMessage.TabStop = false;
            textBoxMessage.Text = "Hello World!";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBoxPassword);
            panel1.Controls.Add(textBoxLogin);
            panel1.Controls.Add(textBoxServer);
            panel1.Controls.Add(labelPassword);
            panel1.Controls.Add(labelLogin);
            panel1.Controls.Add(labelServer);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(1076, 37);
            panel1.TabIndex = 9;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(593, 6);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(190, 23);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.Tag = "Password";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(319, 6);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(190, 23);
            textBoxLogin.TabIndex = 1;
            textBoxLogin.Tag = "Login";
            textBoxLogin.Text = "Login";
            // 
            // textBoxServer
            // 
            textBoxServer.Location = new Point(57, 6);
            textBoxServer.Name = "textBoxServer";
            textBoxServer.Size = new Size(190, 23);
            textBoxServer.TabIndex = 0;
            textBoxServer.Tag = "Server";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(527, 14);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(60, 15);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Password:";
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Location = new Point(253, 14);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(40, 15);
            labelLogin.TabIndex = 1;
            labelLogin.Text = "Login:";
            // 
            // labelServer
            // 
            labelServer.AutoSize = true;
            labelServer.Location = new Point(12, 14);
            labelServer.Name = "labelServer";
            labelServer.Size = new Size(42, 15);
            labelServer.TabIndex = 0;
            labelServer.Text = "Server:";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1076, 24);
            menuStrip1.TabIndex = 13;
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
            // panel2
            // 
            panel2.Controls.Add(numericUpDown1);
            panel2.Controls.Add(checkBoxRepeatSend);
            panel2.Controls.Add(labelQueue);
            panel2.Controls.Add(textBoxQueue);
            panel2.Controls.Add(textBoxExchange);
            panel2.Controls.Add(buttonSend);
            panel2.Controls.Add(labelExchange);
            panel2.Controls.Add(textBoxRoutingKey);
            panel2.Controls.Add(labelRoutingKey);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(1076, 37);
            panel2.TabIndex = 14;
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
            // checkBoxRepeatSend
            // 
            checkBoxRepeatSend.AutoSize = true;
            checkBoxRepeatSend.Location = new Point(898, 8);
            checkBoxRepeatSend.Name = "checkBoxRepeatSend";
            checkBoxRepeatSend.Size = new Size(118, 19);
            checkBoxRepeatSend.TabIndex = 7;
            checkBoxRepeatSend.Text = "repeat / delay sec";
            checkBoxRepeatSend.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(1019, 7);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(45, 23);
            numericUpDown1.TabIndex = 8;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // FormProducer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 541);
            Controls.Add(textBoxMessage);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormProducer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Producer";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
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
        private NumericUpDown numericUpDown1;
        private CheckBox checkBoxRepeatSend;
    }
}
