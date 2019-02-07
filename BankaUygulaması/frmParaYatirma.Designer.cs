namespace BankaUygulaması
{
    partial class frmParaYatirma
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
            this.lblHesapNo = new System.Windows.Forms.Label();
            this.lblYatirilacakMiktar = new System.Windows.Forms.Label();
            this.txtMusteriNo = new System.Windows.Forms.TextBox();
            this.txtHesapNo = new System.Windows.Forms.TextBox();
            this.txtYatirilacakMiktar = new System.Windows.Forms.TextBox();
            this.btnHesapGoster = new System.Windows.Forms.Button();
            this.btnParaYatir = new System.Windows.Forms.Button();
            this.dataGridViewHesapGoster = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHesapGoster)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMusteriNo
            // 
            this.lblMusteriNo.AutoSize = true;
            this.lblMusteriNo.Location = new System.Drawing.Point(40, 53);
            this.lblMusteriNo.Name = "lblMusteriNo";
            this.lblMusteriNo.Size = new System.Drawing.Size(155, 17);
            this.lblMusteriNo.TabIndex = 0;
            this.lblMusteriNo.Text = "Müşteri Nonuzu Giriniz:";
            // 
            // lblHesapNo
            // 
            this.lblHesapNo.AutoSize = true;
            this.lblHesapNo.Location = new System.Drawing.Point(40, 95);
            this.lblHesapNo.Name = "lblHesapNo";
            this.lblHesapNo.Size = new System.Drawing.Size(150, 17);
            this.lblHesapNo.TabIndex = 1;
            this.lblHesapNo.Text = "Hesap Nonuzu Giriniz:";
            // 
            // lblYatirilacakMiktar
            // 
            this.lblYatirilacakMiktar.AutoSize = true;
            this.lblYatirilacakMiktar.Location = new System.Drawing.Point(56, 158);
            this.lblYatirilacakMiktar.Name = "lblYatirilacakMiktar";
            this.lblYatirilacakMiktar.Size = new System.Drawing.Size(119, 17);
            this.lblYatirilacakMiktar.TabIndex = 2;
            this.lblYatirilacakMiktar.Text = "Yatirilacak Miktar:";
            this.lblYatirilacakMiktar.Visible = false;
            // 
            // txtMusteriNo
            // 
            this.txtMusteriNo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtMusteriNo.Location = new System.Drawing.Point(214, 48);
            this.txtMusteriNo.Name = "txtMusteriNo";
            this.txtMusteriNo.Size = new System.Drawing.Size(100, 22);
            this.txtMusteriNo.TabIndex = 3;
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtHesapNo.Location = new System.Drawing.Point(214, 90);
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.Size = new System.Drawing.Size(100, 22);
            this.txtHesapNo.TabIndex = 4;
            // 
            // txtYatirilacakMiktar
            // 
            this.txtYatirilacakMiktar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtYatirilacakMiktar.Location = new System.Drawing.Point(214, 153);
            this.txtYatirilacakMiktar.Name = "txtYatirilacakMiktar";
            this.txtYatirilacakMiktar.Size = new System.Drawing.Size(100, 22);
            this.txtYatirilacakMiktar.TabIndex = 5;
            this.txtYatirilacakMiktar.Visible = false;
            // 
            // btnHesapGoster
            // 
            this.btnHesapGoster.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnHesapGoster.Location = new System.Drawing.Point(335, 65);
            this.btnHesapGoster.Name = "btnHesapGoster";
            this.btnHesapGoster.Size = new System.Drawing.Size(106, 31);
            this.btnHesapGoster.TabIndex = 6;
            this.btnHesapGoster.Text = "Hesap Göster";
            this.btnHesapGoster.UseVisualStyleBackColor = false;
            this.btnHesapGoster.Click += new System.EventHandler(this.btnHesapGoster_Click);
            // 
            // btnParaYatir
            // 
            this.btnParaYatir.BackColor = System.Drawing.SystemColors.Info;
            this.btnParaYatir.Location = new System.Drawing.Point(335, 153);
            this.btnParaYatir.Name = "btnParaYatir";
            this.btnParaYatir.Size = new System.Drawing.Size(106, 34);
            this.btnParaYatir.TabIndex = 7;
            this.btnParaYatir.Text = "Para Yatır";
            this.btnParaYatir.UseVisualStyleBackColor = false;
            this.btnParaYatir.Visible = false;
            this.btnParaYatir.Click += new System.EventHandler(this.btnParaYatir_Click);
            // 
            // dataGridViewHesapGoster
            // 
            this.dataGridViewHesapGoster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHesapGoster.Location = new System.Drawing.Point(43, 205);
            this.dataGridViewHesapGoster.Name = "dataGridViewHesapGoster";
            this.dataGridViewHesapGoster.RowTemplate.Height = 24;
            this.dataGridViewHesapGoster.Size = new System.Drawing.Size(398, 150);
            this.dataGridViewHesapGoster.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Para yatırma işlemini gerçekleştirmek için bilgilerinizi giriniz.";
            // 
            // frmParaYatirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(473, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewHesapGoster);
            this.Controls.Add(this.btnParaYatir);
            this.Controls.Add(this.btnHesapGoster);
            this.Controls.Add(this.txtYatirilacakMiktar);
            this.Controls.Add(this.txtHesapNo);
            this.Controls.Add(this.txtMusteriNo);
            this.Controls.Add(this.lblYatirilacakMiktar);
            this.Controls.Add(this.lblHesapNo);
            this.Controls.Add(this.lblMusteriNo);
            this.Name = "frmParaYatirma";
            this.Text = "Para Yatirma";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHesapGoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMusteriNo;
        private System.Windows.Forms.Label lblHesapNo;
        private System.Windows.Forms.Label lblYatirilacakMiktar;
        private System.Windows.Forms.TextBox txtMusteriNo;
        private System.Windows.Forms.TextBox txtHesapNo;
        private System.Windows.Forms.TextBox txtYatirilacakMiktar;
        private System.Windows.Forms.Button btnHesapGoster;
        private System.Windows.Forms.Button btnParaYatir;
        private System.Windows.Forms.DataGridView dataGridViewHesapGoster;
        private System.Windows.Forms.Label label1;
    }
}