namespace WindowsFormsKullanıcıGirişEkranı
{
	partial class Form2
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
			this.labelKullanıcıAdıForm2 = new System.Windows.Forms.Label();
			this.labelSifreForm2 = new System.Windows.Forms.Label();
			this.textBoxKullanıcıAdıForm2 = new System.Windows.Forms.TextBox();
			this.textBoxSifreForm2 = new System.Windows.Forms.TextBox();
			this.textBoxSoyisim = new System.Windows.Forms.TextBox();
			this.textBoxİsim = new System.Windows.Forms.TextBox();
			this.labelSoyisim = new System.Windows.Forms.Label();
			this.labelİsim = new System.Windows.Forms.Label();
			this.textBoxAcıklama = new System.Windows.Forms.TextBox();
			this.labelAcıklama = new System.Windows.Forms.Label();
			this.buttonGuncelle = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelKullanıcıAdıForm2
			// 
			this.labelKullanıcıAdıForm2.AutoSize = true;
			this.labelKullanıcıAdıForm2.Location = new System.Drawing.Point(24, 64);
			this.labelKullanıcıAdıForm2.Name = "labelKullanıcıAdıForm2";
			this.labelKullanıcıAdıForm2.Size = new System.Drawing.Size(79, 16);
			this.labelKullanıcıAdıForm2.TabIndex = 0;
			this.labelKullanıcıAdıForm2.Text = "Kullanıcı Adı";
			// 
			// labelSifreForm2
			// 
			this.labelSifreForm2.AutoSize = true;
			this.labelSifreForm2.Location = new System.Drawing.Point(24, 94);
			this.labelSifreForm2.Name = "labelSifreForm2";
			this.labelSifreForm2.Size = new System.Drawing.Size(34, 16);
			this.labelSifreForm2.TabIndex = 1;
			this.labelSifreForm2.Text = "Şifre";
			// 
			// textBoxKullanıcıAdıForm2
			// 
			this.textBoxKullanıcıAdıForm2.Location = new System.Drawing.Point(117, 58);
			this.textBoxKullanıcıAdıForm2.Name = "textBoxKullanıcıAdıForm2";
			this.textBoxKullanıcıAdıForm2.Size = new System.Drawing.Size(178, 22);
			this.textBoxKullanıcıAdıForm2.TabIndex = 2;
			// 
			// textBoxSifreForm2
			// 
			this.textBoxSifreForm2.Location = new System.Drawing.Point(117, 88);
			this.textBoxSifreForm2.Name = "textBoxSifreForm2";
			this.textBoxSifreForm2.Size = new System.Drawing.Size(178, 22);
			this.textBoxSifreForm2.TabIndex = 3;
			// 
			// textBoxSoyisim
			// 
			this.textBoxSoyisim.Location = new System.Drawing.Point(410, 88);
			this.textBoxSoyisim.Name = "textBoxSoyisim";
			this.textBoxSoyisim.Size = new System.Drawing.Size(178, 22);
			this.textBoxSoyisim.TabIndex = 7;
			// 
			// textBoxİsim
			// 
			this.textBoxİsim.Location = new System.Drawing.Point(410, 58);
			this.textBoxİsim.Name = "textBoxİsim";
			this.textBoxİsim.Size = new System.Drawing.Size(178, 22);
			this.textBoxİsim.TabIndex = 6;
			// 
			// labelSoyisim
			// 
			this.labelSoyisim.AutoSize = true;
			this.labelSoyisim.Location = new System.Drawing.Point(317, 94);
			this.labelSoyisim.Name = "labelSoyisim";
			this.labelSoyisim.Size = new System.Drawing.Size(55, 16);
			this.labelSoyisim.TabIndex = 5;
			this.labelSoyisim.Text = "Soyisim";
			// 
			// labelİsim
			// 
			this.labelİsim.AutoSize = true;
			this.labelİsim.Location = new System.Drawing.Point(317, 64);
			this.labelİsim.Name = "labelİsim";
			this.labelİsim.Size = new System.Drawing.Size(31, 16);
			this.labelİsim.TabIndex = 4;
			this.labelİsim.Text = "İsim";
			// 
			// textBoxAcıklama
			// 
			this.textBoxAcıklama.Location = new System.Drawing.Point(27, 167);
			this.textBoxAcıklama.Multiline = true;
			this.textBoxAcıklama.Name = "textBoxAcıklama";
			this.textBoxAcıklama.Size = new System.Drawing.Size(568, 99);
			this.textBoxAcıklama.TabIndex = 8;
			// 
			// labelAcıklama
			// 
			this.labelAcıklama.AutoSize = true;
			this.labelAcıklama.Location = new System.Drawing.Point(24, 148);
			this.labelAcıklama.Name = "labelAcıklama";
			this.labelAcıklama.Size = new System.Drawing.Size(63, 16);
			this.labelAcıklama.TabIndex = 9;
			this.labelAcıklama.Text = "Açıklama";
			// 
			// buttonGuncelle
			// 
			this.buttonGuncelle.BackColor = System.Drawing.SystemColors.ControlDark;
			this.buttonGuncelle.Location = new System.Drawing.Point(493, 283);
			this.buttonGuncelle.Name = "buttonGuncelle";
			this.buttonGuncelle.Size = new System.Drawing.Size(75, 28);
			this.buttonGuncelle.TabIndex = 10;
			this.buttonGuncelle.Text = "Güncelle";
			this.buttonGuncelle.UseVisualStyleBackColor = false;
			this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(640, 347);
			this.Controls.Add(this.buttonGuncelle);
			this.Controls.Add(this.labelAcıklama);
			this.Controls.Add(this.textBoxAcıklama);
			this.Controls.Add(this.textBoxSoyisim);
			this.Controls.Add(this.textBoxİsim);
			this.Controls.Add(this.labelSoyisim);
			this.Controls.Add(this.labelİsim);
			this.Controls.Add(this.textBoxSifreForm2);
			this.Controls.Add(this.textBoxKullanıcıAdıForm2);
			this.Controls.Add(this.labelSifreForm2);
			this.Controls.Add(this.labelKullanıcıAdıForm2);
			this.Name = "Form2";
			this.Text = "Kullanıcı Bilgileri";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelKullanıcıAdıForm2;
		private System.Windows.Forms.Label labelSifreForm2;
		private System.Windows.Forms.TextBox textBoxKullanıcıAdıForm2;
		private System.Windows.Forms.TextBox textBoxSifreForm2;
		private System.Windows.Forms.TextBox textBoxSoyisim;
		private System.Windows.Forms.TextBox textBoxİsim;
		private System.Windows.Forms.Label labelSoyisim;
		private System.Windows.Forms.Label labelİsim;
		private System.Windows.Forms.TextBox textBoxAcıklama;
		private System.Windows.Forms.Label labelAcıklama;
		private System.Windows.Forms.Button buttonGuncelle;
	}
}