namespace BankaUygulaması
{
    partial class frmMusteriEkle
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
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTCKimlikNo = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblTCKimlikNo = new System.Windows.Forms.Label();
            this.lblMusteriTipi = new System.Windows.Forms.Label();
            this.cmboxMusteriTipi = new System.Windows.Forms.ComboBox();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.dataGridViewmusteri = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmusteri)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtAd.Location = new System.Drawing.Point(189, 43);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 22);
            this.txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            this.txtSoyad.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSoyad.Location = new System.Drawing.Point(189, 91);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtTCKimlikNo
            // 
            this.txtTCKimlikNo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTCKimlikNo.Location = new System.Drawing.Point(189, 135);
            this.txtTCKimlikNo.Name = "txtTCKimlikNo";
            this.txtTCKimlikNo.Size = new System.Drawing.Size(100, 22);
            this.txtTCKimlikNo.TabIndex = 2;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(111, 48);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(56, 17);
            this.lblAd.TabIndex = 5;
            this.lblAd.Text = "ADINIZ:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(82, 96);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(85, 17);
            this.lblSoyad.TabIndex = 6;
            this.lblSoyad.Text = "SOYADINIZ:";
            // 
            // lblTCKimlikNo
            // 
            this.lblTCKimlikNo.AutoSize = true;
            this.lblTCKimlikNo.Location = new System.Drawing.Point(69, 140);
            this.lblTCKimlikNo.Name = "lblTCKimlikNo";
            this.lblTCKimlikNo.Size = new System.Drawing.Size(98, 17);
            this.lblTCKimlikNo.TabIndex = 7;
            this.lblTCKimlikNo.Text = "TC KİMLİK NO";
            // 
            // lblMusteriTipi
            // 
            this.lblMusteriTipi.AutoSize = true;
            this.lblMusteriTipi.Location = new System.Drawing.Point(86, 188);
            this.lblMusteriTipi.Name = "lblMusteriTipi";
            this.lblMusteriTipi.Size = new System.Drawing.Size(81, 17);
            this.lblMusteriTipi.TabIndex = 8;
            this.lblMusteriTipi.Text = "Musteri Tipi";
            // 
            // cmboxMusteriTipi
            // 
            this.cmboxMusteriTipi.BackColor = System.Drawing.SystemColors.Info;
            this.cmboxMusteriTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxMusteriTipi.FormattingEnabled = true;
            this.cmboxMusteriTipi.Items.AddRange(new object[] {
            "Bireysel Müsteri",
            "Ticari Müsteri"});
            this.cmboxMusteriTipi.Location = new System.Drawing.Point(189, 181);
            this.cmboxMusteriTipi.Name = "cmboxMusteriTipi";
            this.cmboxMusteriTipi.Size = new System.Drawing.Size(121, 24);
            this.cmboxMusteriTipi.TabIndex = 10;
            this.cmboxMusteriTipi.SelectedIndexChanged += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.BackColor = System.Drawing.SystemColors.Info;
            this.btnMusteriEkle.Location = new System.Drawing.Point(354, 148);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(123, 64);
            this.btnMusteriEkle.TabIndex = 11;
            this.btnMusteriEkle.Text = "Musteri Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = false;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // dataGridViewmusteri
            // 
            this.dataGridViewmusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewmusteri.Location = new System.Drawing.Point(25, 233);
            this.dataGridViewmusteri.Name = "dataGridViewmusteri";
            this.dataGridViewmusteri.RowTemplate.Height = 24;
            this.dataGridViewmusteri.Size = new System.Drawing.Size(532, 191);
            this.dataGridViewmusteri.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Lütfen bilgilerinizi doğru ve eksiksiz biçimde giriniz.";
            // 
            // frmMusteriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(581, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewmusteri);
            this.Controls.Add(this.btnMusteriEkle);
            this.Controls.Add(this.cmboxMusteriTipi);
            this.Controls.Add(this.lblMusteriTipi);
            this.Controls.Add(this.lblTCKimlikNo);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.txtTCKimlikNo);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Name = "frmMusteriEkle";
            this.Text = "MusteriEkle";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmusteri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtTCKimlikNo;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblTCKimlikNo;
        private System.Windows.Forms.Label lblMusteriTipi;
        private System.Windows.Forms.ComboBox cmboxMusteriTipi;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.DataGridView dataGridViewmusteri;
        private System.Windows.Forms.Label label1;
    }
}