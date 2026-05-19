using System;
using System.Windows.Forms;
using PrototipoMessier.Services;

namespace PrototipoMessier.Forms
{
    public partial class FormAdminPrincipal : Form
    {
        public FormAdminPrincipal()
        {
            InitializeComponent();
            UpdateStats();
        }

        private void UpdateStats()
        {
            lblCard1Value.Text = DataService.Games.Count.ToString();
            lblCard2Value.Text = DataService.Pacotes.Count.ToString();
        }

        private void jogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormCadastroJogos().ShowDialog();
            UpdateStats();
        }

        private void pacotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormCadastroPacotes().ShowDialog();
            UpdateStats();
        }

        private void relatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormRelatorio().ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormHelp().ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
