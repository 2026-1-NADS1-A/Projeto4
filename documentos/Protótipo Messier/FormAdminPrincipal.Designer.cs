namespace PrototipoMessier.Forms
{
    partial class FormAdminPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlCard1 = new System.Windows.Forms.Panel();
            this.lblCard1Title = new System.Windows.Forms.Label();
            this.lblCard1Value = new System.Windows.Forms.Label();
            this.pnlCard2 = new System.Windows.Forms.Panel();
            this.lblCard2Title = new System.Windows.Forms.Label();
            this.lblCard2Value = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlCard1.SuspendLayout();
            this.pnlCard2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.ForeColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.relatorioToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jogosToolStripMenuItem,
            this.pacotesToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(82, 23);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // jogosToolStripMenuItem
            // 
            this.jogosToolStripMenuItem.Name = "jogosToolStripMenuItem";
            this.jogosToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.jogosToolStripMenuItem.Text = "Jogos";
            this.jogosToolStripMenuItem.Click += new System.EventHandler(this.jogosToolStripMenuItem_Click);
            // 
            // pacotesToolStripMenuItem
            // 
            this.pacotesToolStripMenuItem.Name = "pacotesToolStripMenuItem";
            this.pacotesToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.pacotesToolStripMenuItem.Text = "Pacotes";
            this.pacotesToolStripMenuItem.Click += new System.EventHandler(this.pacotesToolStripMenuItem_Click);
            // 
            // relatorioToolStripMenuItem
            // 
            this.relatorioToolStripMenuItem.Name = "relatorioToolStripMenuItem";
            this.relatorioToolStripMenuItem.Size = new System.Drawing.Size(81, 23);
            this.relatorioToolStripMenuItem.Text = "Relatórios";
            this.relatorioToolStripMenuItem.Click += new System.EventHandler(this.relatorioToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(49, 23);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(43, 23);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.pnlContent.Controls.Add(this.pnlCard1);
            this.pnlContent.Controls.Add(this.pnlCard2);
            this.pnlContent.Controls.Add(this.lblWelcome);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 27);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(800, 473);
            this.pnlContent.TabIndex = 1;
            // 
            // pnlCard1
            // 
            this.pnlCard1.BackColor = System.Drawing.Color.White;
            this.pnlCard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard1.Controls.Add(this.lblCard1Title);
            this.pnlCard1.Controls.Add(this.lblCard1Value);
            this.pnlCard1.Location = new System.Drawing.Point(40, 120);
            this.pnlCard1.Name = "pnlCard1";
            this.pnlCard1.Size = new System.Drawing.Size(200, 100);
            this.pnlCard1.TabIndex = 1;
            // 
            // lblCard1Title
            // 
            this.lblCard1Title.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCard1Title.Location = new System.Drawing.Point(10, 10);
            this.lblCard1Title.Name = "lblCard1Title";
            this.lblCard1Title.Size = new System.Drawing.Size(180, 20);
            this.lblCard1Title.TabIndex = 0;
            this.lblCard1Title.Text = "Jogos Cadastrados";
            // 
            // lblCard1Value
            // 
            this.lblCard1Value.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblCard1Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.lblCard1Value.Location = new System.Drawing.Point(10, 40);
            this.lblCard1Value.Name = "lblCard1Value";
            this.lblCard1Value.Size = new System.Drawing.Size(180, 45);
            this.lblCard1Value.TabIndex = 1;
            this.lblCard1Value.Text = "0";
            // 
            // pnlCard2
            // 
            this.pnlCard2.BackColor = System.Drawing.Color.White;
            this.pnlCard2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard2.Controls.Add(this.lblCard2Title);
            this.pnlCard2.Controls.Add(this.lblCard2Value);
            this.pnlCard2.Location = new System.Drawing.Point(260, 120);
            this.pnlCard2.Name = "pnlCard2";
            this.pnlCard2.Size = new System.Drawing.Size(200, 100);
            this.pnlCard2.TabIndex = 2;
            // 
            // lblCard2Title
            // 
            this.lblCard2Title.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCard2Title.Location = new System.Drawing.Point(10, 10);
            this.lblCard2Title.Name = "lblCard2Title";
            this.lblCard2Title.Size = new System.Drawing.Size(180, 20);
            this.lblCard2Title.TabIndex = 0;
            this.lblCard2Title.Text = "Pacotes Ativos";
            // 
            // lblCard2Value
            // 
            this.lblCard2Value.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblCard2Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.lblCard2Value.Location = new System.Drawing.Point(10, 40);
            this.lblCard2Value.Name = "lblCard2Value";
            this.lblCard2Value.Size = new System.Drawing.Size(180, 45);
            this.lblCard2Value.TabIndex = 1;
            this.lblCard2Value.Text = "0";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblWelcome.Location = new System.Drawing.Point(40, 40);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(395, 41);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Dashboard Administrativo";
            // 
            // FormAdminPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAdminPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Messier - Admin Panel";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.pnlCard1.ResumeLayout(false);
            this.pnlCard2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlCard1;
        private System.Windows.Forms.Label lblCard1Title;
        private System.Windows.Forms.Label lblCard1Value;
        private System.Windows.Forms.Panel pnlCard2;
        private System.Windows.Forms.Label lblCard2Title;
        private System.Windows.Forms.Label lblCard2Value;
    }
}
