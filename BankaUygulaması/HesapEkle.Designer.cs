namespace BankaUygulaması
{
    partial class frmHesapEkle
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
            this.lblMusteriNo = new System.Windows.Forms.Label();
            this.txtgirilenmn = new System.Windows.Forms.TextBox();
            this.btnHesapEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.datetmHesapAcılısTarihi = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMusteriNo
            // 
            this.lblMusteriNo.AutoSize = true;
            this.lblMusteriNo.Location = new System.Drawing.Point(98, 42);
            this.lblMusteriNo.Name = "lblMusteriNo";
            this.lblMusteriNo.Size = new System.Drawing.Size(195, 17);
            this.lblMusteriNo.TabIndex = 0;
            this.lblMusteriNo.Text = "Lütfen Musteri Nonuzu Giriniz";
            // 
            // txtgirilenmn
            // 
            this.txtgirilenmn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtgirilenmn.Location = new System.Drawing.Point(143, 74);
            this.txtgirilenmn.Name = "txtgirilenmn";
            this.txtgirilenmn.Size = new System.Drawing.Size(100, 22);
            this.txtgirilenmn.TabIndex = 2;
            // 
            // btnHesapEkle
            // 
            this.btnHesapEkle.BackColor = System.Drawing.SystemColors.Menu;
            this.btnHesapEkle.Location = new System.Drawing.Point(370, 140);
            this.btnHesapEkle.Name = "btnHesapEkle";
            this.btnHesapEkle.Size = new System.Drawing.Size(127, 45);
            this.btnHesapEkle.TabIndex = 3;
            this.btnHesapEkle.Text = "Hesap Ekle";
            this.btnHesapEkle.UseVisualStyleBackColor = false;
            this.btnHesapEkle.Click += new System.EventHandler(this.btnHesapEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(522, 205);
            this.dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hesap Açılış Tarihi";
            // 
            // datetmHesapAcılısTarihi
            // 
            this.datetmHesapAcılısTarihi.CalendarMonthBackground = System.Drawing.SystemColors.GradientInactiveCaption;
            this.datetmHesapAcılısTarihi.Location = new System.Drawing.Point(101, 163);
            this.datetmHesapAcılısTarihi.Name = "datetmHesapAcılısTarihi";
            this.datetmHesapAcılısTarihi.Size = new System.Drawing.Size(200, 22);
            this.datetmHesapAcılısTarihi.TabIndex = 6;
            // 
            // frmHesapEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(587, 450);
            this.Controls.Add(this.datetmHesapAcılısTarihi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnHesapEkle);
            this.Controls.Add(this.txtgirilenmn);
            this.Controls.Add(this.lblMusteriNo);
            this.Name = "frmHesapEkle";
            this.Text = "HesapEkle";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMusteriNo;
        private System.Windows.Forms.TextBox txtgirilenmn;
        private System.Windows.Forms.Button btnHesapEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datetmHesapAcılısTarihi;
    }
}