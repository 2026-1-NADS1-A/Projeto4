namespace PrototipoMessier.Forms
{
    partial class FormHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelp));
            pnlHeader = new Panel();
            lblTitulo = new Label();
            txtHelp = new TextBox();
            btnFechar = new Button();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(46, 139, 87);
            pnlHeader.Controls.Add(lblTitulo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(500, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(193, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Ajuda do Sistema";
            // 
            // txtHelp
            // 
            txtHelp.BackColor = Color.White;
            txtHelp.BorderStyle = BorderStyle.None;
            txtHelp.Font = new Font("Segoe UI", 11F);
            txtHelp.Location = new Point(30, 80);
            txtHelp.Multiline = true;
            txtHelp.Name = "txtHelp";
            txtHelp.ReadOnly = true;
            txtHelp.Size = new Size(440, 250);
            txtHelp.TabIndex = 1;
            txtHelp.Text = resources.GetString("txtHelp.Text");
            txtHelp.TextChanged += txtHelp_TextChanged;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.FromArgb(46, 139, 87);
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(200, 350);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(100, 35);
            btnFechar.TabIndex = 2;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // FormHelp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(500, 410);
            Controls.Add(btnFechar);
            Controls.Add(txtHelp);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormHelp";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Messier - Ajuda";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtHelp;
        private System.Windows.Forms.Button btnFechar;
    }
}
