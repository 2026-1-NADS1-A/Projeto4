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
            this.lblEscolaNome = new System.Windows.Forms.Label();
            this.lblPacoteInfo = new System.Windows.Forms.Label();
            this.lblLimiteInfo = new System.Windows.Forms.Label();
            this.lstJogos = new System.Windows.Forms.ListBox();
            this.lblJogosTitulo = new System.Windows.Forms.Label();
            this.btnSimularAcesso = new System.Windows.Forms.Button();
            this.prgConsumo = new System.Windows.Forms.ProgressBar();
            this.lblPercentual = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.picJogo = new System.Windows.Forms.PictureBox();
            this.lblJogoSelecionado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picJogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEscolaNome
            // 
            this.lblEscolaNome.AutoSize = true;
            this.lblEscolaNome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblEscolaNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.lblEscolaNome.Location = new System.Drawing.Point(20, 20);
            this.lblEscolaNome.Name = "lblEscolaNome";
            this.lblEscolaNome.Size = new System.Drawing.Size(165, 32);
            this.lblEscolaNome.TabIndex = 0;
            this.lblEscolaNome.Text = "Bem-vindo...";
            // 
            // lblPacoteInfo
            // 
            this.lblPacoteInfo.AutoSize = true;
            this.lblPacoteInfo.Location = new System.Drawing.Point(25, 70);
            this.lblPacoteInfo.Name = "lblPacoteInfo";
            this.lblPacoteInfo.Size = new System.Drawing.Size(84, 15);
            this.lblPacoteInfo.TabIndex = 1;
            this.lblPacoteInfo.Text = "Pacote Atual...";
            // 
            // lblLimiteInfo
            // 
            this.lblLimiteInfo.AutoSize = true;
            this.lblLimiteInfo.Location = new System.Drawing.Point(25, 100);
            this.lblLimiteInfo.Name = "lblLimiteInfo";
            this.lblLimiteInfo.Size = new System.Drawing.Size(69, 15);
            this.lblLimiteInfo.TabIndex = 2;
            this.lblLimiteInfo.Text = "Consumo...";
            // 
            // lstJogos
            // 
            this.lstJogos.FormattingEnabled = true;
            this.lstJogos.ItemHeight = 15;
            this.lstJogos.Location = new System.Drawing.Point(25, 210);
            this.lstJogos.Name = "lstJogos";
            this.lstJogos.Size = new System.Drawing.Size(300, 154);
            this.lstJogos.TabIndex = 3;
            this.lstJogos.SelectedIndexChanged += new System.EventHandler(this.lstJogos_SelectedIndexChanged);
            // 
            // lblJogosTitulo
            // 
            this.lblJogosTitulo.AutoSize = true;
            this.lblJogosTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblJogosTitulo.Location = new System.Drawing.Point(25, 180);
            this.lblJogosTitulo.Name = "lblJogosTitulo";
            this.lblJogosTitulo.Size = new System.Drawing.Size(192, 21);
            this.lblJogosTitulo.TabIndex = 4;
            this.lblJogosTitulo.Text = "Seus Jogos Disponíveis:";
            // 
            // btnSimularAcesso
            // 
            this.btnSimularAcesso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSimularAcesso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimularAcesso.ForeColor = System.Drawing.Color.White;
            this.btnSimularAcesso.Location = new System.Drawing.Point(25, 380);
            this.btnSimularAcesso.Name = "btnSimularAcesso";
            this.btnSimularAcesso.Size = new System.Drawing.Size(150, 40);
            this.btnSimularAcesso.TabIndex = 5;
            this.btnSimularAcesso.Text = "Simular Acesso";
            this.btnSimularAcesso.UseVisualStyleBackColor = false;
            this.btnSimularAcesso.Click += new System.EventHandler(this.btnSimularAcesso_Click);
            // 
            // prgConsumo
            // 
            this.prgConsumo.Location = new System.Drawing.Point(25, 130);
            this.prgConsumo.Name = "prgConsumo";
            this.prgConsumo.Size = new System.Drawing.Size(300, 20);
            this.prgConsumo.TabIndex = 6;
            // 
            // lblPercentual
            // 
            this.lblPercentual.AutoSize = true;
            this.lblPercentual.Location = new System.Drawing.Point(335, 133);
            this.lblPercentual.Name = "lblPercentual";
            this.lblPercentual.Size = new System.Drawing.Size(23, 15);
            this.lblPercentual.TabIndex = 7;
            this.lblPercentual.Text = "0%";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(700, 20);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // picJogo
            // 
            this.picJogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.picJogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picJogo.Location = new System.Drawing.Point(350, 210);
            this.picJogo.Name = "picJogo";
            this.picJogo.Size = new System.Drawing.Size(150, 150);
            this.picJogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picJogo.TabIndex = 9;
            this.picJogo.TabStop = false;
            // 
            // lblJogoSelecionado
            // 
            this.lblJogoSelecionado.AutoSize = true;
            this.lblJogoSelecionado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblJogoSelecionado.Location = new System.Drawing.Point(350, 180);
            this.lblJogoSelecionado.Name = "lblJogoSelecionado";
            this.lblJogoSelecionado.Size = new System.Drawing.Size(95, 19);
            this.lblJogoSelecionado.TabIndex = 10;
            this.lblJogoSelecionado.Text = "Visualização:";
            // 
            // FormEscolaPainel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblJogoSelecionado);
            this.Controls.Add(this.picJogo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblPercentual);
            this.Controls.Add(this.prgConsumo);
            this.Controls.Add(this.btnSimularAcesso);
            this.Controls.Add(this.lblJogosTitulo);
            this.Controls.Add(this.lstJogos);
            this.Controls.Add(this.lblLimiteInfo);
            this.Controls.Add(this.lblPacoteInfo);
            this.Controls.Add(this.lblEscolaNome);
            this.Name = "FormEscolaPainel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Messier - Painel da Escola";
            ((System.ComponentModel.ISupportInitialize)(this.picJogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
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
