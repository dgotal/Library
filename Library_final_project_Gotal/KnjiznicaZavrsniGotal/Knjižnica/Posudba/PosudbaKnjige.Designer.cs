namespace KnjiznicaZavrsniGotal.Knjižnica
{
    partial class PosudbaKnjige
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PosudbaKnjige));
            this.lblKorisnik = new System.Windows.Forms.Label();
            this.btnPosudi = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ibCamera = new Emgu.CV.UI.ImageBox();
            this.cmbKorisnik = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnProvjeri = new System.Windows.Forms.Button();
            this.btnVrati = new System.Windows.Forms.Button();
            this.txtZakasnina = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPlati = new System.Windows.Forms.Button();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.ibCamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKorisnik
            // 
            this.lblKorisnik.AutoSize = true;
            this.lblKorisnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.lblKorisnik.Location = new System.Drawing.Point(424, 20);
            this.lblKorisnik.Name = "lblKorisnik";
            this.lblKorisnik.Size = new System.Drawing.Size(68, 20);
            this.lblKorisnik.TabIndex = 2;
            this.lblKorisnik.Text = "Korisnik:";
            // 
            // btnPosudi
            // 
            this.btnPosudi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.btnPosudi.Location = new System.Drawing.Point(550, 370);
            this.btnPosudi.Name = "btnPosudi";
            this.btnPosudi.Size = new System.Drawing.Size(79, 30);
            this.btnPosudi.TabIndex = 5;
            this.btnPosudi.Text = "Posudi";
            this.btnPosudi.UseVisualStyleBackColor = true;
            this.btnPosudi.Click += new System.EventHandler(this.btnPosudi_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.btnStart.Location = new System.Drawing.Point(150, 313);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(82, 31);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Skeniraj";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ibCamera
            // 
            this.ibCamera.BackColor = System.Drawing.Color.Silver;
            this.ibCamera.Location = new System.Drawing.Point(11, 20);
            this.ibCamera.Name = "ibCamera";
            this.ibCamera.Size = new System.Drawing.Size(388, 266);
            this.ibCamera.TabIndex = 2;
            this.ibCamera.TabStop = false;
            // 
            // cmbKorisnik
            // 
            this.cmbKorisnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.cmbKorisnik.FormattingEnabled = true;
            this.cmbKorisnik.Location = new System.Drawing.Point(416, 59);
            this.cmbKorisnik.Name = "cmbKorisnik";
            this.cmbKorisnik.Size = new System.Drawing.Size(210, 28);
            this.cmbKorisnik.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.textBox2.Location = new System.Drawing.Point(416, 154);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(210, 25);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.NoviQRID);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.label1.Location = new System.Drawing.Point(412, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID Knjige";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.label2.Location = new System.Drawing.Point(412, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Naziv knjige";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.textBox3.Location = new System.Drawing.Point(416, 245);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(210, 25);
            this.textBox3.TabIndex = 10;
            // 
            // btnProvjeri
            // 
            this.btnProvjeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.btnProvjeri.Location = new System.Drawing.Point(416, 314);
            this.btnProvjeri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProvjeri.Name = "btnProvjeri";
            this.btnProvjeri.Size = new System.Drawing.Size(102, 30);
            this.btnProvjeri.TabIndex = 11;
            this.btnProvjeri.Text = "Provjeri";
            this.btnProvjeri.UseVisualStyleBackColor = true;
            this.btnProvjeri.Click += new System.EventHandler(this.btnProvjeri_Click);
            // 
            // btnVrati
            // 
            this.btnVrati.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.btnVrati.Location = new System.Drawing.Point(550, 314);
            this.btnVrati.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVrati.Name = "btnVrati";
            this.btnVrati.Size = new System.Drawing.Size(75, 30);
            this.btnVrati.TabIndex = 12;
            this.btnVrati.Text = "Vrati";
            this.btnVrati.UseVisualStyleBackColor = true;
            this.btnVrati.Click += new System.EventHandler(this.btnVrati_Click);
            // 
            // txtZakasnina
            // 
            this.txtZakasnina.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.txtZakasnina.Location = new System.Drawing.Point(104, 375);
            this.txtZakasnina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtZakasnina.Name = "txtZakasnina";
            this.txtZakasnina.Size = new System.Drawing.Size(83, 25);
            this.txtZakasnina.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.label3.Location = new System.Drawing.Point(8, 375);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Zakasnina";
            // 
            // btnPlati
            // 
            this.btnPlati.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.btnPlati.Location = new System.Drawing.Point(217, 375);
            this.btnPlati.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPlati.Name = "btnPlati";
            this.btnPlati.Size = new System.Drawing.Size(70, 24);
            this.btnPlati.TabIndex = 15;
            this.btnPlati.Text = "Plati";
            this.btnPlati.UseVisualStyleBackColor = true;
            this.btnPlati.Click += new System.EventHandler(this.btnPlati_Click);
            // 
            // imageBox1
            // 
            this.imageBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imageBox1.BackgroundImage")));
            this.imageBox1.Location = new System.Drawing.Point(634, -6);
            this.imageBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(226, 501);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // PosudbaKnjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(213)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(848, 443);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.btnPlati);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtZakasnina);
            this.Controls.Add(this.btnVrati);
            this.Controls.Add(this.btnProvjeri);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ibCamera);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnPosudi);
            this.Controls.Add(this.lblKorisnik);
            this.Controls.Add(this.cmbKorisnik);
            this.Name = "PosudbaKnjige";
            this.Text = "PosudbaKnjige";
            ((System.ComponentModel.ISupportInitialize)(this.ibCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblKorisnik;
        private System.Windows.Forms.Button btnPosudi;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ImageList imageList1;
        private Emgu.CV.UI.ImageBox ibCamera;
        private System.Windows.Forms.ComboBox cmbKorisnik;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnProvjeri;
        private System.Windows.Forms.Button btnVrati;
        private System.Windows.Forms.TextBox txtZakasnina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPlati;
        private Emgu.CV.UI.ImageBox imageBox1;
    }
}