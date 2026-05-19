using System;
using System.Linq;
using System.Windows.Forms;
using PrototipoMessier.Services;
using PrototipoMessier.Models;

namespace PrototipoMessier.Forms
{
    public partial class FormLoginEscola : Form
    {
        public FormLoginEscola()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string nome = txtEscolaNome.Text.Trim();
            string senha = txtSenha.Text.Trim();

            if (!string.IsNullOrEmpty(nome) && nome == senha)
            {
                var escolaDinamica = new Escola
                {
                    Nome = nome,
                    Senha = senha,
                    PacoteAdquirido = DataService.Pacotes.FirstOrDefault() ?? new Pacote { Nome = "Pacote Padrão", LimiteAcessosMensal = 100 },
                    ConsumoAtual = 0
                };

                new FormEscolaPainel(escolaDinamica).Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("A senha deve ser idêntica ao nome da instituição!", "Erro de Acesso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            new FormLoginInicial().Show();
            this.Close();
        }
    }
}
