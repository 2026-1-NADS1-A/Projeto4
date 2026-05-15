namespace PrototipoMessier
{
    partial class PacoteForms
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
            txtNome = new TextBox();
            txtID = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            checkedListBox1 = new CheckedListBox();
            grdPacotes = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            btnSalvar = new Button();
            btnNovo = new Button();
            ((System.ComponentModel.ISupportInitialize)grdPacotes).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(195, 45);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(467, 27);
            txtNome.TabIndex = 8;
            // 
            // txtID
            // 
            txtID.Location = new Point(195, 9);
            txtID.Name = "txtID";
            txtID.Size = new Size(70, 27);
            txtID.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 6;
            label2.Text = "Nome do Pacote";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 5;
            label1.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 100);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 9;
            label3.Text = "Jogos do Pacote";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Jogo 1", "Jogo 2", "Jogo 3", "Jogo 4", "Jogo 5" });
            checkedListBox1.Location = new Point(195, 100);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(287, 114);
            checkedListBox1.TabIndex = 10;
            // 
            // grdPacotes
            // 
            grdPacotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdPacotes.Columns.AddRange(new DataGridViewColumn[] { ID, Nome });
            grdPacotes.Location = new Point(195, 265);
            grdPacotes.Name = "grdPacotes";
            grdPacotes.RowHeadersWidth = 51;
            grdPacotes.Size = new Size(330, 188);
            grdPacotes.TabIndex = 11;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MaxInputLength = 3;
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 60;
            // 
            // Nome
            // 
            Nome.HeaderText = "Pacote";
            Nome.MaxInputLength = 20;
            Nome.MinimumWidth = 6;
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 200;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(388, 230);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 13;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(195, 230);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(94, 29);
            btnNovo.TabIndex = 12;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // PacoteForms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalvar);
            Controls.Add(btnNovo);
            Controls.Add(grdPacotes);
            Controls.Add(checkedListBox1);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(txtID);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PacoteForms";
            Text = "Cadastro de Pacotes";
            ((System.ComponentModel.ISupportInitialize)grdPacotes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtID;
        private Label label2;
        private Label label1;
        private Label label3;
        private CheckedListBox checkedListBox1;
        private DataGridView grdPacotes;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nome;
        private Button btnSalvar;
        private Button btnNovo;
    }
}