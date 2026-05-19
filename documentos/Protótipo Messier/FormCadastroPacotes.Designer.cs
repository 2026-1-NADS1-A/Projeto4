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
            dgvPacotes = new DataGridView();
            txtNome = new TextBox();
            txtLimite = new TextBox();
            txtPreco = new TextBox();
            clbJogos = new CheckedListBox();
            btnSalvar = new Button();
            lblNome = new Label();
            lblLimite = new Label();
            lblPreco = new Label();
            lblJogos = new Label();
            pnlHeader = new Panel();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPacotes).BeginInit();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPacotes
            // 
            dgvPacotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPacotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacotes.Location = new Point(20, 260);
            dgvPacotes.Name = "dgvPacotes";
            dgvPacotes.Size = new Size(650, 200);
            dgvPacotes.TabIndex = 10;
            dgvPacotes.CellContentClick += dgvPacotes_CellContentClick;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(20, 100);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(250, 23);
            txtNome.TabIndex = 2;
            // 
            // txtLimite
            // 
            txtLimite.Location = new Point(20, 160);
            txtLimite.Name = "txtLimite";
            txtLimite.Size = new Size(120, 23);
            txtLimite.TabIndex = 4;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(150, 160);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(120, 23);
            txtPreco.TabIndex = 6;
            // 
            // clbJogos
            // 
            clbJogos.Location = new Point(300, 100);
            clbJogos.Name = "clbJogos";
            clbJogos.Size = new Size(350, 112);
            clbJogos.TabIndex = 8;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(46, 139, 87);
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(20, 210);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(100, 30);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblNome
            // 
            lblNome.Location = new Point(20, 80);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(100, 23);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome do Pacote:";
            // 
            // lblLimite
            // 
            lblLimite.Location = new Point(20, 140);
            lblLimite.Name = "lblLimite";
            lblLimite.Size = new Size(130, 23);
            lblLimite.TabIndex = 3;
            lblLimite.Text = "Limite de Acessos/Mês:";
            // 
            // lblPreco
            // 
            lblPreco.Location = new Point(150, 140);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(100, 23);
            lblPreco.TabIndex = 5;
            lblPreco.Text = "Preço Mensal:";
            // 
            // lblJogos
            // 
            lblJogos.Location = new Point(300, 80);
            lblJogos.Name = "lblJogos";
            lblJogos.Size = new Size(200, 23);
            lblJogos.TabIndex = 7;
            lblJogos.Text = "Selecione os Jogos do Pacote:";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(46, 139, 87);
            pnlHeader.Controls.Add(lblTitulo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(700, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(224, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Cadastro de Pacotes";
            // 
            // FormCadastroPacotes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(700, 500);
            Controls.Add(dgvPacotes);
            Controls.Add(btnSalvar);
            Controls.Add(clbJogos);
            Controls.Add(lblJogos);
            Controls.Add(txtPreco);
            Controls.Add(lblPreco);
            Controls.Add(txtLimite);
            Controls.Add(lblLimite);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(pnlHeader);
            Name = "FormCadastroPacotes";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Pacotes";
            ((System.ComponentModel.ISupportInitialize)dgvPacotes).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
