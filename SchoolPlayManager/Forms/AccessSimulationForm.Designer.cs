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
            txtIpOrigem = new TextBox();
            btnVerificarAcesso = new Button();
            lblStatus = new Label();
            lstLogs = new ListBox();
            SuspendLayout();
            // 
            // txtIpOrigem
            // 
            txtIpOrigem.Location = new Point(310, 187);
            txtIpOrigem.Name = "txtIpOrigem";
            txtIpOrigem.PlaceholderText = "Digite o IP (ex: 192.168.1.1)";
            txtIpOrigem.Size = new Size(209, 23);
            txtIpOrigem.TabIndex = 0;
            txtIpOrigem.TextChanged += txtIpOrigem_TextChanged;
            // 
            // btnVerificarAcesso
            // 
            btnVerificarAcesso.Location = new Point(333, 258);
            btnVerificarAcesso.Name = "btnVerificarAcesso";
            btnVerificarAcesso.Size = new Size(157, 23);
            btnVerificarAcesso.TabIndex = 1;
            btnVerificarAcesso.Text = "btnVerificarAcesso";
            btnVerificarAcesso.UseVisualStyleBackColor = true;
            btnVerificarAcesso.Click += btnVerificarAcesso_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(379, 100);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(52, 15);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "lblStatus";
            lblStatus.Click += lblStatus_Click;
            // 
            // lstLogs
            // 
            lstLogs.FormattingEnabled = true;
            lstLogs.Location = new Point(343, 329);
            lstLogs.Name = "lstLogs";
            lstLogs.Size = new Size(120, 94);
            lstLogs.TabIndex = 3;
            // 
            // AccessSimulationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstLogs);
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
        private ListBox lstLogs;
    }
}