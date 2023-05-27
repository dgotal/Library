namespace KnjiznicaZavrsniGotal.Knjižnica
{
    partial class Knjige
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
            this.menuStripKnjige = new System.Windows.Forms.MenuStrip();
            this.početnaStranicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posudbaKnjigaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretraživanjeKnjigaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelKnjige = new System.Windows.Forms.Panel();
            this.menuStripKnjige.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripKnjige
            // 
            this.menuStripKnjige.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripKnjige.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.početnaStranicaToolStripMenuItem,
            this.posudbaKnjigaToolStripMenuItem,
            this.pretraživanjeKnjigaToolStripMenuItem});
            this.menuStripKnjige.Location = new System.Drawing.Point(0, 0);
            this.menuStripKnjige.Name = "menuStripKnjige";
            this.menuStripKnjige.Size = new System.Drawing.Size(862, 24);
            this.menuStripKnjige.TabIndex = 0;
            this.menuStripKnjige.Text = "menuStrip1";
            this.menuStripKnjige.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStripKnjige_ItemClicked);
            // 
            // početnaStranicaToolStripMenuItem
            // 
            this.početnaStranicaToolStripMenuItem.Name = "početnaStranicaToolStripMenuItem";
            this.početnaStranicaToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.početnaStranicaToolStripMenuItem.Text = "Početna Stranica";
            // 
            // posudbaKnjigaToolStripMenuItem
            // 
            this.posudbaKnjigaToolStripMenuItem.Name = "posudbaKnjigaToolStripMenuItem";
            this.posudbaKnjigaToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.posudbaKnjigaToolStripMenuItem.Text = "Posudba Knjiga";
            // 
            // pretraživanjeKnjigaToolStripMenuItem
            // 
            this.pretraživanjeKnjigaToolStripMenuItem.Name = "pretraživanjeKnjigaToolStripMenuItem";
            this.pretraživanjeKnjigaToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.pretraživanjeKnjigaToolStripMenuItem.Text = "Pretraživanje Knjiga";
            // 
            // panelKnjige
            // 
            this.panelKnjige.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(213)))), ((int)(((byte)(241)))));
            this.panelKnjige.Location = new System.Drawing.Point(0, 27);
            this.panelKnjige.Name = "panelKnjige";
            this.panelKnjige.Size = new System.Drawing.Size(862, 451);
            this.panelKnjige.TabIndex = 1;
            // 
            // Knjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 479);
            this.Controls.Add(this.panelKnjige);
            this.Controls.Add(this.menuStripKnjige);
            this.MainMenuStrip = this.menuStripKnjige;
            this.Name = "Knjige";
            this.Text = "Knjige";
            this.menuStripKnjige.ResumeLayout(false);
            this.menuStripKnjige.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripKnjige;
        private System.Windows.Forms.ToolStripMenuItem posudbaKnjigaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretraživanjeKnjigaToolStripMenuItem;
        private System.Windows.Forms.Panel panelKnjige;
        private System.Windows.Forms.ToolStripMenuItem početnaStranicaToolStripMenuItem;
    }
}