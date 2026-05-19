namespace PrototipoMessier.Forms
{
    partial class FormEscolaPainel
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblEscolaNome = new Label();
            lblPacoteInfo = new Label();
            lblLimiteInfo = new Label();
            lstJogos = new ListBox();
            lblJogosTitulo = new Label();
            btnSimularAcesso = new Button();
            prgConsumo = new ProgressBar();
            lblPercentual = new Label();
            btnSair = new Button();
            picJogo = new PictureBox();
            lblJogoSelecionado = new Label();
            ((System.ComponentModel.ISupportInitialize)picJogo).BeginInit();
            SuspendLayout();
            // 
            // lblEscolaNome
            // 
            lblEscolaNome.AutoSize = true;
            lblEscolaNome.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblEscolaNome.ForeColor = Color.FromArgb(46, 139, 87);
            lblEscolaNome.Location = new Point(20, 20);
            lblEscolaNome.Name = "lblEscolaNome";
            lblEscolaNome.Size = new Size(160, 32);
            lblEscolaNome.TabIndex = 0;
            lblEscolaNome.Text = "Bem-vindo...";
            // 
            // lblPacoteInfo
            // 
            lblPacoteInfo.AutoSize = true;
            lblPacoteInfo.Location = new Point(25, 70);
            lblPacoteInfo.Name = "lblPacoteInfo";
            lblPacoteInfo.Size = new Size(83, 15);
            lblPacoteInfo.TabIndex = 1;
            lblPacoteInfo.Text = "Pacote Atual...";
            // 
            // lblLimiteInfo
            // 
            lblLimiteInfo.AutoSize = true;
            lblLimiteInfo.Location = new Point(25, 100);
            lblLimiteInfo.Name = "lblLimiteInfo";
            lblLimiteInfo.Size = new Size(68, 15);
            lblLimiteInfo.TabIndex = 2;
            lblLimiteInfo.Text = "Consumo...";
            // 
            // lstJogos
            // 
            lstJogos.FormattingEnabled = true;
            lstJogos.ItemHeight = 15;
            lstJogos.Location = new Point(25, 210);
            lstJogos.Name = "lstJogos";
            lstJogos.Size = new Size(300, 154);
            lstJogos.TabIndex = 3;
            lstJogos.SelectedIndexChanged += lstJogos_SelectedIndexChanged;
            // 
            // lblJogosTitulo
            // 
            lblJogosTitulo.AutoSize = true;
            lblJogosTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblJogosTitulo.Location = new Point(25, 180);
            lblJogosTitulo.Name = "lblJogosTitulo";
            lblJogosTitulo.Size = new Size(190, 21);
            lblJogosTitulo.TabIndex = 4;
            lblJogosTitulo.Text = "Seus Jogos Disponíveis:";
            // 
            // btnSimularAcesso
            // 
            btnSimularAcesso.BackColor = Color.FromArgb(46, 139, 87);
            btnSimularAcesso.FlatStyle = FlatStyle.Flat;
            btnSimularAcesso.ForeColor = Color.White;
            btnSimularAcesso.Location = new Point(25, 380);
            btnSimularAcesso.Name = "btnSimularAcesso";
            btnSimularAcesso.Size = new Size(150, 40);
            btnSimularAcesso.TabIndex = 5;
            btnSimularAcesso.Text = "Simular Acesso";
            btnSimularAcesso.UseVisualStyleBackColor = false;
            btnSimularAcesso.Click += btnSimularAcesso_Click;
            // 
            // prgConsumo
            // 
            prgConsumo.Location = new Point(25, 130);
            prgConsumo.Name = "prgConsumo";
            prgConsumo.Size = new Size(300, 20);
            prgConsumo.TabIndex = 6;
            // 
            // lblPercentual
            // 
            lblPercentual.AutoSize = true;
            lblPercentual.Location = new Point(335, 133);
            lblPercentual.Name = "lblPercentual";
            lblPercentual.Size = new Size(23, 15);
            lblPercentual.TabIndex = 7;
            lblPercentual.Text = "0%";
            // 
            // btnSair
            // 
            btnSair.Location = new Point(700, 20);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 8;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // picJogo
            // 
            picJogo.BackColor = Color.FromArgb(240, 240, 240);
            picJogo.BorderStyle = BorderStyle.FixedSingle;
            picJogo.Location = new Point(350, 210);
            picJogo.Name = "picJogo";
            picJogo.Size = new Size(150, 150);
            picJogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picJogo.TabIndex = 9;
            picJogo.TabStop = false;
            picJogo.Click += picJogo_Click;
            // 
            // lblJogoSelecionado
            // 
            lblJogoSelecionado.AutoSize = true;
            lblJogoSelecionado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblJogoSelecionado.Location = new Point(350, 180);
            lblJogoSelecionado.Name = "lblJogoSelecionado";
            lblJogoSelecionado.Size = new Size(95, 19);
            lblJogoSelecionado.TabIndex = 10;
            lblJogoSelecionado.Text = "Visualização:";
            // 
            // FormEscolaPainel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(lblJogoSelecionado);
            Controls.Add(picJogo);
            Controls.Add(btnSair);
            Controls.Add(lblPercentual);
            Controls.Add(prgConsumo);
            Controls.Add(btnSimularAcesso);
            Controls.Add(lblJogosTitulo);
            Controls.Add(lstJogos);
            Controls.Add(lblLimiteInfo);
            Controls.Add(lblPacoteInfo);
            Controls.Add(lblEscolaNome);
            Name = "FormEscolaPainel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Messier - Painel da Escola";
            ((System.ComponentModel.ISupportInitialize)picJogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblEscolaNome;
        private System.Windows.Forms.Label lblPacoteInfo;
        private System.Windows.Forms.Label lblLimiteInfo;
        private System.Windows.Forms.ListBox lstJogos;
        private System.Windows.Forms.Label lblJogosTitulo;
        private System.Windows.Forms.Button btnSimularAcesso;
        private System.Windows.Forms.ProgressBar prgConsumo;
        private System.Windows.Forms.Label lblPercentual;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox picJogo;
        private System.Windows.Forms.Label lblJogoSelecionado;
    }
}
