using SchoolPlayManager.core.Data;

namespace SchoolPlayManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var db = new Database();
            db.Initialize();

            MessageBox.Show("Banco criado com sucesso");
        }

    }
}
