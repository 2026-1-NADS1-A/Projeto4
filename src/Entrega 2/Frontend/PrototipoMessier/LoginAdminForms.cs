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
    public partial class LoginAdminForms : Form
    {
        public LoginAdminForms()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" && txtSenha.Text == "1234")
            {
                new Form1().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
