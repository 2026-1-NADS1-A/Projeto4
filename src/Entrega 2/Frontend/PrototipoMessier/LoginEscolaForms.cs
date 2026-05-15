using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace PrototipoMessier
{
    public partial class LoginEscolaForms : Form
    {
        public LoginEscolaForms()
        {
            InitializeComponent();
        }

        private string ObterIpLocal()
        {
            var Host = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName());

            foreach (var ip in Host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return string.Empty;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string ipAtual = ObterIpLocal();

            string escolaSelecionada = cmbEscola.Text;

            //Validar IP
            var IpsAutorizados = ObterIpsdaEscola(escolaSelecionada);

            if (!IpsAutorizados.Contains(ipAtual))
            {
                //IP não autorizado
                MessageBox.Show($"Acesso Negado.\n IP Detectado: {ipAtual}\n Este IP não está autorizado para sua Escola",
                    "Acesso Bloqueado", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
