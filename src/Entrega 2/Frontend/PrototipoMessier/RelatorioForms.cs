using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoMessier
{
    public partial class RelEscolas : Form
    {
        public RelEscolas()
        {
            InitializeComponent();
        }

        private void txtRelatorios_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            txtRelatorios.Text = "| ESCOLA            | PACOTE \r\n";
            for (int i = 1; i <= 10; i++)
            {
                txtRelatorios.Text += "| ESCOLA " + 1 + "         |" + 1 + "\r\n";
            }
        }
    }
}