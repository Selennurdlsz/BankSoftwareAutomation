namespace BankaUygulaması
{
    partial class frmHesapIslemleri
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
            this.btnParaCek = new System.Windows.Forms.Button();
            this.btnParaYatırma = new System.Windows.Forms.Button();
            this.btnHavaleYapma = new System.Windows.Forms.Button();
            this.btnHesapKapat = new System.Windows.Forms.Button();
            this.btnHesapOzeti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnParaCek
            // 
            this.btnParaCek.BackColor = System.Drawing.SystemColors.Info;
            this.btnParaCek.Location = new System.Drawing.Point(102, 85);
            this.btnParaCek.Name = "btnParaCek";
            this.btnParaCek.Size = new System.Drawing.Size(136, 56);
            this.btnParaCek.TabIndex = 0;
            this.btnParaCek.Text = "Para Çekme";
            this.btnParaCek.UseVisualStyleBackColor = false;
            this.btnParaCek.Click += new System.EventHandler(this.btnParaCek_Click);
            // 
            // btnParaYatırma
            // 
            this.btnParaYatırma.BackColor = System.Drawing.SystemColors.Info;
            this.btnParaYatırma.Location = new System.Drawing.Point(266, 85);
            this.btnParaYatırma.Name = "btnParaYatırma";
            this.btnParaYatırma.Size = new System.Drawing.Size(143, 56);
            this.btnParaYatırma.TabIndex = 1;
            this.btnParaYatırma.Text = "Para Yatırma";
            this.btnParaYatırma.UseVisualStyleBackColor = false;
            this.btnParaYatırma.Click += new System.EventHandler(this.btnParaYatırma_Click);
            // 
            // btnHavaleYapma
            // 
            this.btnHavaleYapma.BackColor = System.Drawing.SystemColors.Info;
            this.btnHavaleYapma.Location = new System.Drawing.Point(432, 85);
            this.btnHavaleYapma.Name = "btnHavaleYapma";
            this.btnHavaleYapma.Size = new System.Drawing.Size(143, 55);
            this.btnHavaleYapma.TabIndex = 2;
            this.btnHavaleYapma.Text = "Havale Yapma";
            this.btnHavaleYapma.UseVisualStyleBackColor = false;
            this.btnHavaleYapma.Click += new System.EventHandler(this.btnHavaleYapma_Click);
            // 
            // btnHesapKapat
            // 
            this.btnHesapKapat.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnHesapKapat.Location = new System.Drawing.Point(266, 278);
            this.btnHesapKapat.Name = "btnHesapKapat";
            this.btnHesapKapat.Size = new System.Drawing.Size(143, 54);
            this.btnHesapKapat.TabIndex = 3;
            this.btnHesapKapat.Text = "Hesap Kapat";
            this.btnHesapKapat.UseVisualStyleBackColor = false;
            this.btnHesapKapat.Click += new System.EventHandler(this.btnHesapKapat_Click);
            // 
            // btnHesapOzeti
            // 
            this.btnHesapOzeti.BackColor = System.Drawing.SystemColors.Menu;
            this.btnHesapOzeti.Location = new System.Drawing.Point(221, 186);
            this.btnHesapOzeti.Name = "btnHesapOzeti";
            this.btnHesapOzeti.Size = new System.Drawing.Size(230, 51);
            this.btnHesapOzeti.TabIndex = 4;
            this.btnHesapOzeti.Text = "Hesap Özeti";
            this.btnHesapOzeti.UseVisualStyleBackColor = false;
            this.btnHesapOzeti.Click += new System.EventHandler(this.btnHesapOzeti_Click);
            // 
            // frmHesapIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(656, 489);
            this.Controls.Add(this.btnHesapOzeti);
            this.Controls.Add(this.btnHesapKapat);
            this.Controls.Add(this.btnHavaleYapma);
            this.Controls.Add(this.btnParaYatırma);
            this.Controls.Add(this.btnParaCek);
            this.Name = "frmHesapIslemleri";
            this.Text = "HesapIslemleri";
            this.Load += new System.EventHandler(this.btnParaYatırma_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnParaCek;
        private System.Windows.Forms.Button btnParaYatırma;
        private System.Windows.Forms.Button btnHavaleYapma;
        private System.Windows.Forms.Button btnHesapKapat;
        private System.Windows.Forms.Button btnHesapOzeti;
    }
}