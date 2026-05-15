namespace PrototipoMessier
{
    partial class LoginAdminForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginAdminForms));
            btnEntrar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            label3 = new Label();
            txtSenha = new TextBox();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            resources.ApplyResources(btnEntrar, "btnEntrar");
            btnEntrar.Name = "btnEntrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // txtUsuario
            // 
            resources.ApplyResources(txtUsuario, "txtUsuario");
            txtUsuario.Name = "txtUsuario";
            txtUsuario.UseWaitCursor = true;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // txtSenha
            // 
            resources.ApplyResources(txtSenha, "txtSenha");
            txtSenha.Name = "txtSenha";
            txtSenha.UseWaitCursor = true;
            // 
            // LoginAdminForms
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtSenha);
            Controls.Add(label3);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEntrar);
            Name = "LoginAdminForms";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEntrar;
        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private Label label3;
        private TextBox txtSenha;
    }
}