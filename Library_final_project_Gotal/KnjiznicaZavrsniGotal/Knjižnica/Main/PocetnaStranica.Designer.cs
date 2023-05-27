namespace KnjiznicaZavrsniGotal.Knjižnica
{
    partial class PocetnaStranica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PocetnaStranica));
            this.btnPosudba = new System.Windows.Forms.Button();
            this.btnUnos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPosudba
            // 
            this.btnPosudba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPosudba.Font = new System.Drawing.Font("Sitka Small", 26.2F, System.Drawing.FontStyle.Bold);
            this.btnPosudba.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPosudba.Location = new System.Drawing.Point(82, 107);
            this.btnPosudba.Margin = new System.Windows.Forms.Padding(0);
            this.btnPosudba.Name = "btnPosudba";
            this.btnPosudba.Size = new System.Drawing.Size(293, 193);
            this.btnPosudba.TabIndex = 0;
            this.btnPosudba.Text = "POSUDBA VRAČANJE";
            this.btnPosudba.UseVisualStyleBackColor = false;
            this.btnPosudba.Click += new System.EventHandler(this.BtnPosudba_Click);
            // 
            // btnUnos
            // 
            this.btnUnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUnos.Font = new System.Drawing.Font("Sitka Small", 26.2F, System.Drawing.FontStyle.Bold);
            this.btnUnos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUnos.Location = new System.Drawing.Point(434, 107);
            this.btnUnos.Margin = new System.Windows.Forms.Padding(0);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(287, 193);
            this.btnUnos.TabIndex = 1;
            this.btnUnos.Text = "UNOS";
            this.btnUnos.UseVisualStyleBackColor = false;
            this.btnUnos.Click += new System.EventHandler(this.BtnUnos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(213)))), ((int)(((byte)(241)))));
            this.label1.Font = new System.Drawing.Font("Sitka Small", 27.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(37, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dobrodošli u našu knjižnicu \"ELPROS\"";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-28, 303);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(895, 192);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // PocetnaStranica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(213)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(828, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.btnPosudba);
            this.Name = "PocetnaStranica";
            this.Text = "PocetnaStranica";
            this.Load += new System.EventHandler(this.PocetnaStranica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPosudba;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}