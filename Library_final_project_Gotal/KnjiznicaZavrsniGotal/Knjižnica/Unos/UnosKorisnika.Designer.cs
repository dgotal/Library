namespace KnjiznicaZavrsniGotal.Knjižnica
{
    partial class UnosKorisnika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnosKorisnika));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddKorisnik = new System.Windows.Forms.Button();
            this.txtImeKorisnika = new System.Windows.Forms.TextBox();
            this.txtPrezimeKorisnika = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtJMBAG = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.label2.Location = new System.Drawing.Point(10, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.label3.Location = new System.Drawing.Point(9, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prezime";
            // 
            // btnAddKorisnik
            // 
            this.btnAddKorisnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.btnAddKorisnik.Location = new System.Drawing.Point(261, 212);
            this.btnAddKorisnik.Name = "btnAddKorisnik";
            this.btnAddKorisnik.Size = new System.Drawing.Size(157, 33);
            this.btnAddKorisnik.TabIndex = 3;
            this.btnAddKorisnik.Text = "Dodaj korisnika";
            this.btnAddKorisnik.UseVisualStyleBackColor = true;
            this.btnAddKorisnik.Click += new System.EventHandler(this.BtnAddKorisnik_Click);
            // 
            // txtImeKorisnika
            // 
            this.txtImeKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.txtImeKorisnika.Location = new System.Drawing.Point(111, 72);
            this.txtImeKorisnika.Name = "txtImeKorisnika";
            this.txtImeKorisnika.Size = new System.Drawing.Size(145, 25);
            this.txtImeKorisnika.TabIndex = 5;
            // 
            // txtPrezimeKorisnika
            // 
            this.txtPrezimeKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.txtPrezimeKorisnika.Location = new System.Drawing.Point(111, 125);
            this.txtPrezimeKorisnika.Name = "txtPrezimeKorisnika";
            this.txtPrezimeKorisnika.Size = new System.Drawing.Size(145, 25);
            this.txtPrezimeKorisnika.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "JMBAG";
            // 
            // txtJMBAG
            // 
            this.txtJMBAG.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.txtJMBAG.Location = new System.Drawing.Point(111, 24);
            this.txtJMBAG.Name = "txtJMBAG";
            this.txtJMBAG.Size = new System.Drawing.Size(145, 25);
            this.txtJMBAG.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-173, 208);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(895, 192);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // UnosKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(213)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(447, 318);
            this.Controls.Add(this.txtPrezimeKorisnika);
            this.Controls.Add(this.txtImeKorisnika);
            this.Controls.Add(this.txtJMBAG);
            this.Controls.Add(this.btnAddKorisnik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UnosKorisnika";
            this.Text = "UnosKorisnika";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddKorisnik;
        private System.Windows.Forms.TextBox txtImeKorisnika;
        private System.Windows.Forms.TextBox txtPrezimeKorisnika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtJMBAG;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}