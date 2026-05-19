using System;
using System.Windows.Forms;
using PrototipoMessier.Services;
using PrototipoMessier.Models;

namespace PrototipoMessier.Forms
{
    public partial class FormCadastroJogos : Form
    {
        public FormCadastroJogos()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dgvJogos.DataSource = null;
            dgvJogos.DataSource = DataService.Games;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtDescricao.Clear();
            chkAtivo.Checked = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Nome do jogo é obrigatório!");
                return;
            }

            var novoJogo = new Game
            {
                Id = DataService.Games.Count + 1,
                Nome = txtNome.Text,
                Descricao = txtDescricao.Text,
                Ativo = chkAtivo.Checked
            };

            DataService.Games.Add(novoJogo);
            MessageBox.Show("Jogo salvo com sucesso!");
            LoadData();
            btnNovo_Click(null, null);
        }
    }
}
