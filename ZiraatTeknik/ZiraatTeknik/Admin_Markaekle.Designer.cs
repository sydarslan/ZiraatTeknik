
namespace ZiraatTeknik
{
    partial class Admin_Markaekle
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
            this.txtmarkaadi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnmarkaekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtmarkaadi
            // 
            this.txtmarkaadi.Location = new System.Drawing.Point(127, 38);
            this.txtmarkaadi.Name = "txtmarkaadi";
            this.txtmarkaadi.Size = new System.Drawing.Size(154, 20);
            this.txtmarkaadi.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.label1.Location = new System.Drawing.Point(37, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Marka Adı :";
            // 
            // btnmarkaekle
            // 
            this.btnmarkaekle.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnmarkaekle.Location = new System.Drawing.Point(107, 101);
            this.btnmarkaekle.Name = "btnmarkaekle";
            this.btnmarkaekle.Size = new System.Drawing.Size(75, 23);
            this.btnmarkaekle.TabIndex = 5;
            this.btnmarkaekle.Text = "Ekle";
            this.btnmarkaekle.UseVisualStyleBackColor = false;
            this.btnmarkaekle.Click += new System.EventHandler(this.btnmarkaekle_Click);
            // 
            // Admin_Markaekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(293, 147);
            this.Controls.Add(this.btnmarkaekle);
            this.Controls.Add(this.txtmarkaadi);
            this.Controls.Add(this.label1);
            this.Name = "Admin_Markaekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "markaekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmarkaadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnmarkaekle;
    }
}