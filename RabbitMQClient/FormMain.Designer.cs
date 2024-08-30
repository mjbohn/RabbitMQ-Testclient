﻿namespace RabbitMQClient
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonSend = new Button();
            labelRoutingKey = new Label();
            textBoxRoutingKey = new TextBox();
            textBoxExchange = new TextBox();
            labelExchange = new Label();
            textBoxQueue = new TextBox();
            labelQueue = new Label();
            textBoxMessage = new TextBox();
            labelMessage = new Label();
            panel1 = new Panel();
            textBoxPassword = new TextBox();
            textBoxLogin = new TextBox();
            textBoxServer = new TextBox();
            labelPassword = new Label();
            labelLogin = new Label();
            labelServer = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSend
            // 
            buttonSend.Location = new Point(218, 268);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(75, 23);
            buttonSend.TabIndex = 0;
            buttonSend.Text = "Send";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += button1_Click;
            // 
            // labelRoutingKey
            // 
            labelRoutingKey.AutoSize = true;
            labelRoutingKey.Location = new Point(10, 121);
            labelRoutingKey.Name = "labelRoutingKey";
            labelRoutingKey.Size = new Size(74, 15);
            labelRoutingKey.TabIndex = 1;
            labelRoutingKey.Text = "Routing Key:";
            // 
            // textBoxRoutingKey
            // 
            textBoxRoutingKey.Location = new Point(90, 118);
            textBoxRoutingKey.Name = "textBoxRoutingKey";
            textBoxRoutingKey.Size = new Size(203, 23);
            textBoxRoutingKey.TabIndex = 2;
            textBoxRoutingKey.Tag = "RoutingKey";
            textBoxRoutingKey.TextChanged += WriteChangeToConfigFile;
            // 
            // textBoxExchange
            // 
            textBoxExchange.Location = new Point(90, 89);
            textBoxExchange.Name = "textBoxExchange";
            textBoxExchange.Size = new Size(203, 23);
            textBoxExchange.TabIndex = 4;
            textBoxExchange.Tag = "Exchange";
            textBoxExchange.TextChanged += WriteChangeToConfigFile;
            // 
            // labelExchange
            // 
            labelExchange.AutoSize = true;
            labelExchange.Location = new Point(10, 92);
            labelExchange.Name = "labelExchange";
            labelExchange.Size = new Size(61, 15);
            labelExchange.TabIndex = 3;
            labelExchange.Text = "Exchange:";
            // 
            // textBoxQueue
            // 
            textBoxQueue.Location = new Point(90, 43);
            textBoxQueue.Name = "textBoxQueue";
            textBoxQueue.Size = new Size(203, 23);
            textBoxQueue.TabIndex = 6;
            textBoxQueue.Tag = "Queue";
            textBoxQueue.TextChanged += WriteChangeToConfigFile;
            // 
            // labelQueue
            // 
            labelQueue.AutoSize = true;
            labelQueue.Location = new Point(10, 46);
            labelQueue.Name = "labelQueue";
            labelQueue.Size = new Size(45, 15);
            labelQueue.TabIndex = 5;
            labelQueue.Text = "Queue:";
            // 
            // textBoxMessage
            // 
            textBoxMessage.Location = new Point(90, 196);
            textBoxMessage.Multiline = true;
            textBoxMessage.Name = "textBoxMessage";
            textBoxMessage.Size = new Size(203, 53);
            textBoxMessage.TabIndex = 7;
            textBoxMessage.Text = "Hello World!";
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Location = new Point(10, 199);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(56, 15);
            labelMessage.TabIndex = 8;
            labelMessage.Text = "Message:";
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxPassword);
            panel1.Controls.Add(textBoxLogin);
            panel1.Controls.Add(textBoxServer);
            panel1.Controls.Add(labelPassword);
            panel1.Controls.Add(labelLogin);
            panel1.Controls.Add(labelServer);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1021, 37);
            panel1.TabIndex = 9;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(561, 6);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(190, 23);
            textBoxPassword.TabIndex = 5;
            textBoxPassword.Tag = "Password";
            textBoxPassword.TextChanged += WriteChangeToConfigFile;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(299, 6);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(190, 23);
            textBoxLogin.TabIndex = 4;
            textBoxLogin.Tag = "Login";
            textBoxLogin.Text = "Login";
            textBoxLogin.TextChanged += WriteChangeToConfigFile;
            // 
            // textBoxServer
            // 
            textBoxServer.Location = new Point(57, 6);
            textBoxServer.Name = "textBoxServer";
            textBoxServer.Size = new Size(190, 23);
            textBoxServer.TabIndex = 3;
            textBoxServer.Tag = "Server";
            textBoxServer.TextChanged += WriteChangeToConfigFile;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(495, 9);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(60, 15);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Password:";
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Location = new Point(253, 9);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(40, 15);
            labelLogin.TabIndex = 1;
            labelLogin.Text = "Login:";
            // 
            // labelServer
            // 
            labelServer.AutoSize = true;
            labelServer.Location = new Point(12, 9);
            labelServer.Name = "labelServer";
            labelServer.Size = new Size(42, 15);
            labelServer.TabIndex = 0;
            labelServer.Text = "Server:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 539);
            Controls.Add(panel1);
            Controls.Add(labelMessage);
            Controls.Add(textBoxMessage);
            Controls.Add(textBoxQueue);
            Controls.Add(labelQueue);
            Controls.Add(textBoxExchange);
            Controls.Add(labelExchange);
            Controls.Add(textBoxRoutingKey);
            Controls.Add(labelRoutingKey);
            Controls.Add(buttonSend);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Label labelMessage;
        private Panel panel1;
        private TextBox textBoxPassword;
        private TextBox textBoxLogin;
        private TextBox textBoxServer;
        private Label labelPassword;
        private Label labelLogin;
        private Label labelServer;
    }
}
