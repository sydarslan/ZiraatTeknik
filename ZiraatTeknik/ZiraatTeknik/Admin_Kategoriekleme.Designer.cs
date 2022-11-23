
namespace ZiraatTeknik
{
    partial class Admin_Kategoriekleme
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
            this.txtadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxkategori = new System.Windows.Forms.CheckBox();
            this.btnkategoriekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Adı :";
            // 
            // txtadi
            // 
            this.txtadi.Location = new System.Drawing.Point(149, 25);
            this.txtadi.Name = "txtadi";
            this.txtadi.Size = new System.Drawing.Size(132, 20);
            this.txtadi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.label2.Location = new System.Drawing.Point(24, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Durumu :";
            // 
            // checkBoxkategori
            // 
            this.checkBoxkategori.AutoSize = true;
            this.checkBoxkategori.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.checkBoxkategori.Location = new System.Drawing.Point(149, 75);
            this.checkBoxkategori.Name = "checkBoxkategori";
            this.checkBoxkategori.Size = new System.Drawing.Size(117, 18);
            this.checkBoxkategori.TabIndex = 3;
            this.checkBoxkategori.Text = "Aktif / Pasif";
            this.checkBoxkategori.UseVisualStyleBackColor = true;
            // 
            // btnkategoriekle
            // 
            this.btnkategoriekle.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnkategoriekle.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.btnkategoriekle.Location = new System.Drawing.Point(104, 112);
            this.btnkategoriekle.Name = "btnkategoriekle";
            this.btnkategoriekle.Size = new System.Drawing.Size(75, 23);
            this.btnkategoriekle.TabIndex = 4;
            this.btnkategoriekle.Text = "Ekle";
            this.btnkategoriekle.UseVisualStyleBackColor = false;
            this.btnkategoriekle.Click += new System.EventHandler(this.btnkategoriekle_Click);
            // 
            // Admin_Kategoriekleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(293, 147);
            this.Controls.Add(this.btnkategoriekle);
            this.Controls.Add(this.checkBoxkategori);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtadi);
            this.Controls.Add(this.label1);
            this.Name = "Admin_Kategoriekleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategoriekleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxkategori;
        private System.Windows.Forms.Button btnkategoriekle;
    }
}