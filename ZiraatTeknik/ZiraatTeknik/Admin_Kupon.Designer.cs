
namespace ZiraatTeknik
{
    partial class Admin_Kupon
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxKuponAktif = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtUye = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtFiyat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnKuponEkle = new System.Windows.Forms.Button();
            this.TxtKod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataKuponlar = new System.Windows.Forms.DataGridView();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataKuponlar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxKuponAktif);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TxtUye);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TxtFiyat);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.BtnKuponEkle);
            this.groupBox2.Controls.Add(this.TxtKod);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.groupBox2.Location = new System.Drawing.Point(145, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 238);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kupon İşlemleri";
            // 
            // checkBoxKuponAktif
            // 
            this.checkBoxKuponAktif.AutoSize = true;
            this.checkBoxKuponAktif.Location = new System.Drawing.Point(156, 154);
            this.checkBoxKuponAktif.Name = "checkBoxKuponAktif";
            this.checkBoxKuponAktif.Size = new System.Drawing.Size(117, 18);
            this.checkBoxKuponAktif.TabIndex = 9;
            this.checkBoxKuponAktif.Text = "Aktif / Pasif";
            this.checkBoxKuponAktif.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 11F);
            this.label6.Location = new System.Drawing.Point(23, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Durumu :";
            // 
            // TxtUye
            // 
            this.TxtUye.Font = new System.Drawing.Font("Courier New", 11F);
            this.TxtUye.Location = new System.Drawing.Point(156, 113);
            this.TxtUye.Name = "TxtUye";
            this.TxtUye.Size = new System.Drawing.Size(150, 24);
            this.TxtUye.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 11F);
            this.label3.Location = new System.Drawing.Point(20, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kupon Sahibi :";
            // 
            // TxtFiyat
            // 
            this.TxtFiyat.Font = new System.Drawing.Font("Courier New", 11F);
            this.TxtFiyat.Location = new System.Drawing.Point(156, 76);
            this.TxtFiyat.Name = "TxtFiyat";
            this.TxtFiyat.Size = new System.Drawing.Size(150, 24);
            this.TxtFiyat.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 11F);
            this.label2.Location = new System.Drawing.Point(20, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kupon Ücreti :";
            // 
            // BtnKuponEkle
            // 
            this.BtnKuponEkle.BackColor = System.Drawing.Color.DarkKhaki;
            this.BtnKuponEkle.Font = new System.Drawing.Font("Courier New", 10F);
            this.BtnKuponEkle.Location = new System.Drawing.Point(103, 196);
            this.BtnKuponEkle.Name = "BtnKuponEkle";
            this.BtnKuponEkle.Size = new System.Drawing.Size(110, 23);
            this.BtnKuponEkle.TabIndex = 3;
            this.BtnKuponEkle.Text = "Kupon Ekle";
            this.BtnKuponEkle.UseVisualStyleBackColor = false;
            this.BtnKuponEkle.Click += new System.EventHandler(this.BtnKuponEkle_Click);
            // 
            // TxtKod
            // 
            this.TxtKod.Font = new System.Drawing.Font("Courier New", 11F);
            this.TxtKod.Location = new System.Drawing.Point(156, 38);
            this.TxtKod.Name = "TxtKod";
            this.TxtKod.Size = new System.Drawing.Size(150, 24);
            this.TxtKod.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 14);
            this.label4.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 11F);
            this.label5.Location = new System.Drawing.Point(20, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kupon Kodu :";
            // 
            // dataKuponlar
            // 
            this.dataKuponlar.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dataKuponlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKuponlar.GridColor = System.Drawing.Color.GhostWhite;
            this.dataKuponlar.Location = new System.Drawing.Point(38, 285);
            this.dataKuponlar.Name = "dataKuponlar";
            this.dataKuponlar.Size = new System.Drawing.Size(560, 176);
            this.dataKuponlar.TabIndex = 4;
            // 
            // BtnCikis
            // 
            this.BtnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCikis.ForeColor = System.Drawing.Color.DarkKhaki;
            this.BtnCikis.Location = new System.Drawing.Point(587, 12);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(36, 23);
            this.BtnCikis.TabIndex = 8;
            this.BtnCikis.Text = "x";
            this.BtnCikis.UseVisualStyleBackColor = true;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // Admin_Kupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(635, 563);
            this.Controls.Add(this.BtnCikis);
            this.Controls.Add(this.dataKuponlar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Name = "Admin_Kupon";
            this.Text = "Admin_Kupon";
            this.Load += new System.EventHandler(this.Admin_Kupon_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataKuponlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtKod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnKuponEkle;
        private System.Windows.Forms.DataGridView dataKuponlar;
        private System.Windows.Forms.CheckBox checkBoxKuponAktif;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtUye;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtFiyat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCikis;
    }
}