namespace RabbitMQClient
{
    partial class Form1
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
            buttonSend = new Button();
            labelRoutingKey = new Label();
            textBoxRoutingKey = new TextBox();
            textBoxExchange = new TextBox();
            labelExchange = new Label();
            textBoxQueue = new TextBox();
            labelQueue = new Label();
            textBoxMessage = new TextBox();
            labelMessage = new Label();
            SuspendLayout();
            // 
            // buttonSend
            // 
            buttonSend.Location = new Point(219, 205);
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
            labelRoutingKey.Location = new Point(11, 58);
            labelRoutingKey.Name = "labelRoutingKey";
            labelRoutingKey.Size = new Size(74, 15);
            labelRoutingKey.TabIndex = 1;
            labelRoutingKey.Text = "Routing Key:";
            // 
            // textBoxRoutingKey
            // 
            textBoxRoutingKey.Location = new Point(91, 55);
            textBoxRoutingKey.Name = "textBoxRoutingKey";
            textBoxRoutingKey.Size = new Size(203, 23);
            textBoxRoutingKey.TabIndex = 2;
            // 
            // textBoxExchange
            // 
            textBoxExchange.Location = new Point(91, 84);
            textBoxExchange.Name = "textBoxExchange";
            textBoxExchange.Size = new Size(203, 23);
            textBoxExchange.TabIndex = 4;
            // 
            // labelExchange
            // 
            labelExchange.AutoSize = true;
            labelExchange.Location = new Point(11, 87);
            labelExchange.Name = "labelExchange";
            labelExchange.Size = new Size(61, 15);
            labelExchange.TabIndex = 3;
            labelExchange.Text = "Exchange:";
            // 
            // textBoxQueue
            // 
            textBoxQueue.Location = new Point(91, 12);
            textBoxQueue.Name = "textBoxQueue";
            textBoxQueue.Size = new Size(203, 23);
            textBoxQueue.TabIndex = 6;
            // 
            // labelQueue
            // 
            labelQueue.AutoSize = true;
            labelQueue.Location = new Point(11, 15);
            labelQueue.Name = "labelQueue";
            labelQueue.Size = new Size(45, 15);
            labelQueue.TabIndex = 5;
            labelQueue.Text = "Queue:";
            // 
            // textBoxMessage
            // 
            textBoxMessage.Location = new Point(91, 133);
            textBoxMessage.Multiline = true;
            textBoxMessage.Name = "textBoxMessage";
            textBoxMessage.Size = new Size(203, 53);
            textBoxMessage.TabIndex = 7;
            textBoxMessage.Text = "Hello World!";
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Location = new Point(11, 136);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(56, 15);
            labelMessage.TabIndex = 8;
            labelMessage.Text = "Message:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelMessage);
            Controls.Add(textBoxMessage);
            Controls.Add(textBoxQueue);
            Controls.Add(labelQueue);
            Controls.Add(textBoxExchange);
            Controls.Add(labelExchange);
            Controls.Add(textBoxRoutingKey);
            Controls.Add(labelRoutingKey);
            Controls.Add(buttonSend);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += Form1_FormClosing;
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
    }
}
