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
    public partial class JogosForms : Form
    {
        public JogosForms()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtNome.Text = "";
            txtDescricao.Text = "";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool Ativo = false;
            if (chkAtivo.Checked)
            {
                Ativo = true;
            }
            grdJogos.Rows.Add(txtID.Text, txtNome.Text,txtDescricao.Text, Ativo);
        }
    }
}
