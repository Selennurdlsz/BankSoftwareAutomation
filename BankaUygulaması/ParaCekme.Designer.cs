namespace BankaUygulaması
{
    partial class frmParaCekme
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
            this.txtMusteriNo = new System.Windows.Forms.TextBox();
            this.txtHesapNo = new System.Windows.Forms.TextBox();
            this.txtCekilcekMiktar = new System.Windows.Forms.TextBox();
            this.lblMusteriNo = new System.Windows.Forms.Label();
            this.lblHesapNo = new System.Windows.Forms.Label();
            this.lblCekilcekMiktar = new System.Windows.Forms.Label();
            this.btnHesapGoster = new System.Windows.Forms.Button();
            this.btnParaCek = new System.Windows.Forms.Button();
            this.dataGridViewHesapGoster = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHesapGoster)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMusteriNo
            // 
            this.txtMusteriNo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtMusteriNo.Location = new System.Drawing.Point(223, 53);
            this.txtMusteriNo.Name = "txtMusteriNo";
            this.txtMusteriNo.Size = new System.Drawing.Size(100, 22);
            this.txtMusteriNo.TabIndex = 0;
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtHesapNo.Location = new System.Drawing.Point(223, 101);
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.Size = new System.Drawing.Size(100, 22);
            this.txtHesapNo.TabIndex = 1;
            // 
            // txtCekilcekMiktar
            // 
            this.txtCekilcekMiktar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtCekilcekMiktar.Location = new System.Drawing.Point(223, 170);
            this.txtCekilcekMiktar.Name = "txtCekilcekMiktar";
            this.txtCekilcekMiktar.Size = new System.Drawing.Size(100, 22);
            this.txtCekilcekMiktar.TabIndex = 2;
            this.txtCekilcekMiktar.Visible = false;
            // 
            // lblMusteriNo
            // 
            this.lblMusteriNo.AutoSize = true;
            this.lblMusteriNo.Location = new System.Drawing.Point(41, 58);
            this.lblMusteriNo.Name = "lblMusteriNo";
            this.lblMusteriNo.Size = new System.Drawing.Size(155, 17);
            this.lblMusteriNo.TabIndex = 3;
            this.lblMusteriNo.Text = "Müşteri Nonuzu Giriniz:";
            // 
            // lblHesapNo
            // 
            this.lblHesapNo.AutoSize = true;
            this.lblHesapNo.Location = new System.Drawing.Point(41, 106);
            this.lblHesapNo.Name = "lblHesapNo";
            this.lblHesapNo.Size = new System.Drawing.Size(150, 17);
            this.lblHesapNo.TabIndex = 4;
            this.lblHesapNo.Text = "Hesap Nonuzu Giriniz:";
            // 
            // lblCekilcekMiktar
            // 
            this.lblCekilcekMiktar.AutoSize = true;
            this.lblCekilcekMiktar.Location = new System.Drawing.Point(41, 175);
            this.lblCekilcekMiktar.Name = "lblCekilcekMiktar";
            this.lblCekilcekMiktar.Size = new System.Drawing.Size(160, 17);
            this.lblCekilcekMiktar.TabIndex = 5;
            this.lblCekilcekMiktar.Text = "Çekilmek İstenen Miktar:";
            this.lblCekilcekMiktar.Visible = false;
            // 
            // btnHesapGoster
            // 
            this.btnHesapGoster.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnHesapGoster.Location = new System.Drawing.Point(373, 71);
            this.btnHesapGoster.Name = "btnHesapGoster";
            this.btnHesapGoster.Size = new System.Drawing.Size(117, 34);
            this.btnHesapGoster.TabIndex = 6;
            this.btnHesapGoster.Text = "Hesap Göster";
            this.btnHesapGoster.UseVisualStyleBackColor = false;
            this.btnHesapGoster.Click += new System.EventHandler(this.btnHesapGoster_Click);
            // 
            // btnParaCek
            // 
            this.btnParaCek.BackColor = System.Drawing.SystemColors.Info;
            this.btnParaCek.Location = new System.Drawing.Point(373, 155);
            this.btnParaCek.Name = "btnParaCek";
            this.btnParaCek.Size = new System.Drawing.Size(117, 37);
            this.btnParaCek.TabIndex = 7;
            this.btnParaCek.Text = "Para Çek";
            this.btnParaCek.UseVisualStyleBackColor = false;
            this.btnParaCek.Visible = false;
            this.btnParaCek.Click += new System.EventHandler(this.btnParaCek_Click);
            // 
            // dataGridViewHesapGoster
            // 
            this.dataGridViewHesapGoster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHesapGoster.Location = new System.Drawing.Point(13, 216);
            this.dataGridViewHesapGoster.Name = "dataGridViewHesapGoster";
            this.dataGridViewHesapGoster.RowTemplate.Height = 24;
            this.dataGridViewHesapGoster.Size = new System.Drawing.Size(510, 158);
            this.dataGridViewHesapGoster.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Para çekme işlemi için lütfen bilgilerinizi doğru ve eksiksiz şekilde giriniz.";
            // 
            // frmParaCekme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(538, 393);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewHesapGoster);
            this.Controls.Add(this.btnParaCek);
            this.Controls.Add(this.btnHesapGoster);
            this.Controls.Add(this.lblCekilcekMiktar);
            this.Controls.Add(this.lblHesapNo);
            this.Controls.Add(this.lblMusteriNo);
            this.Controls.Add(this.txtCekilcekMiktar);
            this.Controls.Add(this.txtHesapNo);
            this.Controls.Add(this.txtMusteriNo);
            this.Name = "frmParaCekme";
            this.Text = "ParaCekme";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHesapGoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMusteriNo;
        private System.Windows.Forms.TextBox txtHesapNo;
        private System.Windows.Forms.TextBox txtCekilcekMiktar;
        private System.Windows.Forms.Label lblMusteriNo;
        private System.Windows.Forms.Label lblHesapNo;
        private System.Windows.Forms.Label lblCekilcekMiktar;
        private System.Windows.Forms.Button btnHesapGoster;
        private System.Windows.Forms.Button btnParaCek;
        private System.Windows.Forms.DataGridView dataGridViewHesapGoster;
        private System.Windows.Forms.Label label1;
    }
}