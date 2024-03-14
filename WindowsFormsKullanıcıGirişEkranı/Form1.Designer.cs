namespace WindowsFormsKullanıcıGirişEkranı
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.labelKullanıcıAdı = new System.Windows.Forms.Label();
			this.textBoxKullanıcıAdı = new System.Windows.Forms.TextBox();
			this.textBoxSifre = new System.Windows.Forms.TextBox();
			this.labelSifre = new System.Windows.Forms.Label();
			this.buttonGiris = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox
			// 
			this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
			this.pictureBox.Location = new System.Drawing.Point(36, 76);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(178, 157);
			this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox.TabIndex = 0;
			this.pictureBox.TabStop = false;
			// 
			// labelKullanıcıAdı
			// 
			this.labelKullanıcıAdı.AutoSize = true;
			this.labelKullanıcıAdı.Location = new System.Drawing.Point(260, 97);
			this.labelKullanıcıAdı.Name = "labelKullanıcıAdı";
			this.labelKullanıcıAdı.Size = new System.Drawing.Size(82, 16);
			this.labelKullanıcıAdı.TabIndex = 1;
			this.labelKullanıcıAdı.Text = "Kullanıcı Adı:";
			// 
			// textBoxKullanıcıAdı
			// 
			this.textBoxKullanıcıAdı.Location = new System.Drawing.Point(383, 91);
			this.textBoxKullanıcıAdı.Name = "textBoxKullanıcıAdı";
			this.textBoxKullanıcıAdı.Size = new System.Drawing.Size(208, 22);
			this.textBoxKullanıcıAdı.TabIndex = 2;
			// 
			// textBoxSifre
			// 
			this.textBoxSifre.Location = new System.Drawing.Point(383, 137);
			this.textBoxSifre.Name = "textBoxSifre";
			this.textBoxSifre.Size = new System.Drawing.Size(208, 22);
			this.textBoxSifre.TabIndex = 4;
			// 
			// labelSifre
			// 
			this.labelSifre.AutoSize = true;
			this.labelSifre.Location = new System.Drawing.Point(260, 143);
			this.labelSifre.Name = "labelSifre";
			this.labelSifre.Size = new System.Drawing.Size(37, 16);
			this.labelSifre.TabIndex = 3;
			this.labelSifre.Text = "Şifre:";
			// 
			// buttonGiris
			// 
			this.buttonGiris.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.buttonGiris.Location = new System.Drawing.Point(494, 194);
			this.buttonGiris.Name = "buttonGiris";
			this.buttonGiris.Size = new System.Drawing.Size(97, 39);
			this.buttonGiris.TabIndex = 5;
			this.buttonGiris.Text = "Giriş Yap";
			this.buttonGiris.UseVisualStyleBackColor = false;
			this.buttonGiris.Click += new System.EventHandler(this.buttonGiris_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(708, 351);
			this.Controls.Add(this.buttonGiris);
			this.Controls.Add(this.textBoxSifre);
			this.Controls.Add(this.labelSifre);
			this.Controls.Add(this.textBoxKullanıcıAdı);
			this.Controls.Add(this.labelKullanıcıAdı);
			this.Controls.Add(this.pictureBox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.Label labelKullanıcıAdı;
		private System.Windows.Forms.TextBox textBoxKullanıcıAdı;
		private System.Windows.Forms.TextBox textBoxSifre;
		private System.Windows.Forms.Label labelSifre;
		private System.Windows.Forms.Button buttonGiris;
	}
}

