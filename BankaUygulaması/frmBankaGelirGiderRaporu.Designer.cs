namespace BankaUygulaması
{
    partial class frmBankaGelirGiderRaporu
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
            this.btnBankaGelirGiderRaporu = new System.Windows.Forms.Button();
            this.dataGridViewBankaGiderRaporu = new System.Windows.Forms.DataGridView();
            this.dataGridViewBankaGelirRaporu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBankaGiderRaporu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBankaGelirRaporu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBankaGelirGiderRaporu
            // 
            this.btnBankaGelirGiderRaporu.Location = new System.Drawing.Point(214, 38);
            this.btnBankaGelirGiderRaporu.Name = "btnBankaGelirGiderRaporu";
            this.btnBankaGelirGiderRaporu.Size = new System.Drawing.Size(205, 101);
            this.btnBankaGelirGiderRaporu.TabIndex = 0;
            this.btnBankaGelirGiderRaporu.Text = "Banka Gelir Gider Raporu";
            this.btnBankaGelirGiderRaporu.UseVisualStyleBackColor = true;
            this.btnBankaGelirGiderRaporu.Click += new System.EventHandler(this.btnBankaGelirGiderRaporu_Click);
            // 
            // dataGridViewBankaGiderRaporu
            // 
            this.dataGridViewBankaGiderRaporu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBankaGiderRaporu.Location = new System.Drawing.Point(37, 172);
            this.dataGridViewBankaGiderRaporu.Name = "dataGridViewBankaGiderRaporu";
            this.dataGridViewBankaGiderRaporu.RowTemplate.Height = 24;
            this.dataGridViewBankaGiderRaporu.Size = new System.Drawing.Size(532, 107);
            this.dataGridViewBankaGiderRaporu.TabIndex = 1;
            // 
            // dataGridViewBankaGelirRaporu
            // 
            this.dataGridViewBankaGelirRaporu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBankaGelirRaporu.Location = new System.Drawing.Point(37, 285);
            this.dataGridViewBankaGelirRaporu.Name = "dataGridViewBankaGelirRaporu";
            this.dataGridViewBankaGelirRaporu.RowTemplate.Height = 24;
            this.dataGridViewBankaGelirRaporu.Size = new System.Drawing.Size(532, 116);
            this.dataGridViewBankaGelirRaporu.TabIndex = 2;
            // 
            // frmBankaGelirGiderRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 470);
            this.Controls.Add(this.dataGridViewBankaGelirRaporu);
            this.Controls.Add(this.dataGridViewBankaGiderRaporu);
            this.Controls.Add(this.btnBankaGelirGiderRaporu);
            this.Name = "frmBankaGelirGiderRaporu";
            this.Text = "frmBankaGelirGiderRaporu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBankaGiderRaporu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBankaGelirRaporu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBankaGelirGiderRaporu;
        private System.Windows.Forms.DataGridView dataGridViewBankaGiderRaporu;
        private System.Windows.Forms.DataGridView dataGridViewBankaGelirRaporu;
    }
}