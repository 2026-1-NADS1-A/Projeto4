using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace SchoolPlayManager.Forms
{
    public partial class AccessSimulationForm : Form
    {
        public AccessSimulationForm()
        {
            InitializeComponent();

            // Optional: trigger the verification once the form components are initialized
            // (original code called the handler with null parameters at file scope)
            btnVerificarAcesso_Click(null, null);

            // Centraliza os controles horizontalmente em relação ao botão
            int centroX = btnVerificarAcesso.Left + btnVerificarAcesso.Width / 2;
            lblStatus.Left = centroX - lblStatus.Width / 2;

            txtIpOrigem.Width = btnVerificarAcesso.Width;
            txtIpOrigem.Left = centroX - txtIpOrigem.Width / 2;

            // Label com largura maior para o texto caber
            lblStatus.AutoSize = true;
            lblStatus.Width = 250; // ajuste esse valor se precisar
            lblStatus.Left = centroX - lblStatus.Width / 2;
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;

            teste.Width = btnVerificarAcesso.Width;
            teste.Left = centroX - teste.Width / 2;

            btnVerificarAcesso_Click(null, null);

        }

        private void btnVerificarAcesso_Click(object sender, EventArgs e)
        {
            string ipDigitado = txtIpOrigem.Text.Trim(); // .Trim() tira os espaços em branco que o usuário digitar sem querer

            // 1. VALIDAÇÃO DE FORMATO IPv4
            // Tenta converter o texto para um IP. Se conseguir, e a família do IP for InterNetwork (que significa IPv4)...
            if (!IPAddress.TryParse(ipDigitado, out IPAddress ipFormatado) || ipFormatado.AddressFamily != AddressFamily.InterNetwork)
            {
                // Se falhar, avisa o usuário e para a execução por aqui (return)
                lblStatus.Text = "Formato de IP Inválido!";
                lblStatus.ForeColor = Color.LightGray;
                return;
            }

            // 2. REGRA DE NEGÓCIO (Se chegou aqui, o IP é um IPv4 válido)
            // Precisamos instanciar sua classe que está na camada Business
            SchoolPlayManager.Business.Validators.IPValidator validador = new SchoolPlayManager.Business.Validators.IPValidator();

            bool isAutorizado = validador.ValidarAcesso(ipDigitado);

            // 3. ATUALIZAÇÃO DA TELA
            if (isAutorizado)
            {
                lblStatus.Text = "Acesso Autorizado";
                lblStatus.ForeColor = Color.Green;
            }
            else
            {
                lblStatus.Text = "Acesso Bloqueado";
                lblStatus.ForeColor = Color.Red;
            }

            // 4. REGISTRO VISUAL DO LOG
            string statusLog = isAutorizado ? "Permitido" : "Bloqueado";
            string logMsg = $"{DateTime.Now:HH:mm:ss} | IP: {ipDigitado} | Status: {statusLog}";
            teste.Items.Insert(0, logMsg); // Insert(0, ...) coloca o log mais recente no topo da lista

            // 1. Atualiza as cores e o texto da Label na UI
            lblStatus.Text = isAutorizado ? "Acesso Autorizado" : "Acesso Bloqueado";
            lblStatus.ForeColor = isAutorizado ? Color.Green : Color.Red;

            // 2. Monta o objeto de Log
            SchoolPlayManager.Business.Models.AccessLog novoLog = new SchoolPlayManager.Business.Models.AccessLog
            {
                DataHora = DateTime.Now,
                IpOrigem = ipDigitado,
                AcessoPermitido = isAutorizado
            };

            // 3. Salva o Log fisicamente chamando a camada de Dados
            SchoolPlayManager.Data.Repositories.AccessLogRepository repositorioLog = new SchoolPlayManager.Data.Repositories.AccessLogRepository();
            repositorioLog.RegistrarLog(novoLog);

            // 4. Continua mostrando na tela (ListBox) para feedback visual rápido
            string logMsgVisual = $"{DateTime.Now:HH:mm:ss} | IP: {ipDigitado} | Status: {statusLog}";
        }

        private void txtIpOrigem_TextChanged(object sender, EventArgs e)
        {
            // Intentionally left blank: the designer wired this event, but no runtime action required.
            // If desired, you can call validation or enable/disable controls here.
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {
            // No-op click handler to satisfy designer event wiring.
        }
    }
}