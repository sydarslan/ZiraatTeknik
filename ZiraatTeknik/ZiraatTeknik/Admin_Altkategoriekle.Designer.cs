
namespace ZiraatTeknik
{
    partial class Admin_Altkategoriekle
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
            this.btnaltkategoriekle = new System.Windows.Forms.Button();
            this.txtaltkategoriadi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxkategori = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnaltkategoriekle
            // 
            this.btnaltkategoriekle.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnaltkategoriekle.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.btnaltkategoriekle.Location = new System.Drawing.Point(104, 112);
            this.btnaltkategoriekle.Name = "btnaltkategoriekle";
            this.btnaltkategoriekle.Size = new System.Drawing.Size(75, 23);
            this.btnaltkategoriekle.TabIndex = 8;
            this.btnaltkategoriekle.Text = "Ekle";
            this.btnaltkategoriekle.UseVisualStyleBackColor = false;
            this.btnaltkategoriekle.Click += new System.EventHandler(this.btnaltkategoriekle_Click);
            // 
            // txtaltkategoriadi
            // 
            this.txtaltkategoriadi.Location = new System.Drawing.Point(144, 26);
            this.txtaltkategoriadi.Name = "txtaltkategoriadi";
            this.txtaltkategoriadi.Size = new System.Drawing.Size(137, 20);
            this.txtaltkategoriadi.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Alt Kategori  Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kategori  Adı :";
            // 
            // comboBoxkategori
            // 
            this.comboBoxkategori.FormattingEnabled = true;
            this.comboBoxkategori.Location = new System.Drawing.Point(144, 67);
            this.comboBoxkategori.Name = "comboBoxkategori";
            this.comboBoxkategori.Size = new System.Drawing.Size(137, 21);
            this.comboBoxkategori.TabIndex = 10;
            // 
            // Admin_Altkategoriekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(293, 147);
            this.Controls.Add(this.comboBoxkategori);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnaltkategoriekle);
            this.Controls.Add(this.txtaltkategoriadi);
            this.Controls.Add(this.label1);
            this.Name = "Admin_Altkategoriekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "altkategoriekle";
            this.Load += new System.EventHandler(this.altkategoriekle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnaltkategoriekle;
        private System.Windows.Forms.TextBox txtaltkategoriadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxkategori;
    }
}