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
    public partial class PacoteForms : Form
    {
        public PacoteForms()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            grdPacotes.Rows.Add(txtID.Text, txtNome.Text);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtID.Text = "";
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
            }

        }
    }
}
