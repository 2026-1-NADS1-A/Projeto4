namespace PrototipoMessier
{
    partial class PerfilForms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PerfilForms));
            btnEscola = new Button();
            btnAdmin = new Button();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            SuspendLayout();
            // 
            // btnEscola
            // 
            btnEscola.BackColor = Color.Transparent;
            btnEscola.Cursor = Cursors.Hand;
            btnEscola.FlatAppearance.BorderColor = Color.FromArgb(34, 85, 34);
            btnEscola.FlatStyle = FlatStyle.Flat;
            btnEscola.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEscola.ForeColor = Color.White;
            btnEscola.Location = new Point(453, 263);
            btnEscola.Name = "btnEscola";
            btnEscola.Size = new Size(160, 60);
            btnEscola.TabIndex = 0;
            btnEscola.Text = "🏫  Login Escola";
            btnEscola.UseVisualStyleBackColor = false;
            btnEscola.Click += btnEscola_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.Transparent;
            btnAdmin.Cursor = Cursors.Hand;
            btnAdmin.FlatAppearance.BorderColor = Color.FromArgb(34, 85, 34);
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.ForeColor = Color.White;
            btnAdmin.Location = new Point(453, 422);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(160, 60);
            btnAdmin.TabIndex = 1;
            btnAdmin.Text = "⚙️  Login Admin";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(432, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(219, 32);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Prototipo Messier";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.BackColor = Color.Transparent;
            lblSubtitulo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.White;
            lblSubtitulo.Location = new Point(453, 143);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(167, 17);
            lblSubtitulo.TabIndex = 3;
            lblSubtitulo.Text = "Selecione o tipo de acesso";
            // 
            // PerfilForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1078, 730);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblTitulo);
            Controls.Add(btnAdmin);
            Controls.Add(btnEscola);
            ForeColor = Color.White;
            Name = "PerfilForms";
            Text = "Login";
            Load += PerfilForms_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEscola;
        private Button btnAdmin;
        private Label lblTitulo;
        private Label lblSubtitulo;
    }
}