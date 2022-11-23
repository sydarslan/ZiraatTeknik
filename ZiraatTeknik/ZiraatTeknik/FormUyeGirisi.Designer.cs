
namespace ZiraatTeknik
{
    partial class FormUyeGirisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUyeGirisi));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtGirisEmail = new System.Windows.Forms.TextBox();
            this.TxtGirisSifre = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.BtnGirisYap = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 15F);
            this.label1.Location = new System.Drawing.Point(276, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 15F);
            this.label3.Location = new System.Drawing.Point(276, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre";
            // 
            // TxtGirisEmail
            // 
            this.TxtGirisEmail.Location = new System.Drawing.Point(387, 131);
            this.TxtGirisEmail.Name = "TxtGirisEmail";
            this.TxtGirisEmail.Size = new System.Drawing.Size(172, 20);
            this.TxtGirisEmail.TabIndex = 3;
            // 
            // TxtGirisSifre
            // 
            this.TxtGirisSifre.Location = new System.Drawing.Point(387, 199);
            this.TxtGirisSifre.Name = "TxtGirisSifre";
            this.TxtGirisSifre.PasswordChar = '*';
            this.TxtGirisSifre.Size = new System.Drawing.Size(172, 20);
            this.TxtGirisSifre.TabIndex = 4;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.DarkGreen;
            this.linkLabel1.Location = new System.Drawing.Point(280, 244);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(81, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "*şifremi unuttum";
            // 
            // BtnGirisYap
            // 
            this.BtnGirisYap.BackColor = System.Drawing.Color.Green;
            this.BtnGirisYap.Font = new System.Drawing.Font("Courier New", 11F);
            this.BtnGirisYap.Location = new System.Drawing.Point(358, 290);
            this.BtnGirisYap.Name = "BtnGirisYap";
            this.BtnGirisYap.Size = new System.Drawing.Size(122, 33);
            this.BtnGirisYap.TabIndex = 7;
            this.BtnGirisYap.Text = "Giriş Yap";
            this.BtnGirisYap.UseVisualStyleBackColor = false;
            this.BtnGirisYap.Click += new System.EventHandler(this.BtnGirisYap_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel2.LinkColor = System.Drawing.Color.DarkGreen;
            this.linkLabel2.Location = new System.Drawing.Point(340, 343);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(157, 15);
            this.linkLabel2.TabIndex = 8;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Üye Değil Misiniz? Üye Ol...";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 430);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // FormUyeGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(583, 430);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.BtnGirisYap);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.TxtGirisSifre);
            this.Controls.Add(this.TxtGirisEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormUyeGirisi";
            this.Text = "FormUyeGirisi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtGirisSifre;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button BtnGirisYap;
        private System.Windows.Forms.LinkLabel linkLabel2;
        public System.Windows.Forms.TextBox TxtGirisEmail;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}