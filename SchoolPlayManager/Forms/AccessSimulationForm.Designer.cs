namespace SchoolPlayManager.Forms
{
    partial class AccessSimulationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccessSimulationForm));
            txtIpOrigem = new TextBox();
            btnVerificarAcesso = new Button();
            lblStatus = new Label();
            teste = new ListBox();
            SuspendLayout();
            // 
            // txtIpOrigem
            // 
            txtIpOrigem.BackColor = Color.Lavender;
            txtIpOrigem.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtIpOrigem.Location = new Point(517, 169);
            txtIpOrigem.Multiline = true;
            txtIpOrigem.Name = "txtIpOrigem";
            txtIpOrigem.PlaceholderText = "Digite o IP (ex: 192.168.1.1)";
            txtIpOrigem.Size = new Size(301, 48);
            txtIpOrigem.TabIndex = 0;
            txtIpOrigem.TextAlign = HorizontalAlignment.Center;
            txtIpOrigem.TextChanged += txtIpOrigem_TextChanged;
            // 
            // btnVerificarAcesso
            // 
            btnVerificarAcesso.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerificarAcesso.Location = new Point(558, 253);
            btnVerificarAcesso.Name = "btnVerificarAcesso";
            btnVerificarAcesso.Size = new Size(208, 32);
            btnVerificarAcesso.TabIndex = 1;
            btnVerificarAcesso.Text = "Verificar Acesso";
            btnVerificarAcesso.UseVisualStyleBackColor = true;
            btnVerificarAcesso.Click += btnVerificarAcesso_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(626, 112);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(61, 23);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Status";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            lblStatus.Click += lblStatus_Click;
            // 
            // teste
            // 
            teste.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            teste.FormattingEnabled = true;
            teste.Location = new Point(500, 329);
            teste.Name = "teste";
            teste.Size = new Size(318, 188);
            teste.TabIndex = 3;
            // 
            // AccessSimulationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1291, 637);
            Controls.Add(teste);
            Controls.Add(lblStatus);
            Controls.Add(btnVerificarAcesso);
            Controls.Add(txtIpOrigem);
            Name = "AccessSimulationForm";
            Text = "AccessSimulationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIpOrigem;
        private Button btnVerificarAcesso;
        private Label lblStatus;
        private ListBox teste;
    }
}