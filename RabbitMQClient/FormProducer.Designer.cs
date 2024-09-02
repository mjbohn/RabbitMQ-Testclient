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
            saveProfileToolStripMenuItem = new ToolStripMenuItem();
            loadProfileToolStripMenuItem = new ToolStripMenuItem();
            saveFileDialog1 = new SaveFileDialog();
            panel2 = new Panel();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSend
            // 
            buttonSend.Location = new Point(834, 4);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(102, 23);
            buttonSend.TabIndex = 0;
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
            textBoxRoutingKey.TabIndex = 2;
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
            textBoxQueue.TabIndex = 6;
            textBoxQueue.Tag = "Queue";
            // 
            // labelQueue
            // 
            labelQueue.AutoSize = true;
            labelQueue.Location = new Point(13, 12);
            labelQueue.Name = "labelQueue";
            labelQueue.Size = new Size(45, 15);
            labelQueue.TabIndex = 5;
            labelQueue.Text = "Queue:";
            // 
            // textBoxMessage
            // 
            textBoxMessage.BackColor = Color.SteelBlue;
            textBoxMessage.Dock = DockStyle.Fill;
            textBoxMessage.Font = new Font("Courier New", 11F);
            textBoxMessage.Location = new Point(0, 98);
            textBoxMessage.Multiline = true;
            textBoxMessage.Name = "textBoxMessage";
            textBoxMessage.Size = new Size(1014, 443);
            textBoxMessage.TabIndex = 7;
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
            panel1.Size = new Size(1014, 37);
            panel1.TabIndex = 9;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(593, 6);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(190, 23);
            textBoxPassword.TabIndex = 5;
            textBoxPassword.Tag = "Password";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(319, 6);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(190, 23);
            textBoxLogin.TabIndex = 4;
            textBoxLogin.Tag = "Login";
            textBoxLogin.Text = "Login";
            // 
            // textBoxServer
            // 
            textBoxServer.Location = new Point(57, 6);
            textBoxServer.Name = "textBoxServer";
            textBoxServer.Size = new Size(190, 23);
            textBoxServer.TabIndex = 3;
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
            menuStrip1.Size = new Size(1014, 24);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveProfileToolStripMenuItem, loadProfileToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // saveProfileToolStripMenuItem
            // 
            saveProfileToolStripMenuItem.Name = "saveProfileToolStripMenuItem";
            saveProfileToolStripMenuItem.Size = new Size(137, 22);
            saveProfileToolStripMenuItem.Text = "&Save Profile";
            saveProfileToolStripMenuItem.Click += saveProfileToolStripMenuItem_Click;
            // 
            // loadProfileToolStripMenuItem
            // 
            loadProfileToolStripMenuItem.Name = "loadProfileToolStripMenuItem";
            loadProfileToolStripMenuItem.Size = new Size(137, 22);
            loadProfileToolStripMenuItem.Text = "&Load Profile";
            loadProfileToolStripMenuItem.Click += loadProfileToolStripMenuItem_Click;
            // 
            // panel2
            // 
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
            panel2.Size = new Size(1014, 37);
            panel2.TabIndex = 14;
            // 
            // FormProducer
            // 
            AcceptButton = buttonSend;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 541);
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
    }
}
