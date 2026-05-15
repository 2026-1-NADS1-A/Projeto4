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
            btnEntrar = new Button();
            cmbEscola = new ComboBox();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(354, 237);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // cmbEscola
            // 
            cmbEscola.FormattingEnabled = true;
            cmbEscola.Location = new Point(354, 165);
            cmbEscola.Name = "cmbEscola";
            cmbEscola.Size = new Size(121, 23);
            cmbEscola.TabIndex = 1;
            // 
            // LoginEscolaForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbEscola);
            Controls.Add(btnEntrar);
            Name = "LoginEscolaForms";
            Text = "LoginEscolaForms";
            ResumeLayout(false);
        }

        #endregion

        private Button btnEntrar;
        private ComboBox cmbEscola;
    }
}