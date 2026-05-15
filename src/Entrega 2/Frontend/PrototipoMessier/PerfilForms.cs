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
    public partial class PerfilForms : Form
    {
        public PerfilForms()
        {
            InitializeComponent();
        }

        private void btnEscola_Click(object sender, EventArgs e)
        {
            new LoginEscolaForms().Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            new LoginAdminForms().Show();
            this.Hide();
        }
    }
}
