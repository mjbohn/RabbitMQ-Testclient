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
            scintilla = new ScintillaNET.Scintilla();
            splitContainer1 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(978, 42);
            panelTop.TabIndex = 1;
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 494);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(978, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // treeViewRMQ
            // 
            treeViewRMQ.Dock = DockStyle.Left;
            treeViewRMQ.Location = new Point(0, 42);
            treeViewRMQ.Name = "treeViewRMQ";
            treeViewRMQ.Size = new Size(174, 452);
            treeViewRMQ.TabIndex = 3;
            treeViewRMQ.TabStop = false;
            // 
            // scintilla
            // 
            scintilla.AutocompleteListSelectedBackColor = Color.FromArgb(0, 120, 215);
            scintilla.Dock = DockStyle.Fill;
            scintilla.Font = new Font("Verdana", 10F);
            scintilla.LexerName = null;
            scintilla.Location = new Point(0, 0);
            scintilla.Name = "scintilla";
            scintilla.ScrollWidth = 49;
            scintilla.Size = new Size(393, 452);
            scintilla.TabIndex = 5;
            scintilla.TextChanged += scintilla_TextChanged;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(174, 42);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(scintilla);
            splitContainer1.Size = new Size(804, 452);
            splitContainer1.SplitterDistance = 393;
            splitContainer1.TabIndex = 6;
            // 
            // FormRabbitMQExplorer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 516);
            Controls.Add(splitContainer1);
            Controls.Add(treeViewRMQ);
            Controls.Add(statusStrip1);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormRabbitMQExplorer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RabbitMQ Explorer";
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTop;
        private StatusStrip statusStrip1;
        private TreeView treeViewRMQ;
        private ScintillaNET.Scintilla scintilla;
        private SplitContainer splitContainer1;
    }
}