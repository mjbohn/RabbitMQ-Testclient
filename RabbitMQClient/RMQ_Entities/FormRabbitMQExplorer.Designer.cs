namespace RabbitMQClient.RMQ_Entities
{
    partial class FormRabbitMQExplorer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRabbitMQExplorer));
            panelTop = new Panel();
            statusStrip1 = new StatusStrip();
            treeViewRMQ = new TreeView();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(766, 42);
            panelTop.TabIndex = 1;
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 422);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(766, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // treeViewRMQ
            // 
            treeViewRMQ.Dock = DockStyle.Left;
            treeViewRMQ.Location = new Point(0, 42);
            treeViewRMQ.Name = "treeViewRMQ";
            treeViewRMQ.Size = new Size(174, 380);
            treeViewRMQ.TabIndex = 3;
            treeViewRMQ.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Left;
            richTextBox1.Location = new Point(174, 42);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(240, 380);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // FormRabbitMQExplorer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 444);
            Controls.Add(richTextBox1);
            Controls.Add(treeViewRMQ);
            Controls.Add(statusStrip1);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormRabbitMQExplorer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RabbitMQ Explorer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTop;
        private StatusStrip statusStrip1;
        private TreeView treeViewRMQ;
        private RichTextBox richTextBox1;
    }
}