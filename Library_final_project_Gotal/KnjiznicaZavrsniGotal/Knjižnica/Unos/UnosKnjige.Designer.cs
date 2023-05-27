namespace KnjiznicaZavrsniGotal
{
    partial class UnosKnjige
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnosKnjige));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDodajKnjigu = new System.Windows.Forms.Button();
            this.cmbZanr = new System.Windows.Forms.ComboBox();
            this.cmbAutor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numKnjiga = new System.Windows.Forms.NumericUpDown();
            this.txtNazivKnjige = new System.Windows.Forms.TextBox();
            this.lblMessageNazivKnjige = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numKnjiga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.label2.Location = new System.Drawing.Point(17, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Žanr";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.label3.Location = new System.Drawing.Point(17, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Količina";
            // 
            // btnDodajKnjigu
            // 
            this.btnDodajKnjigu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.btnDodajKnjigu.Location = new System.Drawing.Point(261, 212);
            this.btnDodajKnjigu.Name = "btnDodajKnjigu";
            this.btnDodajKnjigu.Size = new System.Drawing.Size(157, 33);
            this.btnDodajKnjigu.TabIndex = 4;
            this.btnDodajKnjigu.Text = "Dodaj knjigu";
            this.btnDodajKnjigu.UseVisualStyleBackColor = true;
            this.btnDodajKnjigu.Click += new System.EventHandler(this.BtnDodajKnjigu_Click);
            // 
            // cmbZanr
            // 
            this.cmbZanr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.cmbZanr.FormattingEnabled = true;
            this.cmbZanr.Location = new System.Drawing.Point(96, 82);
            this.cmbZanr.Name = "cmbZanr";
            this.cmbZanr.Size = new System.Drawing.Size(137, 28);
            this.cmbZanr.TabIndex = 6;
            // 
            // cmbAutor
            // 
            this.cmbAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.cmbAutor.FormattingEnabled = true;
            this.cmbAutor.Location = new System.Drawing.Point(96, 131);
            this.cmbAutor.Name = "cmbAutor";
            this.cmbAutor.Size = new System.Drawing.Size(137, 28);
            this.cmbAutor.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.label5.Location = new System.Drawing.Point(19, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Autor";
            // 
            // numKnjiga
            // 
            this.numKnjiga.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.numKnjiga.Location = new System.Drawing.Point(96, 182);
            this.numKnjiga.Name = "numKnjiga";
            this.numKnjiga.Size = new System.Drawing.Size(136, 25);
            this.numKnjiga.TabIndex = 10;
            // 
            // txtNazivKnjige
            // 
            this.txtNazivKnjige.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.txtNazivKnjige.Location = new System.Drawing.Point(96, 29);
            this.txtNazivKnjige.Name = "txtNazivKnjige";
            this.txtNazivKnjige.Size = new System.Drawing.Size(137, 25);
            this.txtNazivKnjige.TabIndex = 11;
            // 
            // lblMessageNazivKnjige
            // 
            this.lblMessageNazivKnjige.AutoSize = true;
            this.lblMessageNazivKnjige.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMessageNazivKnjige.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.lblMessageNazivKnjige.Location = new System.Drawing.Point(274, 116);
            this.lblMessageNazivKnjige.Name = "lblMessageNazivKnjige";
            this.lblMessageNazivKnjige.Size = new System.Drawing.Size(144, 20);
            this.lblMessageNazivKnjige.TabIndex = 12;
            this.lblMessageNazivKnjige.Text = "Unesi sve podatke!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(213)))), ((int)(((byte)(241)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-173, 212);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(895, 192);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // UnosKnjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(213)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(447, 318);
            this.Controls.Add(this.lblMessageNazivKnjige);
            this.Controls.Add(this.txtNazivKnjige);
            this.Controls.Add(this.numKnjiga);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbAutor);
            this.Controls.Add(this.cmbZanr);
            this.Controls.Add(this.btnDodajKnjigu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UnosKnjige";
            this.Text = "Unos nove knjige";
            ((System.ComponentModel.ISupportInitialize)(this.numKnjiga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDodajKnjigu;
        private System.Windows.Forms.ComboBox cmbZanr;
        private System.Windows.Forms.ComboBox cmbAutor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numKnjiga;
        private System.Windows.Forms.TextBox txtNazivKnjige;
        private System.Windows.Forms.Label lblMessageNazivKnjige;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

