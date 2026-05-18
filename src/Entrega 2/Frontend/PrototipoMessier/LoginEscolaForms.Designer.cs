namespace PrototipoMessier
{
    partial class LoginEscolaForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginEscolaForms));
            btnEntrar = new Button();
            cmbEscola = new ComboBox();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            lblCmb = new Label();
            lblPwd = new Label();
            lblBack = new Label();
            txtPwd = new TextBox();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.White;
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.FromArgb(34, 85, 34);
            btnEntrar.Location = new Point(431, 424);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // cmbEscola
            // 
            cmbEscola.FlatStyle = FlatStyle.Flat;
            cmbEscola.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbEscola.FormattingEnabled = true;
            cmbEscola.Location = new Point(420, 276);
            cmbEscola.Name = "cmbEscola";
            cmbEscola.Size = new Size(121, 25);
            cmbEscola.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(395, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(206, 32);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Acesso da Escola";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.BackColor = Color.Transparent;
            lblSubtitulo.Location = new Point(420, 207);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(136, 15);
            lblSubtitulo.TabIndex = 3;
            lblSubtitulo.Text = "Selecione sua instituição";
            // 
            // lblCmb
            // 
            lblCmb.AutoSize = true;
            lblCmb.BackColor = Color.Transparent;
            lblCmb.Location = new Point(420, 258);
            lblCmb.Name = "lblCmb";
            lblCmb.Size = new Size(40, 15);
            lblCmb.TabIndex = 4;
            lblCmb.Text = "Escola";
            // 
            // lblPwd
            // 
            lblPwd.AutoSize = true;
            lblPwd.BackColor = Color.Transparent;
            lblPwd.Location = new Point(421, 336);
            lblPwd.Name = "lblPwd";
            lblPwd.Size = new Size(39, 15);
            lblPwd.TabIndex = 5;
            lblPwd.Text = "Senha";
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.BackColor = Color.Transparent;
            lblBack.Cursor = Cursors.Hand;
            lblBack.FlatStyle = FlatStyle.Flat;
            lblBack.ForeColor = Color.White;
            lblBack.Location = new Point(12, 743);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(50, 15);
            lblBack.TabIndex = 6;
            lblBack.Text = "← Voltar";
            lblBack.Click += lblBack_Click;
            // 
            // txtPwd
            // 
            txtPwd.BackColor = Color.White;
            txtPwd.BorderStyle = BorderStyle.FixedSingle;
            txtPwd.Font = new Font("Segoe UI", 10F);
            txtPwd.Location = new Point(420, 354);
            txtPwd.Name = "txtPwd";
            txtPwd.PasswordChar = '*';
            txtPwd.Size = new Size(100, 25);
            txtPwd.TabIndex = 7;
            // 
            // LoginEscolaForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(998, 767);
            Controls.Add(txtPwd);
            Controls.Add(lblBack);
            Controls.Add(lblPwd);
            Controls.Add(lblCmb);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblTitulo);
            Controls.Add(cmbEscola);
            Controls.Add(btnEntrar);
            ForeColor = Color.White;
            Name = "LoginEscolaForms";
            Text = "Messier - Login Escola";
            Load += LoginEscolaForms_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEntrar;
        private ComboBox cmbEscola;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblCmb;
        private Label lblPwd;
        private Label lblBack;
        private TextBox txtPwd;
    }
}