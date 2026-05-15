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
            // Lê todas as linhas do arquivo
            var linhas = File.ReadAllLines("ips.txt");

            foreach (var linha in linhas)
            {
                // Cada linha é: NomeDaEscola|ip1|ip2|ip3...
                var partes = linha.Split('|');

                // partes[0] = nome da escola, partes[1..] = IPs
                if (partes[0] == escola)
                {
                    // Pega tudo depois do nome (os IPs) e retorna como lista
                    return partes.Skip(1).ToList();
                }
            }

            return new List<string>(); // escola não encontrada
        }
    }
}
