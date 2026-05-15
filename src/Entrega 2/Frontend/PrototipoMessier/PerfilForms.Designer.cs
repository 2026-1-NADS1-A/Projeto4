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
            btnEscola = new Button();
            btnAdmin = new Button();
            SuspendLayout();
            // 
            // btnEscola
            // 
            btnEscola.Location = new Point(144, 234);
            btnEscola.Name = "btnEscola";
            btnEscola.Size = new Size(121, 23);
            btnEscola.TabIndex = 0;
            btnEscola.Text = "Login Escola";
            btnEscola.UseVisualStyleBackColor = true;
            btnEscola.Click += btnEscola_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.Location = new Point(469, 234);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(144, 23);
            btnAdmin.TabIndex = 1;
            btnAdmin.Text = "Login Admin";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // PerfilForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdmin);
            Controls.Add(btnEscola);
            Name = "PerfilForms";
            Text = "PerfilForms";
            ResumeLayout(false);
        }

        #endregion

        private Button btnEscola;
        private Button btnAdmin;
    }
}