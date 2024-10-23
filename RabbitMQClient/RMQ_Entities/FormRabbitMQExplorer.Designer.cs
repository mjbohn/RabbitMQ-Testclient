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
            splitContainerData = new SplitContainer();
            splitContainerTree = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)splitContainerData).BeginInit();
            splitContainerData.Panel1.SuspendLayout();
            splitContainerData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerTree).BeginInit();
            splitContainerTree.Panel1.SuspendLayout();
            splitContainerTree.Panel2.SuspendLayout();
            splitContainerTree.SuspendLayout();
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
            treeViewRMQ.Dock = DockStyle.Fill;
            treeViewRMQ.Location = new Point(0, 0);
            treeViewRMQ.Name = "treeViewRMQ";
            treeViewRMQ.Size = new Size(255, 450);
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
            scintilla.Size = new Size(414, 450);
            scintilla.TabIndex = 5;
            scintilla.TextChanged += scintilla_TextChanged;
            // 
            // splitContainerData
            // 
            splitContainerData.Dock = DockStyle.Fill;
            splitContainerData.Location = new Point(0, 0);
            splitContainerData.Name = "splitContainerData";
            // 
            // splitContainerData.Panel1
            // 
            splitContainerData.Panel1.Controls.Add(scintilla);
            splitContainerData.Size = new Size(715, 450);
            splitContainerData.SplitterDistance = 414;
            splitContainerData.TabIndex = 6;
            // 
            // splitContainerTree
            // 
            splitContainerTree.BorderStyle = BorderStyle.FixedSingle;
            splitContainerTree.Dock = DockStyle.Fill;
            splitContainerTree.Location = new Point(0, 42);
            splitContainerTree.Name = "splitContainerTree";
            // 
            // splitContainerTree.Panel1
            // 
            splitContainerTree.Panel1.Controls.Add(treeViewRMQ);
            // 
            // splitContainerTree.Panel2
            // 
            splitContainerTree.Panel2.Controls.Add(splitContainerData);
            splitContainerTree.Size = new Size(978, 452);
            splitContainerTree.SplitterDistance = 257;
            splitContainerTree.TabIndex = 7;
            // 
            // FormRabbitMQExplorer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 516);
            Controls.Add(splitContainerTree);
            Controls.Add(statusStrip1);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormRabbitMQExplorer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RabbitMQ Explorer";
            splitContainerData.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerData).EndInit();
            splitContainerData.ResumeLayout(false);
            splitContainerTree.Panel1.ResumeLayout(false);
            splitContainerTree.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerTree).EndInit();
            splitContainerTree.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTop;
        private StatusStrip statusStrip1;
        private TreeView treeViewRMQ;
        private ScintillaNET.Scintilla scintilla;
        private SplitContainer splitContainerData;
        private SplitContainer splitContainerTree;
    }
}