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
            labelCommitDate = new Label();
            buttonClose = new Button();
            labelBranch = new Label();
            labelCommit = new Label();
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
            // labelCommitDate
            // 
            labelCommitDate.AutoSize = true;
            labelCommitDate.Location = new Point(24, 47);
            labelCommitDate.Name = "labelCommitDate";
            labelCommitDate.Size = new Size(100, 15);
            labelCommitDate.TabIndex = 1;
            labelCommitDate.Text = "labelCommitDate";
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(142, 153);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 2;
            buttonClose.Text = "close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // labelBranch
            // 
            labelBranch.AutoSize = true;
            labelBranch.Location = new Point(24, 81);
            labelBranch.Name = "labelBranch";
            labelBranch.Size = new Size(69, 15);
            labelBranch.TabIndex = 3;
            labelBranch.Text = "labelBranch";
            // 
            // labelCommit
            // 
            labelCommit.AutoSize = true;
            labelCommit.Location = new Point(24, 115);
            labelCommit.Name = "labelCommit";
            labelCommit.Size = new Size(76, 15);
            labelCommit.TabIndex = 4;
            labelCommit.Text = "labelCommit";
            // 
            // FormVersionInfo
            // 
            AcceptButton = buttonClose;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(358, 197);
            Controls.Add(labelCommit);
            Controls.Add(labelBranch);
            Controls.Add(buttonClose);
            Controls.Add(labelCommitDate);
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
        private Label labelCommitDate;
        private Button buttonClose;
        private Label labelBranch;
        private Label labelCommit;
    }
}