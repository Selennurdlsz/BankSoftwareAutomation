namespace BankaUygulaması
{
    partial class frmHavaleYapma
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
            this.lblHavaleYapanHesapNo = new System.Windows.Forms.Label();
            this.lblHavaleYapilanHesapno = new System.Windows.Forms.Label();
            this.lblHavaleMiktari = new System.Windows.Forms.Label();
            this.txtHavaleYapanHesapNo = new System.Windows.Forms.TextBox();
            this.txtHavaleYapilanHesapNo = new System.Windows.Forms.TextBox();
            this.txtHavaleMiktari = new System.Windows.Forms.TextBox();
            this.btnHavaleYapanHesapGoster = new System.Windows.Forms.Button();
            this.btnHavaleYapilanHesapGoster = new System.Windows.Forms.Button();
            this.btnHavaleYap = new System.Windows.Forms.Button();
            this.dataGridViewHavaleYapanHesapGoster = new System.Windows.Forms.DataGridView();
            this.dataGridViewHavaleYapilanHesapGoster = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHavaleYapanHesapGoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHavaleYapilanHesapGoster)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHavaleYapanHesapNo
            // 
            this.lblHavaleYapanHesapNo.AutoSize = true;
            this.lblHavaleYapanHesapNo.Location = new System.Drawing.Point(21, 44);
            this.lblHavaleYapanHesapNo.Name = "lblHavaleYapanHesapNo";
            this.lblHavaleYapanHesapNo.Size = new System.Drawing.Size(216, 17);
            this.lblHavaleYapanHesapNo.TabIndex = 0;
            this.lblHavaleYapanHesapNo.Text = "Havale Yapacak Olan Hesap No:";
            // 
            // lblHavaleYapilanHesapno
            // 
            this.lblHavaleYapilanHesapno.AutoSize = true;
            this.lblHavaleYapilanHesapno.Location = new System.Drawing.Point(21, 85);
            this.lblHavaleYapilanHesapno.Name = "lblHavaleYapilanHesapno";
            this.lblHavaleYapilanHesapno.Size = new System.Drawing.Size(174, 17);
            this.lblHavaleYapilanHesapno.TabIndex = 1;
            this.lblHavaleYapilanHesapno.Text = "Havale Yapılan Hesap No:";
            this.lblHavaleYapilanHesapno.Visible = false;
            // 
            // lblHavaleMiktari
            // 
            this.lblHavaleMiktari.AutoSize = true;
            this.lblHavaleMiktari.Location = new System.Drawing.Point(21, 131);
            this.lblHavaleMiktari.Name = "lblHavaleMiktari";
            this.lblHavaleMiktari.Size = new System.Drawing.Size(163, 17);
            this.lblHavaleMiktari.TabIndex = 2;
            this.lblHavaleMiktari.Text = "Havale Yapılacak Miktar:";
            this.lblHavaleMiktari.Visible = false;
            // 
            // txtHavaleYapanHesapNo
            // 
            this.txtHavaleYapanHesapNo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtHavaleYapanHesapNo.Location = new System.Drawing.Point(270, 39);
            this.txtHavaleYapanHesapNo.Name = "txtHavaleYapanHesapNo";
            this.txtHavaleYapanHesapNo.Size = new System.Drawing.Size(100, 22);
            this.txtHavaleYapanHesapNo.TabIndex = 3;
            // 
            // txtHavaleYapilanHesapNo
            // 
            this.txtHavaleYapilanHesapNo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtHavaleYapilanHesapNo.Location = new System.Drawing.Point(270, 85);
            this.txtHavaleYapilanHesapNo.Name = "txtHavaleYapilanHesapNo";
            this.txtHavaleYapilanHesapNo.Size = new System.Drawing.Size(100, 22);
            this.txtHavaleYapilanHesapNo.TabIndex = 4;
            this.txtHavaleYapilanHesapNo.Visible = false;
            // 
            // txtHavaleMiktari
            // 
            this.txtHavaleMiktari.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtHavaleMiktari.Location = new System.Drawing.Point(270, 138);
            this.txtHavaleMiktari.Name = "txtHavaleMiktari";
            this.txtHavaleMiktari.Size = new System.Drawing.Size(100, 22);
            this.txtHavaleMiktari.TabIndex = 5;
            this.txtHavaleMiktari.Visible = false;
            // 
            // btnHavaleYapanHesapGoster
            // 
            this.btnHavaleYapanHesapGoster.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnHavaleYapanHesapGoster.Location = new System.Drawing.Point(402, 28);
            this.btnHavaleYapanHesapGoster.Name = "btnHavaleYapanHesapGoster";
            this.btnHavaleYapanHesapGoster.Size = new System.Drawing.Size(115, 33);
            this.btnHavaleYapanHesapGoster.TabIndex = 6;
            this.btnHavaleYapanHesapGoster.Text = "Hesap Göster";
            this.btnHavaleYapanHesapGoster.UseVisualStyleBackColor = false;
            this.btnHavaleYapanHesapGoster.Click += new System.EventHandler(this.btnHavaleYapanHesapGoster_Click);
            // 
            // btnHavaleYapilanHesapGoster
            // 
            this.btnHavaleYapilanHesapGoster.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnHavaleYapilanHesapGoster.Location = new System.Drawing.Point(402, 78);
            this.btnHavaleYapilanHesapGoster.Name = "btnHavaleYapilanHesapGoster";
            this.btnHavaleYapilanHesapGoster.Size = new System.Drawing.Size(115, 37);
            this.btnHavaleYapilanHesapGoster.TabIndex = 7;
            this.btnHavaleYapilanHesapGoster.Text = "Hesap Göster";
            this.btnHavaleYapilanHesapGoster.UseVisualStyleBackColor = false;
            this.btnHavaleYapilanHesapGoster.Visible = false;
            this.btnHavaleYapilanHesapGoster.Click += new System.EventHandler(this.btnHavaleYapilanHesapGoster_Click);
            // 
            // btnHavaleYap
            // 
            this.btnHavaleYap.BackColor = System.Drawing.SystemColors.Info;
            this.btnHavaleYap.Location = new System.Drawing.Point(399, 131);
            this.btnHavaleYap.Name = "btnHavaleYap";
            this.btnHavaleYap.Size = new System.Drawing.Size(115, 36);
            this.btnHavaleYap.TabIndex = 8;
            this.btnHavaleYap.Text = "Havale Yap";
            this.btnHavaleYap.UseVisualStyleBackColor = false;
            this.btnHavaleYap.Visible = false;
            this.btnHavaleYap.Click += new System.EventHandler(this.btnHavaleYap_Click);
            // 
            // dataGridViewHavaleYapanHesapGoster
            // 
            this.dataGridViewHavaleYapanHesapGoster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHavaleYapanHesapGoster.Location = new System.Drawing.Point(24, 200);
            this.dataGridViewHavaleYapanHesapGoster.Name = "dataGridViewHavaleYapanHesapGoster";
            this.dataGridViewHavaleYapanHesapGoster.RowTemplate.Height = 24;
            this.dataGridViewHavaleYapanHesapGoster.Size = new System.Drawing.Size(493, 111);
            this.dataGridViewHavaleYapanHesapGoster.TabIndex = 9;
            // 
            // dataGridViewHavaleYapilanHesapGoster
            // 
            this.dataGridViewHavaleYapilanHesapGoster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHavaleYapilanHesapGoster.Location = new System.Drawing.Point(24, 317);
            this.dataGridViewHavaleYapilanHesapGoster.Name = "dataGridViewHavaleYapilanHesapGoster";
            this.dataGridViewHavaleYapilanHesapGoster.RowTemplate.Height = 24;
            this.dataGridViewHavaleYapilanHesapGoster.Size = new System.Drawing.Size(493, 123);
            this.dataGridViewHavaleYapilanHesapGoster.TabIndex = 10;
            this.dataGridViewHavaleYapilanHesapGoster.Visible = false;
            // 
            // frmHavaleYapma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(550, 452);
            this.Controls.Add(this.dataGridViewHavaleYapilanHesapGoster);
            this.Controls.Add(this.dataGridViewHavaleYapanHesapGoster);
            this.Controls.Add(this.btnHavaleYap);
            this.Controls.Add(this.btnHavaleYapilanHesapGoster);
            this.Controls.Add(this.btnHavaleYapanHesapGoster);
            this.Controls.Add(this.txtHavaleMiktari);
            this.Controls.Add(this.txtHavaleYapilanHesapNo);
            this.Controls.Add(this.txtHavaleYapanHesapNo);
            this.Controls.Add(this.lblHavaleMiktari);
            this.Controls.Add(this.lblHavaleYapilanHesapno);
            this.Controls.Add(this.lblHavaleYapanHesapNo);
            this.Name = "frmHavaleYapma";
            this.Text = "frmHavaleYapma";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHavaleYapanHesapGoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHavaleYapilanHesapGoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHavaleYapanHesapNo;
        private System.Windows.Forms.Label lblHavaleYapilanHesapno;
        private System.Windows.Forms.Label lblHavaleMiktari;
        private System.Windows.Forms.TextBox txtHavaleYapanHesapNo;
        private System.Windows.Forms.TextBox txtHavaleYapilanHesapNo;
        private System.Windows.Forms.TextBox txtHavaleMiktari;
        private System.Windows.Forms.Button btnHavaleYapanHesapGoster;
        private System.Windows.Forms.Button btnHavaleYapilanHesapGoster;
        private System.Windows.Forms.Button btnHavaleYap;
        private System.Windows.Forms.DataGridView dataGridViewHavaleYapanHesapGoster;
        private System.Windows.Forms.DataGridView dataGridViewHavaleYapilanHesapGoster;
    }
}