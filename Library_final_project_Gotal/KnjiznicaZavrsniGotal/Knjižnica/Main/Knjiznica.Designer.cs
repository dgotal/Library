namespace KnjiznicaZavrsniGotal.Knjižnica
{
    partial class Knjiznica
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.početnaStranicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosKnjigaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosŽanraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosAutoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelUnos = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.početnaStranicaToolStripMenuItem,
            this.unosKnjigaToolStripMenuItem,
            this.unosKorisnikaToolStripMenuItem,
            this.unosŽanraToolStripMenuItem,
            this.unosAutoraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(561, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuItemClicked);
            // 
            // početnaStranicaToolStripMenuItem
            // 
            this.početnaStranicaToolStripMenuItem.Name = "početnaStranicaToolStripMenuItem";
            this.početnaStranicaToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.početnaStranicaToolStripMenuItem.Text = "Početna stranica";
            // 
            // unosKnjigaToolStripMenuItem
            // 
            this.unosKnjigaToolStripMenuItem.Name = "unosKnjigaToolStripMenuItem";
            this.unosKnjigaToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.unosKnjigaToolStripMenuItem.Text = "Unos Knjiga";
            // 
            // unosKorisnikaToolStripMenuItem
            // 
            this.unosKorisnikaToolStripMenuItem.Name = "unosKorisnikaToolStripMenuItem";
            this.unosKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.unosKorisnikaToolStripMenuItem.Text = "Unos Korisnika";
            // 
            // unosŽanraToolStripMenuItem
            // 
            this.unosŽanraToolStripMenuItem.Name = "unosŽanraToolStripMenuItem";
            this.unosŽanraToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.unosŽanraToolStripMenuItem.Text = "Unos Žanra";
            // 
            // unosAutoraToolStripMenuItem
            // 
            this.unosAutoraToolStripMenuItem.Name = "unosAutoraToolStripMenuItem";
            this.unosAutoraToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.unosAutoraToolStripMenuItem.Text = "Unos Autora";
            // 
            // panelUnos
            // 
            this.panelUnos.Location = new System.Drawing.Point(0, 27);
            this.panelUnos.Name = "panelUnos";
            this.panelUnos.Size = new System.Drawing.Size(562, 347);
            this.panelUnos.TabIndex = 5;
            // 
            // Knjiznica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 373);
            this.Controls.Add(this.panelUnos);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.35F);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Knjiznica";
            this.Text = "Knjižnica";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem unosKnjigaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosŽanraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosAutoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem početnaStranicaToolStripMenuItem;
        private System.Windows.Forms.Panel panelUnos;
    }
}