namespace KnjiznicaZavrsniGotal.Knjižnica
{
    partial class UnosZanra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnosZanra));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNazivZanra = new System.Windows.Forms.TextBox();
            this.btnAddZanr = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUpozorenjeZanr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.label1.Location = new System.Drawing.Point(10, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv žanra";
            // 
            // txtNazivZanra
            // 
            this.txtNazivZanra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtNazivZanra.Location = new System.Drawing.Point(111, 34);
            this.txtNazivZanra.Name = "txtNazivZanra";
            this.txtNazivZanra.Size = new System.Drawing.Size(126, 24);
            this.txtNazivZanra.TabIndex = 1;
            // 
            // btnAddZanr
            // 
            this.btnAddZanr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.btnAddZanr.Location = new System.Drawing.Point(261, 212);
            this.btnAddZanr.Name = "btnAddZanr";
            this.btnAddZanr.Size = new System.Drawing.Size(157, 33);
            this.btnAddZanr.TabIndex = 2;
            this.btnAddZanr.Text = "Dodaj žanr";
            this.btnAddZanr.UseVisualStyleBackColor = true;
            this.btnAddZanr.Click += new System.EventHandler(this.BtnAddZanr_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(213)))), ((int)(((byte)(241)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-257, 207);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(895, 192);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblUpozorenjeZanr
            // 
            this.lblUpozorenjeZanr.AutoSize = true;
            this.lblUpozorenjeZanr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblUpozorenjeZanr.Location = new System.Drawing.Point(227, 121);
            this.lblUpozorenjeZanr.Name = "lblUpozorenjeZanr";
            this.lblUpozorenjeZanr.Size = new System.Drawing.Size(133, 18);
            this.lblUpozorenjeZanr.TabIndex = 8;
            this.lblUpozorenjeZanr.Text = "Unesi sve podatke!";
            // 
            // UnosZanra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(213)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(447, 318);
            this.Controls.Add(this.lblUpozorenjeZanr);
            this.Controls.Add(this.btnAddZanr);
            this.Controls.Add(this.txtNazivZanra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UnosZanra";
            this.Text = "UnosZanra";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNazivZanra;
        private System.Windows.Forms.Button btnAddZanr;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUpozorenjeZanr;
    }
}