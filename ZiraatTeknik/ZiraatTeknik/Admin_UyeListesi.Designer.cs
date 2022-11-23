
namespace ZiraatTeknik
{
    partial class Admin_UyeListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_UyeListesi));
            this.datauye = new System.Windows.Forms.DataGridView();
            this.datamailuye = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btnuyegetir = new System.Windows.Forms.Button();
            this.Btnmailuyegetir = new System.Windows.Forms.Button();
            this.BtnCikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datauye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datamailuye)).BeginInit();
            this.SuspendLayout();
            // 
            // datauye
            // 
            this.datauye.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.datauye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datauye.GridColor = System.Drawing.Color.GhostWhite;
            this.datauye.Location = new System.Drawing.Point(12, 72);
            this.datauye.Name = "datauye";
            this.datauye.Size = new System.Drawing.Size(617, 179);
            this.datauye.TabIndex = 2;
            // 
            // datamailuye
            // 
            this.datamailuye.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.datamailuye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datamailuye.GridColor = System.Drawing.Color.GhostWhite;
            this.datamailuye.Location = new System.Drawing.Point(18, 320);
            this.datamailuye.Name = "datamailuye";
            this.datamailuye.Size = new System.Drawing.Size(611, 217);
            this.datamailuye.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kayıtlı Üye Listesi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.label3.Location = new System.Drawing.Point(15, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mail Abonman Listesi";
            // 
            // Btnuyegetir
            // 
            this.Btnuyegetir.BackColor = System.Drawing.Color.DarkKhaki;
            this.Btnuyegetir.Image = ((System.Drawing.Image)(resources.GetObject("Btnuyegetir.Image")));
            this.Btnuyegetir.Location = new System.Drawing.Point(597, 43);
            this.Btnuyegetir.Name = "Btnuyegetir";
            this.Btnuyegetir.Size = new System.Drawing.Size(26, 23);
            this.Btnuyegetir.TabIndex = 6;
            this.Btnuyegetir.UseVisualStyleBackColor = false;
            this.Btnuyegetir.Click += new System.EventHandler(this.Btnuyegetir_Click);
            // 
            // Btnmailuyegetir
            // 
            this.Btnmailuyegetir.BackColor = System.Drawing.Color.DarkKhaki;
            this.Btnmailuyegetir.Image = ((System.Drawing.Image)(resources.GetObject("Btnmailuyegetir.Image")));
            this.Btnmailuyegetir.Location = new System.Drawing.Point(597, 291);
            this.Btnmailuyegetir.Name = "Btnmailuyegetir";
            this.Btnmailuyegetir.Size = new System.Drawing.Size(26, 23);
            this.Btnmailuyegetir.TabIndex = 7;
            this.Btnmailuyegetir.UseVisualStyleBackColor = false;
            // 
            // BtnCikis
            // 
            this.BtnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCikis.ForeColor = System.Drawing.Color.DarkKhaki;
            this.BtnCikis.Location = new System.Drawing.Point(593, 3);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(36, 23);
            this.BtnCikis.TabIndex = 8;
            this.BtnCikis.Text = "x";
            this.BtnCikis.UseVisualStyleBackColor = true;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // Admin_UyeListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(635, 563);
            this.Controls.Add(this.BtnCikis);
            this.Controls.Add(this.Btnmailuyegetir);
            this.Controls.Add(this.Btnuyegetir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datauye);
            this.Controls.Add(this.datamailuye);
            this.Name = "Admin_UyeListesi";
            this.Text = "UyeListesi";
            this.Load += new System.EventHandler(this.Admin_UyeListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datauye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datamailuye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView datauye;
        private System.Windows.Forms.DataGridView datamailuye;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btnuyegetir;
        private System.Windows.Forms.Button Btnmailuyegetir;
        private System.Windows.Forms.Button BtnCikis;
    }
}