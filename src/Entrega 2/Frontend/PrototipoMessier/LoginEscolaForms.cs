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
using System.Net;
using System.IO;

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

            string escolaSelecionada = cmbEscola.Text; //Aqui já captura o IP da máquina local

            //Validar IP
            if (!IPAutorizadoParaEscola(escolaSelecionada))
            {
                MessageBox.Show(
                $"Acesso Negado. \n IP detectado: {ObterIpLocal()}\n Este IP não está autorizado",
                 "Acesso Bloqueado",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error
                    );
                return;
            }
        }

        private bool IPAutorizadoParaEscola(string escola)
        {
            // Pega o IP real da máquina
            string ipAtual = ObterIpLocal();

            // Busca os IPs autorizados para essa escola (do banco futuramente)
            var ipsAutorizados = ObterIPsDaEscola(escola);

            // Retorna true se o IP da máquina estiver na lista, false se não estiver
            return ipsAutorizados.Contains(ipAtual);
        }

        private List<string> ObterIPsDaEscola(string escola)
        {
            // Dicionário: cada escola tem sua lista de IPs autorizados
            var ipsAutorizados = new Dictionary<string, List<string>>
    {
        { "E.E. João da Silva",    new List<string> { "192.168.0.1", "10.0.0.5" } },
        { "E.E. Maria Aparecida", new List<string> { "192.168.1.10" } }
    };

            // Tenta buscar os IPs da escola selecionada
            // Se a escola não existir no dicionário, retorna lista vazia (bloqueado)
            if (ipsAutorizados.ContainsKey(escola))
                return ipsAutorizados[escola];

            return new List<string>();
        }

        private void LoginEscolaForms_Load(object sender, EventArgs e)
        {

            btnEntrar.ForeColor = Color.FromArgb(34, 85, 34);
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            new PerfilForms ().Show();
            this.Close();
        }
    }
}
