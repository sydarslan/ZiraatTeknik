
namespace ZiraatTeknik
{
    partial class Admin_Bildirim
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
            this.databildirim = new System.Windows.Forms.DataGridView();
            this.BtnCikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.databildirim)).BeginInit();
            this.SuspendLayout();
            // 
            // databildirim
            // 
            this.databildirim.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.databildirim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.databildirim.Location = new System.Drawing.Point(92, 125);
            this.databildirim.Name = "databildirim";
            this.databildirim.Size = new System.Drawing.Size(456, 280);
            this.databildirim.TabIndex = 0;
            // 
            // BtnCikis
            // 
            this.BtnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCikis.ForeColor = System.Drawing.Color.DarkKhaki;
            this.BtnCikis.Location = new System.Drawing.Point(587, 12);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(36, 23);
            this.BtnCikis.TabIndex = 9;
            this.BtnCikis.Text = "x";
            this.BtnCikis.UseVisualStyleBackColor = true;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // Admin_Bildirim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(635, 563);
            this.Controls.Add(this.BtnCikis);
            this.Controls.Add(this.databildirim);
            this.Name = "Admin_Bildirim";
            this.Text = "Admin_Bildirim";
            this.Load += new System.EventHandler(this.Admin_Bildirim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databildirim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView databildirim;
        private System.Windows.Forms.Button BtnCikis;
    }
}