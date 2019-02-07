namespace BankaUygulaması
{
    partial class frmMusteriBilgileri
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
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.btnHesapEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.BackColor = System.Drawing.SystemColors.Info;
            this.btnMusteriEkle.Location = new System.Drawing.Point(168, 83);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(178, 57);
            this.btnMusteriEkle.TabIndex = 0;
            this.btnMusteriEkle.Text = "Musteri Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = false;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // btnHesapEkle
            // 
            this.btnHesapEkle.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnHesapEkle.Location = new System.Drawing.Point(168, 190);
            this.btnHesapEkle.Name = "btnHesapEkle";
            this.btnHesapEkle.Size = new System.Drawing.Size(178, 56);
            this.btnHesapEkle.TabIndex = 1;
            this.btnHesapEkle.Text = "Hesap Ekle";
            this.btnHesapEkle.UseVisualStyleBackColor = false;
            this.btnHesapEkle.Click += new System.EventHandler(this.btnHesapEkle_Click);
            // 
            // frmMusteriBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(520, 328);
            this.Controls.Add(this.btnHesapEkle);
            this.Controls.Add(this.btnMusteriEkle);
            this.Name = "frmMusteriBilgileri";
            this.Text = "MusteriBilgileri";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.Button btnHesapEkle;
    }
}