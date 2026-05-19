using System;
using System.Windows.Forms;

namespace PrototipoMessier.Forms
{
    public partial class FormHelp : Form
    {
        public FormHelp()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtHelp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
