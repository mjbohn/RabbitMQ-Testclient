namespace RabbitMQClient
{
    partial class FormVersionInfo
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
            labelGitTag = new Label();
            labelCommit = new Label();
            buttonClose = new Button();
            SuspendLayout();
            // 
            // labelGitTag
            // 
            labelGitTag.AutoSize = true;
            labelGitTag.Location = new Point(24, 13);
            labelGitTag.Name = "labelGitTag";
            labelGitTag.Size = new Size(65, 15);
            labelGitTag.TabIndex = 0;
            labelGitTag.Text = "labelGitTag";
            // 
            // labelCommit
            // 
            labelCommit.AutoSize = true;
            labelCommit.Location = new Point(24, 37);
            labelCommit.Name = "labelCommit";
            labelCommit.Size = new Size(76, 15);
            labelCommit.TabIndex = 1;
            labelCommit.Text = "labelCommit";
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(126, 78);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 2;
            buttonClose.Text = "close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // FormVersionInfo
            // 
            AcceptButton = buttonClose;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(327, 127);
            Controls.Add(buttonClose);
            Controls.Add(labelCommit);
            Controls.Add(labelGitTag);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormVersionInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Version Info";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelGitTag;
        private Label labelCommit;
        private Button buttonClose;
    }
}