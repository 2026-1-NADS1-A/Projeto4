namespace PrototipoMessier
{
    partial class RelEscolas
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
            btnImprimir = new Button();
            txtRelatorios = new TextBox();
            SuspendLayout();
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(12, 12);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(75, 23);
            btnImprimir.TabIndex = 0;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // txtRelatorios
            // 
            txtRelatorios.Location = new Point(12, 54);
            txtRelatorios.Multiline = true;
            txtRelatorios.Name = "txtRelatorios";
            txtRelatorios.ScrollBars = ScrollBars.Vertical;
            txtRelatorios.Size = new Size(749, 280);
            txtRelatorios.TabIndex = 1;
            txtRelatorios.TextChanged += txtRelatorios_TextChanged;
            // 
            // RelEscolas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtRelatorios);
            Controls.Add(btnImprimir);
            Name = "RelEscolas";
            Text = "RelEscolas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnImprimir;
        private TextBox txtRelatorios;
    }
}