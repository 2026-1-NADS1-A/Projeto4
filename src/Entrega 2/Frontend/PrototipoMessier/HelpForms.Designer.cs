namespace PrototipoMessier
{
    partial class HelpForms
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
            lblHelp = new Label();
            SuspendLayout();
            // 
            // lblHelp
            // 
            lblHelp.AutoSize = true;
            lblHelp.Location = new Point(326, 52);
            lblHelp.Name = "lblHelp";
            lblHelp.Size = new Size(124, 15);
            lblHelp.TabIndex = 0;
            lblHelp.Text = "Digite aqui sua dúvida";
            lblHelp.Click += lblHelp_Click;
            // 
            // HelpForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 475);
            Controls.Add(lblHelp);
            Name = "HelpForms";
            Text = "Ajuda Messier";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHelp;
    }
}