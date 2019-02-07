namespace BankaUygulaması
{
    partial class frmHesapKapatma
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMusteriNo = new System.Windows.Forms.TextBox();
            this.txtHesapNo = new System.Windows.Forms.TextBox();
            this.btnHesapGoster = new System.Windows.Forms.Button();
            this.lblKapat = new System.Windows.Forms.Label();
            this.dataGridViewKapatılacakHesabıGörüntüle = new System.Windows.Forms.DataGridView();
            this.btnHesabıKapat = new System.Windows.Forms.Button();
            this.dataGridViewKapatildi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKapatılacakHesabıGörüntüle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKapatildi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Nonuzu Giriniz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kapatılacak Hesap No:";
            // 
            // txtMusteriNo
            // 
            this.txtMusteriNo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtMusteriNo.Location = new System.Drawing.Point(220, 57);
            this.txtMusteriNo.Name = "txtMusteriNo";
            this.txtMusteriNo.Size = new System.Drawing.Size(100, 22);
            this.txtMusteriNo.TabIndex = 2;
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtHesapNo.Location = new System.Drawing.Point(220, 93);
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.Size = new System.Drawing.Size(100, 22);
            this.txtHesapNo.TabIndex = 3;
            // 
            // btnHesapGoster
            // 
            this.btnHesapGoster.BackColor = System.Drawing.SystemColors.Info;
            this.btnHesapGoster.Location = new System.Drawing.Point(358, 70);
            this.btnHesapGoster.Name = "btnHesapGoster";
            this.btnHesapGoster.Size = new System.Drawing.Size(108, 45);
            this.btnHesapGoster.TabIndex = 4;
            this.btnHesapGoster.Text = "Hesap Göster";
            this.btnHesapGoster.UseVisualStyleBackColor = false;
            this.btnHesapGoster.Click += new System.EventHandler(this.btnHesapGoster_Click);
            // 
            // lblKapat
            // 
            this.lblKapat.AutoSize = true;
            this.lblKapat.Location = new System.Drawing.Point(65, 275);
            this.lblKapat.Name = "lblKapat";
            this.lblKapat.Size = new System.Drawing.Size(295, 17);
            this.lblKapat.TabIndex = 5;
            this.lblKapat.Text = "Bu Hesabı Kapatmak İstediğinize Emin Misiniz";
            this.lblKapat.Visible = false;
            // 
            // dataGridViewKapatılacakHesabıGörüntüle
            // 
            this.dataGridViewKapatılacakHesabıGörüntüle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKapatılacakHesabıGörüntüle.Location = new System.Drawing.Point(15, 135);
            this.dataGridViewKapatılacakHesabıGörüntüle.Name = "dataGridViewKapatılacakHesabıGörüntüle";
            this.dataGridViewKapatılacakHesabıGörüntüle.RowTemplate.Height = 24;
            this.dataGridViewKapatılacakHesabıGörüntüle.Size = new System.Drawing.Size(451, 123);
            this.dataGridViewKapatılacakHesabıGörüntüle.TabIndex = 6;
            // 
            // btnHesabıKapat
            // 
            this.btnHesabıKapat.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnHesabıKapat.Location = new System.Drawing.Point(159, 300);
            this.btnHesabıKapat.Name = "btnHesabıKapat";
            this.btnHesabıKapat.Size = new System.Drawing.Size(137, 49);
            this.btnHesabıKapat.TabIndex = 7;
            this.btnHesabıKapat.Text = "Hesap Kapat";
            this.btnHesabıKapat.UseVisualStyleBackColor = false;
            this.btnHesabıKapat.Visible = false;
            this.btnHesabıKapat.Click += new System.EventHandler(this.btnHesabıKapat_Click);
            // 
            // dataGridViewKapatildi
            // 
            this.dataGridViewKapatildi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKapatildi.Location = new System.Drawing.Point(15, 355);
            this.dataGridViewKapatildi.Name = "dataGridViewKapatildi";
            this.dataGridViewKapatildi.RowTemplate.Height = 24;
            this.dataGridViewKapatildi.Size = new System.Drawing.Size(451, 160);
            this.dataGridViewKapatildi.TabIndex = 8;
            this.dataGridViewKapatildi.Visible = false;
            // 
            // frmHesapKapatma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(650, 540);
            this.Controls.Add(this.dataGridViewKapatildi);
            this.Controls.Add(this.btnHesabıKapat);
            this.Controls.Add(this.dataGridViewKapatılacakHesabıGörüntüle);
            this.Controls.Add(this.lblKapat);
            this.Controls.Add(this.btnHesapGoster);
            this.Controls.Add(this.txtHesapNo);
            this.Controls.Add(this.txtMusteriNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmHesapKapatma";
            this.Text = "frmHesapKapatma";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKapatılacakHesabıGörüntüle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKapatildi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMusteriNo;
        private System.Windows.Forms.TextBox txtHesapNo;
        private System.Windows.Forms.Button btnHesapGoster;
        private System.Windows.Forms.Label lblKapat;
        private System.Windows.Forms.DataGridView dataGridViewKapatılacakHesabıGörüntüle;
        private System.Windows.Forms.Button btnHesabıKapat;
        private System.Windows.Forms.DataGridView dataGridViewKapatildi;
    }
}