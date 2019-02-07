namespace BankaUygulaması
{
    partial class frmHesapÖzeti
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
            this.btnHesapOzetiGoster = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblBaslangıçTarihi = new System.Windows.Forms.Label();
            this.txtMusteriNo = new System.Windows.Forms.TextBox();
            this.txtHesapNo = new System.Windows.Forms.TextBox();
            this.lblBitisTarihi = new System.Windows.Forms.Label();
            this.dtmBaslangıçTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtmBitişTarihi = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewHesapOzetiGoster = new System.Windows.Forms.DataGridView();
            this.btnHesapBul = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHesapOzetiGoster)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHesapOzetiGoster
            // 
            this.btnHesapOzetiGoster.BackColor = System.Drawing.SystemColors.Info;
            this.btnHesapOzetiGoster.Location = new System.Drawing.Point(390, 162);
            this.btnHesapOzetiGoster.Name = "btnHesapOzetiGoster";
            this.btnHesapOzetiGoster.Size = new System.Drawing.Size(136, 48);
            this.btnHesapOzetiGoster.TabIndex = 0;
            this.btnHesapOzetiGoster.Text = "Hesap Özeti Göster";
            this.btnHesapOzetiGoster.UseVisualStyleBackColor = false;
            this.btnHesapOzetiGoster.Visible = false;
            this.btnHesapOzetiGoster.Click += new System.EventHandler(this.btnHesapOzetiGoster_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lutfen Müşteri Nonuzu Giriniz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lutfen Hesap Nonuzu Giriniz:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(31, 122);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(361, 17);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Hesap Özetini Görmek İstediğiniz Tarih Aralığını Seçiniz:";
            this.lbl1.Visible = false;
            // 
            // lblBaslangıçTarihi
            // 
            this.lblBaslangıçTarihi.AutoSize = true;
            this.lblBaslangıçTarihi.Location = new System.Drawing.Point(34, 156);
            this.lblBaslangıçTarihi.Name = "lblBaslangıçTarihi";
            this.lblBaslangıçTarihi.Size = new System.Drawing.Size(113, 17);
            this.lblBaslangıçTarihi.TabIndex = 4;
            this.lblBaslangıçTarihi.Text = "Başlangıç Tarihi:";
            this.lblBaslangıçTarihi.Visible = false;
            // 
            // txtMusteriNo
            // 
            this.txtMusteriNo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtMusteriNo.Location = new System.Drawing.Point(236, 34);
            this.txtMusteriNo.Name = "txtMusteriNo";
            this.txtMusteriNo.Size = new System.Drawing.Size(100, 22);
            this.txtMusteriNo.TabIndex = 5;
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtHesapNo.Location = new System.Drawing.Point(236, 71);
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.Size = new System.Drawing.Size(100, 22);
            this.txtHesapNo.TabIndex = 6;
            // 
            // lblBitisTarihi
            // 
            this.lblBitisTarihi.AutoSize = true;
            this.lblBitisTarihi.Location = new System.Drawing.Point(37, 188);
            this.lblBitisTarihi.Name = "lblBitisTarihi";
            this.lblBitisTarihi.Size = new System.Drawing.Size(78, 17);
            this.lblBitisTarihi.TabIndex = 7;
            this.lblBitisTarihi.Text = "Bitiş Tarihi:";
            this.lblBitisTarihi.Visible = false;
            // 
            // dtmBaslangıçTarihi
            // 
            this.dtmBaslangıçTarihi.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.dtmBaslangıçTarihi.Location = new System.Drawing.Point(165, 156);
            this.dtmBaslangıçTarihi.Name = "dtmBaslangıçTarihi";
            this.dtmBaslangıçTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtmBaslangıçTarihi.TabIndex = 8;
            this.dtmBaslangıçTarihi.Visible = false;
            // 
            // dtmBitişTarihi
            // 
            this.dtmBitişTarihi.Location = new System.Drawing.Point(165, 188);
            this.dtmBitişTarihi.Name = "dtmBitişTarihi";
            this.dtmBitişTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtmBitişTarihi.TabIndex = 9;
            this.dtmBitişTarihi.Visible = false;
            // 
            // dataGridViewHesapOzetiGoster
            // 
            this.dataGridViewHesapOzetiGoster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHesapOzetiGoster.Location = new System.Drawing.Point(34, 231);
            this.dataGridViewHesapOzetiGoster.Name = "dataGridViewHesapOzetiGoster";
            this.dataGridViewHesapOzetiGoster.RowTemplate.Height = 24;
            this.dataGridViewHesapOzetiGoster.Size = new System.Drawing.Size(486, 181);
            this.dataGridViewHesapOzetiGoster.TabIndex = 10;
            // 
            // btnHesapBul
            // 
            this.btnHesapBul.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnHesapBul.Location = new System.Drawing.Point(390, 49);
            this.btnHesapBul.Name = "btnHesapBul";
            this.btnHesapBul.Size = new System.Drawing.Size(94, 42);
            this.btnHesapBul.TabIndex = 11;
            this.btnHesapBul.Text = "Hesabı Bul";
            this.btnHesapBul.UseVisualStyleBackColor = false;
            this.btnHesapBul.Click += new System.EventHandler(this.btnHesapBul_Click);
            // 
            // frmHesapÖzeti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(538, 424);
            this.Controls.Add(this.btnHesapBul);
            this.Controls.Add(this.dataGridViewHesapOzetiGoster);
            this.Controls.Add(this.dtmBitişTarihi);
            this.Controls.Add(this.dtmBaslangıçTarihi);
            this.Controls.Add(this.lblBitisTarihi);
            this.Controls.Add(this.txtHesapNo);
            this.Controls.Add(this.txtMusteriNo);
            this.Controls.Add(this.lblBaslangıçTarihi);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHesapOzetiGoster);
            this.Name = "frmHesapÖzeti";
            this.Text = "HesapÖzeti";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHesapOzetiGoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHesapOzetiGoster;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblBaslangıçTarihi;
        private System.Windows.Forms.TextBox txtMusteriNo;
        private System.Windows.Forms.TextBox txtHesapNo;
        private System.Windows.Forms.Label lblBitisTarihi;
        private System.Windows.Forms.DateTimePicker dtmBaslangıçTarihi;
        private System.Windows.Forms.DateTimePicker dtmBitişTarihi;
        private System.Windows.Forms.DataGridView dataGridViewHesapOzetiGoster;
        private System.Windows.Forms.Button btnHesapBul;
    }
}