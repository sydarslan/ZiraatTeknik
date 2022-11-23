
namespace ZiraatTeknik
{
    partial class Admin_Kampanyalar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxAktif = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnKampanyaEkle = new System.Windows.Forms.Button();
            this.TxtKampanyaF = new System.Windows.Forms.TextBox();
            this.TxtUrunid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataurun = new System.Windows.Forms.DataGridView();
            this.datakampanya = new System.Windows.Forms.DataGridView();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataurun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datakampanya)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(205, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxAktif);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.BtnKampanyaEkle);
            this.groupBox1.Controls.Add(this.TxtKampanyaF);
            this.groupBox1.Controls.Add(this.TxtUrunid);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 11F);
            this.groupBox1.Location = new System.Drawing.Point(34, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 226);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kampanya İşlemleri";
            // 
            // checkBoxAktif
            // 
            this.checkBoxAktif.AutoSize = true;
            this.checkBoxAktif.Location = new System.Drawing.Point(297, 128);
            this.checkBoxAktif.Name = "checkBoxAktif";
            this.checkBoxAktif.Size = new System.Drawing.Size(144, 21);
            this.checkBoxAktif.TabIndex = 6;
            this.checkBoxAktif.Text = "Aktif / Pasif";
            this.checkBoxAktif.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Durumu :";
            // 
            // BtnKampanyaEkle
            // 
            this.BtnKampanyaEkle.BackColor = System.Drawing.Color.DarkKhaki;
            this.BtnKampanyaEkle.Location = new System.Drawing.Point(177, 175);
            this.BtnKampanyaEkle.Name = "BtnKampanyaEkle";
            this.BtnKampanyaEkle.Size = new System.Drawing.Size(215, 29);
            this.BtnKampanyaEkle.TabIndex = 4;
            this.BtnKampanyaEkle.Text = "Kampanya Fiyatı Ekle";
            this.BtnKampanyaEkle.UseVisualStyleBackColor = false;
            this.BtnKampanyaEkle.Click += new System.EventHandler(this.BtnKampanyaEkle_Click);
            // 
            // TxtKampanyaF
            // 
            this.TxtKampanyaF.Location = new System.Drawing.Point(297, 81);
            this.TxtKampanyaF.Name = "TxtKampanyaF";
            this.TxtKampanyaF.Size = new System.Drawing.Size(169, 24);
            this.TxtKampanyaF.TabIndex = 3;
            // 
            // TxtUrunid
            // 
            this.TxtUrunid.Location = new System.Drawing.Point(297, 40);
            this.TxtUrunid.Name = "TxtUrunid";
            this.TxtUrunid.Size = new System.Drawing.Size(169, 24);
            this.TxtUrunid.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kampanya Fiyatı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürün ID: ";
            // 
            // dataurun
            // 
            this.dataurun.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dataurun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataurun.Location = new System.Drawing.Point(34, 255);
            this.dataurun.Name = "dataurun";
            this.dataurun.Size = new System.Drawing.Size(294, 150);
            this.dataurun.TabIndex = 2;
            this.dataurun.SelectionChanged += new System.EventHandler(this.dataurun_SelectionChanged);
            // 
            // datakampanya
            // 
            this.datakampanya.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.datakampanya.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datakampanya.Location = new System.Drawing.Point(352, 255);
            this.datakampanya.Name = "datakampanya";
            this.datakampanya.Size = new System.Drawing.Size(232, 150);
            this.datakampanya.TabIndex = 3;
            // 
            // BtnCikis
            // 
            this.BtnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCikis.ForeColor = System.Drawing.Color.DarkKhaki;
            this.BtnCikis.Location = new System.Drawing.Point(595, 2);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(36, 23);
            this.BtnCikis.TabIndex = 9;
            this.BtnCikis.Text = "x";
            this.BtnCikis.UseVisualStyleBackColor = true;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // Admin_Kampanyalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(635, 563);
            this.Controls.Add(this.BtnCikis);
            this.Controls.Add(this.datakampanya);
            this.Controls.Add(this.dataurun);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Admin_Kampanyalar";
            this.Text = "Kampanyalar";
            this.Load += new System.EventHandler(this.Admin_Kampanyalar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataurun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datakampanya)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnKampanyaEkle;
        private System.Windows.Forms.TextBox TxtKampanyaF;
        private System.Windows.Forms.TextBox TxtUrunid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataurun;
        private System.Windows.Forms.DataGridView datakampanya;
        private System.Windows.Forms.CheckBox checkBoxAktif;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnCikis;
    }
}