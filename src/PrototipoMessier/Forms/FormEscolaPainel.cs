using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using PrototipoMessier.Models;

namespace PrototipoMessier.Forms
{
    public partial class FormEscolaPainel : Form
    {
        private Escola _escola;

        public FormEscolaPainel(Escola escola)
        {
            _escola = escola;
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            lstJogos.Items.Clear();
            foreach (var jogo in _escola.PacoteAdquirido.Games)
            {
                lstJogos.Items.Add(jogo);
            }

            int limite = _escola.PacoteAdquirido.LimiteAcessosMensal;
            int atual = _escola.ConsumoAtual;
            int percent = (int)((double)atual / (limite == 0 ? 1 : limite) * 100);

            prgConsumo.Maximum = limite;
            prgConsumo.Value = Math.Min(atual, limite);
            lblPercentual.Text = percent + "%";
            lblLimiteInfo.Text = "Consumo: " + atual + " / " + limite + " acessos";
            lblEscolaNome.Text = "Bem-vindo, " + _escola.Nome;
            lblPacoteInfo.Text = "Pacote Atual: " + _escola.PacoteAdquirido.Nome;
        }

        private void lstJogos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var jogo = (Game)lstJogos.SelectedItem;
            if (jogo != null)
            {
                string path = Path.Combine(Application.StartupPath, "Resources", jogo.ImagemCaminho);
                if (File.Exists(path))
                {
                    picJogo.Image = Image.FromFile(path);
                }
                else
                {
                    picJogo.Image = null;
                    picJogo.BackColor = Color.FromArgb(46, 139, 87);
                }
            }
        }

        private void btnSimularAcesso_Click(object sender, EventArgs e)
        {
            if (_escola.ConsumoAtual >= _escola.PacoteAdquirido.LimiteAcessosMensal)
            {
                MessageBox.Show("Limite de acessos mensal atingido! Entre em contato para upgrade de pacote.", "Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (lstJogos.SelectedItem == null)
            {
                MessageBox.Show("Selecione um jogo para simular o acesso.", "Aviso");
                return;
            }

            _escola.ConsumoAtual++;
            MessageBox.Show("Acesso ao jogo '" + lstJogos.SelectedItem + "' registrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            new FormLoginInicial().Show();
            this.Close();
        }
    }
}
