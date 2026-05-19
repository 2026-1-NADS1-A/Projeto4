using System;
using System.Windows.Forms;

namespace PrototipoMessier.Forms
{
    public partial class FormLoginInicial : Form
    {
        public FormLoginInicial()
        {
            InitializeComponent();
        }

        private void btnEscola_Click(object sender, EventArgs e)
        {
            new FormLoginEscola().Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            new FormLoginAdmin().Show();
            this.Hide();
        }
    }
}
