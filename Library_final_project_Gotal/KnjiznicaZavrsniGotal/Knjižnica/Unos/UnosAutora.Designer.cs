namespace KnjiznicaZavrsniGotal.Knjižnica
{
    partial class UnosAutora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnosAutora));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddAutor = new System.Windows.Forms.Button();
            this.txtUnosImenaAutora = new System.Windows.Forms.TextBox();
            this.txtUnosPrezimenaAutora = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUpozorenjeAutor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.label2.Location = new System.Drawing.Point(20, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.label3.Location = new System.Drawing.Point(20, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prezime";
            // 
            // btnAddAutor
            // 
            this.btnAddAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.btnAddAutor.Location = new System.Drawing.Point(261, 212);
            this.btnAddAutor.Name = "btnAddAutor";
            this.btnAddAutor.Size = new System.Drawing.Size(157, 33);
            this.btnAddAutor.TabIndex = 3;
            this.btnAddAutor.Text = "Unesi autora";
            this.btnAddAutor.UseVisualStyleBackColor = true;
            this.btnAddAutor.Click += new System.EventHandler(this.BtnAddAutor_Click);
            // 
            // txtUnosImenaAutora
            // 
            this.txtUnosImenaAutora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.txtUnosImenaAutora.Location = new System.Drawing.Point(100, 29);
            this.txtUnosImenaAutora.Name = "txtUnosImenaAutora";
            this.txtUnosImenaAutora.Size = new System.Drawing.Size(128, 25);
            this.txtUnosImenaAutora.TabIndex = 4;
            // 
            // txtUnosPrezimenaAutora
            // 
            this.txtUnosPrezimenaAutora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.txtUnosPrezimenaAutora.Location = new System.Drawing.Point(100, 90);
            this.txtUnosPrezimenaAutora.Name = "txtUnosPrezimenaAutora";
            this.txtUnosPrezimenaAutora.Size = new System.Drawing.Size(128, 25);
            this.txtUnosPrezimenaAutora.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-185, 214);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(895, 192);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblUpozorenjeAutor
            // 
            this.lblUpozorenjeAutor.AutoSize = true;
            this.lblUpozorenjeAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblUpozorenjeAutor.Location = new System.Drawing.Point(258, 147);
            this.lblUpozorenjeAutor.Name = "lblUpozorenjeAutor";
            this.lblUpozorenjeAutor.Size = new System.Drawing.Size(133, 18);
            this.lblUpozorenjeAutor.TabIndex = 7;
            this.lblUpozorenjeAutor.Text = "Unesi sve podatke!";
            // 
            // UnosAutora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(213)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(447, 318);
            this.Controls.Add(this.lblUpozorenjeAutor);
            this.Controls.Add(this.txtUnosPrezimenaAutora);
            this.Controls.Add(this.txtUnosImenaAutora);
            this.Controls.Add(this.btnAddAutor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UnosAutora";
            this.Text = "UnosAutora";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddAutor;
        private System.Windows.Forms.TextBox txtUnosImenaAutora;
        private System.Windows.Forms.TextBox txtUnosPrezimenaAutora;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUpozorenjeAutor;
    }
}