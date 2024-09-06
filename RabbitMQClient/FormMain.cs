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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            LabelVersionInfo.Text = $"{ThisAssembly.Git.SemVer.Major}.{ThisAssembly.Git.SemVer.Minor}.{ThisAssembly.Git.SemVer.Patch}.{ThisAssembly.Git.SemVer.DashLabel}";
        }

        private void buttonCreateProducer_Click(object sender, EventArgs e)
        {
            FormProducer? ProducerForm = new FormProducer();
            ProducerForm.Parent = null;
            ProducerForm.Show();
        }

        private void buttonCreateConsumer_Click(object sender, EventArgs e)
        {
            FormConsumer? ConsumerForm = new FormConsumer();
            ConsumerForm.Show();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool formProducerExists = Application.OpenForms.OfType<FormProducer>().Any();
            bool formConsumerExists = Application.OpenForms.OfType<FormConsumer>().Any();

            if (formProducerExists || formConsumerExists)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to close? All Producer and Consumer forms will be closed",
                        "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dr != DialogResult.OK)
                {
                    e.Cancel = true;
                }
            }

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LabelVersionInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormVersionInfo formVersionInfo = new FormVersionInfo();
            formVersionInfo.Show();
        }
    }
}
