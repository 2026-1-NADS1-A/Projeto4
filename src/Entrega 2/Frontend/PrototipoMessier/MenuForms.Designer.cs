namespace PrototipoMessier
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            escolasToolStripMenuItem = new ToolStripMenuItem();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            jogosToolStripMenuItem = new ToolStripMenuItem();
            pacotesToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            relatórioToolStripMenuItem = new ToolStripMenuItem();
            relatorioToolStripMenuItem = new ToolStripMenuItem();
            escolaToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // escolasToolStripMenuItem
            // 
            escolasToolStripMenuItem.Name = "escolasToolStripMenuItem";
            escolasToolStripMenuItem.Size = new Size(32, 19);
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { jogosToolStripMenuItem, pacotesToolStripMenuItem, helpToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // jogosToolStripMenuItem
            // 
            jogosToolStripMenuItem.Name = "jogosToolStripMenuItem";
            jogosToolStripMenuItem.Size = new Size(180, 22);
            jogosToolStripMenuItem.Text = "Jogos";
            jogosToolStripMenuItem.Click += jogosToolStripMenuItem_Click;
            // 
            // pacotesToolStripMenuItem
            // 
            pacotesToolStripMenuItem.Name = "pacotesToolStripMenuItem";
            pacotesToolStripMenuItem.Size = new Size(180, 22);
            pacotesToolStripMenuItem.Text = "Pacotes";
            pacotesToolStripMenuItem.Click += pacotesToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(180, 22);
            helpToolStripMenuItem.Text = "Help";
            helpToolStripMenuItem.Click += helpToolStripMenuItem_Click;
            // 
            // relatórioToolStripMenuItem
            // 
            relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            relatórioToolStripMenuItem.Size = new Size(12, 20);
            // 
            // relatorioToolStripMenuItem
            // 
            relatorioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { escolaToolStripMenuItem });
            relatorioToolStripMenuItem.Name = "relatorioToolStripMenuItem";
            relatorioToolStripMenuItem.Size = new Size(66, 20);
            relatorioToolStripMenuItem.Text = "Relatorio";
            // 
            // escolaToolStripMenuItem
            // 
            escolaToolStripMenuItem.Name = "escolaToolStripMenuItem";
            escolaToolStripMenuItem.Size = new Size(180, 22);
            escolaToolStripMenuItem.Text = "Escola";
            escolaToolStripMenuItem.Click += escolaToolStripMenuItem_Click_1;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, relatórioToolStripMenuItem, relatorioToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(856, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 462);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Prototipo Messier";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStripMenuItem escolasToolStripMenuItem;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem jogosToolStripMenuItem;
        private ToolStripMenuItem pacotesToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem relatórioToolStripMenuItem;
        private ToolStripMenuItem relatorioToolStripMenuItem;
        private ToolStripMenuItem escolaToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private MenuStrip menuStrip1;
    }
}
