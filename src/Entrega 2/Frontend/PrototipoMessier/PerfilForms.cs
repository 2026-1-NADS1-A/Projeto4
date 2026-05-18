using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoMessier
{
    public partial class PerfilForms : Form
    {
        public PerfilForms()
        {
            InitializeComponent();
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PerfilForms_Paint);
        }

        private void btnEscola_Click(object sender, EventArgs e)
        {
            new LoginEscolaForms().Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            new LoginAdminForms().Show();
            this.Hide();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            // Depois coloca o degradê por cima com transparência (último número = opacidade 0-255)
            // 120 = semi-transparente, deixa a imagem aparecer por baixo
            using (var brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                this.ClientRectangle,
                System.Drawing.Color.FromArgb(120, 34, 85, 34), // verde com transparência
                System.Drawing.Color.FromArgb(0, 255, 255, 255), // transparente na direita
                System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }



        private void PerfilForms_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PerfilForms_Load(object sender, EventArgs e)
        {
            // Intentionally left blank. Designer wires this event; no runtime initialization required here.


        }
    }
}

