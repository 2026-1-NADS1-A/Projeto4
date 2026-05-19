using System;
using System.Linq;
using System.Windows.Forms;
using PrototipoMessier.Models;
using PrototipoMessier.Services;

namespace PrototipoMessier.Forms
{
    public partial class FormCadastroPacotes : Form
    {
        public FormCadastroPacotes()
        {
            InitializeComponent();
            AtualizarGrid();
            CarregarCheckList();
        }

        private void CarregarCheckList()
        {
            clbJogos.Items.Clear();
            foreach (var jogo in DataService.Games)
            {
                clbJogos.Items.Add(jogo);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text)) return;
            
            var novo = new Pacote {
                Id = DataService.Pacotes.Count + 1,
                Nome = txtNome.Text,
                LimiteAcessosMensal = int.TryParse(txtLimite.Text, out int l) ? l : 0,
                PrecoMensal = decimal.TryParse(txtPreco.Text, out decimal p) ? p : 0
            };

            foreach (var item in clbJogos.CheckedItems)
            {
                novo.Games.Add((Game)item);
            }

            DataService.Pacotes.Add(novo);
            AtualizarGrid();
            MessageBox.Show("Pacote salvo com sucesso!");
        }

        private void AtualizarGrid()
        {
            dgvPacotes.DataSource = null;
            dgvPacotes.DataSource = DataService.Pacotes.Select(p => new { p.Id, p.Nome, p.LimiteAcessosMensal, p.PrecoMensal, QtdJogos = p.Games.Count }).ToList();
        }
    }
}
