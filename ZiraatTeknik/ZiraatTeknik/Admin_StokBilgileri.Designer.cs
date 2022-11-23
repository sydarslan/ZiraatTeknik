
namespace ZiraatTeknik
{
    partial class Admin_StokBilgileri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_StokBilgileri));
            this.dataUrunler = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblid = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.TxtAdet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnGüncelle = new System.Windows.Forms.Button();
            this.BtnCikis3 = new System.Windows.Forms.Button();
            this.dataStokAdedi = new System.Windows.Forms.DataGridView();
            this.BtnStokListele = new System.Windows.Forms.Button();
            this.BtnUrunListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataUrunler)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataStokAdedi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataUrunler
            // 
            this.dataUrunler.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dataUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUrunler.GridColor = System.Drawing.Color.GhostWhite;
            this.dataUrunler.Location = new System.Drawing.Point(12, 286);
            this.dataUrunler.Name = "dataUrunler";
            this.dataUrunler.Size = new System.Drawing.Size(238, 168);
            this.dataUrunler.TabIndex = 0;
            this.dataUrunler.SelectionChanged += new System.EventHandler(this.dataStokUrun_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblid);
            this.groupBox1.Controls.Add(this.TxtId);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.BtnEkle);
            this.groupBox1.Controls.Add(this.TxtAdet);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BtnGüncelle);
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 196);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stok İşlemleri";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(157, 104);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 14);
            this.lblid.TabIndex = 12;
            // 
            // TxtId
            // 
            this.TxtId.Font = new System.Drawing.Font("Courier New", 10F);
            this.TxtId.Location = new System.Drawing.Point(277, 41);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(158, 23);
            this.TxtId.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 10F);
            this.label6.Location = new System.Drawing.Point(168, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ürün Id :";
            // 
            // BtnEkle
            // 
            this.BtnEkle.BackColor = System.Drawing.Color.DarkKhaki;
            this.BtnEkle.Location = new System.Drawing.Point(84, 144);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(94, 35);
            this.BtnEkle.TabIndex = 9;
            this.BtnEkle.Text = "Stok Ekle";
            this.BtnEkle.UseVisualStyleBackColor = false;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // TxtAdet
            // 
            this.TxtAdet.Font = new System.Drawing.Font("Courier New", 10F);
            this.TxtAdet.Location = new System.Drawing.Point(277, 83);
            this.TxtAdet.Name = "TxtAdet";
            this.TxtAdet.Size = new System.Drawing.Size(158, 23);
            this.TxtAdet.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 10F);
            this.label2.Location = new System.Drawing.Point(168, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Stok Adedi :";
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.BackColor = System.Drawing.Color.DarkKhaki;
            this.BtnGüncelle.Location = new System.Drawing.Point(415, 144);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(107, 35);
            this.BtnGüncelle.TabIndex = 4;
            this.BtnGüncelle.Text = "Stok Güncelle";
            this.BtnGüncelle.UseVisualStyleBackColor = false;
            this.BtnGüncelle.Click += new System.EventHandler(this.BtnGüncelle_Click);
            // 
            // BtnCikis3
            // 
            this.BtnCikis3.BackColor = System.Drawing.Color.GhostWhite;
            this.BtnCikis3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCikis3.ForeColor = System.Drawing.Color.DarkKhaki;
            this.BtnCikis3.Location = new System.Drawing.Point(596, 2);
            this.BtnCikis3.Name = "BtnCikis3";
            this.BtnCikis3.Size = new System.Drawing.Size(36, 23);
            this.BtnCikis3.TabIndex = 10;
            this.BtnCikis3.Text = "x";
            this.BtnCikis3.UseVisualStyleBackColor = false;
            this.BtnCikis3.Click += new System.EventHandler(this.BtnCikis3_Click);
            // 
            // dataStokAdedi
            // 
            this.dataStokAdedi.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dataStokAdedi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStokAdedi.GridColor = System.Drawing.Color.GhostWhite;
            this.dataStokAdedi.Location = new System.Drawing.Point(372, 286);
            this.dataStokAdedi.Name = "dataStokAdedi";
            this.dataStokAdedi.Size = new System.Drawing.Size(238, 168);
            this.dataStokAdedi.TabIndex = 11;
            // 
            // BtnStokListele
            // 
            this.BtnStokListele.BackColor = System.Drawing.Color.DarkKhaki;
            this.BtnStokListele.Image = ((System.Drawing.Image)(resources.GetObject("BtnStokListele.Image")));
            this.BtnStokListele.Location = new System.Drawing.Point(588, 258);
            this.BtnStokListele.Name = "BtnStokListele";
            this.BtnStokListele.Size = new System.Drawing.Size(22, 23);
            this.BtnStokListele.TabIndex = 13;
            this.BtnStokListele.UseVisualStyleBackColor = false;
            this.BtnStokListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // BtnUrunListele
            // 
            this.BtnUrunListele.BackColor = System.Drawing.Color.DarkKhaki;
            this.BtnUrunListele.Image = ((System.Drawing.Image)(resources.GetObject("BtnUrunListele.Image")));
            this.BtnUrunListele.Location = new System.Drawing.Point(226, 258);
            this.BtnUrunListele.Name = "BtnUrunListele";
            this.BtnUrunListele.Size = new System.Drawing.Size(24, 22);
            this.BtnUrunListele.TabIndex = 14;
            this.BtnUrunListele.UseVisualStyleBackColor = false;
            this.BtnUrunListele.Click += new System.EventHandler(this.BtnUrunListele_Click);
            // 
            // Admin_StokBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(635, 563);
            this.Controls.Add(this.BtnUrunListele);
            this.Controls.Add(this.BtnStokListele);
            this.Controls.Add(this.dataStokAdedi);
            this.Controls.Add(this.BtnCikis3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataUrunler);
            this.Name = "Admin_StokBilgileri";
            this.Text = "StokBilgileri";
            this.Load += new System.EventHandler(this.StokBilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataUrunler)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataStokAdedi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataUrunler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnGüncelle;
        private System.Windows.Forms.TextBox TxtAdet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Button BtnCikis3;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataStokAdedi;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Button BtnStokListele;
        private System.Windows.Forms.Button BtnUrunListele;
    }
}