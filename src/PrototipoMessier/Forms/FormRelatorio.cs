using System;
using System.Linq;
using System.Windows.Forms;
using PrototipoMessier.Services;

namespace PrototipoMessier.Forms
{
    public partial class FormRelatorio : Form
    {
        public FormRelatorio()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dgvRelatorio.DataSource = null;
            dgvRelatorio.DataSource = DataService.Escolas.Select(e => new {
                e.Nome,
                Pacote = e.PacoteAdquirido.Nome,
                e.ConsumoAtual,
                Limite = e.PacoteAdquirido.LimiteAcessosMensal,
                Status = e.ConsumoAtual >= e.PacoteAdquirido.LimiteAcessosMensal ? "Bloqueado" : "Ativo"
            }).ToList();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
