using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RabbitMQClient
{
    public partial class FormVersionInfo : Form
    {
        public FormVersionInfo()
        {
            InitializeComponent();
            SetLabels();
        }

        private void SetLabels()
        {
            labelGitTag.Text = $"Version: {ThisAssembly.Git.Tag}";
            labelCommitDate.Text = $"Date : {ThisAssembly.Git.CommitDate}";
            labelBranch.Text = $"{ThisAssembly.Git.Branch}";
            labelCommit.Text = $"{ThisAssembly.Git.Commit}";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
