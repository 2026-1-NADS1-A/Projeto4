namespace PrototipoMessier.Forms
{
    partial class FormCadastroPacotes
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
            this.dgvPacotes = new System.Windows.Forms.DataGridView();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.clbJogos = new System.Windows.Forms.CheckedListBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblLimite = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblJogos = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacotes)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(700, 60);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(20, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(222, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cadastro de Pacotes";
            // 
            // lblNome
            // 
            this.lblNome.Location = new System.Drawing.Point(20, 80);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(100, 23);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome do Pacote:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(20, 100);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(250, 23);
            this.txtNome.TabIndex = 2;
            // 
            // lblLimite
            // 
            this.lblLimite.Location = new System.Drawing.Point(20, 140);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(130, 23);
            this.lblLimite.TabIndex = 3;
            this.lblLimite.Text = "Limite de Acessos/Mês:";
            // 
            // txtLimite
            // 
            this.txtLimite.Location = new System.Drawing.Point(20, 160);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(120, 23);
            this.txtLimite.TabIndex = 4;
            // 
            // lblPreco
            // 
            this.lblPreco.Location = new System.Drawing.Point(150, 140);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(100, 23);
            this.lblPreco.TabIndex = 5;
            this.lblPreco.Text = "Preço Mensal:";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(150, 160);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(120, 23);
            this.txtPreco.TabIndex = 6;
            // 
            // lblJogos
            // 
            this.lblJogos.Location = new System.Drawing.Point(300, 80);
            this.lblJogos.Name = "lblJogos";
            this.lblJogos.Size = new System.Drawing.Size(200, 23);
            this.lblJogos.TabIndex = 7;
            this.lblJogos.Text = "Selecione os Jogos do Pacote:";
            // 
            // clbJogos
            // 
            this.clbJogos.Location = new System.Drawing.Point(300, 100);
            this.clbJogos.Name = "clbJogos";
            this.clbJogos.Size = new System.Drawing.Size(350, 112);
            this.clbJogos.TabIndex = 8;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(20, 210);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 30);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dgvPacotes
            // 
            this.dgvPacotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPacotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacotes.Location = new System.Drawing.Point(20, 260);
            this.dgvPacotes.Name = "dgvPacotes";
            this.dgvPacotes.Size = new System.Drawing.Size(650, 200);
            this.dgvPacotes.TabIndex = 10;
            // 
            // FormCadastroPacotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.dgvPacotes);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.clbJogos);
            this.Controls.Add(this.lblJogos);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.txtLimite);
            this.Controls.Add(this.lblLimite);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.pnlHeader);
            this.Name = "FormCadastroPacotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Pacotes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacotes)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvPacotes;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtLimite;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.CheckedListBox clbJogos;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblJogos;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
    }
}
