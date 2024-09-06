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
            labelCommit.Text = $"Commit : {ThisAssembly.Git.CommitDate} {ThisAssembly.Git.Branch} {ThisAssembly.Git.Commit}";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
