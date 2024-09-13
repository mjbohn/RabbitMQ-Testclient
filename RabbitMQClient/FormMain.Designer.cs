namespace RabbitMQClient
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonCreatePublisher = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            buttonCreateConsumer = new Button();
            LabelVersionInfo = new LinkLabel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonCreatePublisher
            // 
            buttonCreatePublisher.Location = new Point(12, 27);
            buttonCreatePublisher.Name = "buttonCreatePublisher";
            buttonCreatePublisher.Size = new Size(120, 23);
            buttonCreatePublisher.TabIndex = 0;
            buttonCreatePublisher.Text = "Create Publisher";
            buttonCreatePublisher.UseVisualStyleBackColor = true;
            buttonCreatePublisher.Click += buttonCreatePublisher_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(275, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { closeToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(101, 22);
            closeToolStripMenuItem.Text = "close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // buttonCreateConsumer
            // 
            buttonCreateConsumer.Location = new Point(138, 27);
            buttonCreateConsumer.Name = "buttonCreateConsumer";
            buttonCreateConsumer.Size = new Size(120, 23);
            buttonCreateConsumer.TabIndex = 2;
            buttonCreateConsumer.Text = "Create Consumer";
            buttonCreateConsumer.UseVisualStyleBackColor = true;
            buttonCreateConsumer.Click += buttonCreateConsumer_Click;
            // 
            // LabelVersionInfo
            // 
            LabelVersionInfo.AutoSize = true;
            LabelVersionInfo.Font = new Font("Segoe UI", 8F);
            LabelVersionInfo.Location = new Point(12, 64);
            LabelVersionInfo.Name = "LabelVersionInfo";
            LabelVersionInfo.Size = new Size(66, 13);
            LabelVersionInfo.TabIndex = 3;
            LabelVersionInfo.TabStop = true;
            LabelVersionInfo.Text = "VersionInfo";
            LabelVersionInfo.LinkClicked += LabelVersionInfo_LinkClicked;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 92);
            Controls.Add(LabelVersionInfo);
            Controls.Add(buttonCreateConsumer);
            Controls.Add(buttonCreatePublisher);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RabbitMQ Testclient";
            FormClosing += FormMain_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCreatePublisher;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private Button buttonCreateConsumer;
        private LinkLabel LabelVersionInfo;
    }
}