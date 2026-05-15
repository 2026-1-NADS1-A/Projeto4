namespace PrototipoMessier
{
    public partial class Form1 : Form
    {
        JogosForms frmJogos;
        PacoteForms frmPacotes;
        HelpForms frmHelp;
        RelEscolas frmRelEscolas;

        public Form1()
        {
            InitializeComponent();
            frmJogos = new JogosForms();
            frmPacotes = new PacoteForms();
            frmHelp = new HelpForms();
            frmRelEscolas = new RelEscolas();
        }

        private void jogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmJogos.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pacotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPacotes.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelp.ShowDialog();
        }




        private void EscolaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelEscolas.ShowDialog();
        }

        private void escolaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmRelEscolas.ShowDialog();
        }
    }
}
