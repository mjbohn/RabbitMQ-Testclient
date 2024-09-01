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
            buttonStop = new Button();
            buttonStart = new Button();
            rtbReceivedMessages = new RichTextBox();
            checkBoxAddLF = new CheckBox();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
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
            panel1.Location = new Point(0, 0);
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
            textBoxClientName.TabIndex = 9;
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
            textBoxQueue.TabIndex = 7;
            textBoxQueue.Tag = "";
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
            textBoxPassword.TabIndex = 5;
            textBoxPassword.Tag = "";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(299, 6);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.PlaceholderText = "User Name";
            textBoxLogin.Size = new Size(190, 23);
            textBoxLogin.TabIndex = 4;
            textBoxLogin.Tag = "";
            // 
            // textBoxServer
            // 
            textBoxServer.Location = new Point(57, 6);
            textBoxServer.Name = "textBoxServer";
            textBoxServer.PlaceholderText = "RabbitMQ Server";
            textBoxServer.Size = new Size(190, 23);
            textBoxServer.TabIndex = 3;
            textBoxServer.Tag = "";
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
            panel2.Controls.Add(buttonStop);
            panel2.Controls.Add(buttonStart);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(1014, 37);
            panel2.TabIndex = 11;
            // 
            // buttonStop
            // 
            buttonStop.BackColor = Color.IndianRed;
            buttonStop.Enabled = false;
            buttonStop.Location = new Point(92, 7);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(75, 23);
            buttonStop.TabIndex = 1;
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
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += ButtonStart_Click;
            // 
            // rtbReceivedMessages
            // 
            rtbReceivedMessages.BackColor = Color.Wheat;
            rtbReceivedMessages.Dock = DockStyle.Fill;
            rtbReceivedMessages.Location = new Point(0, 105);
            rtbReceivedMessages.Name = "rtbReceivedMessages";
            rtbReceivedMessages.Size = new Size(1014, 436);
            rtbReceivedMessages.TabIndex = 12;
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
            checkBoxAddLF.Text = "add '\\n'";
            checkBoxAddLF.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(checkBoxAddLF);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 501);
            panel3.Name = "panel3";
            panel3.Size = new Size(1014, 40);
            panel3.TabIndex = 13;
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormConsumer";
            Text = "Consumer";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
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
    }
}