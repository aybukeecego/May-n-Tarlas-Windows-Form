using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsKullanıcıGirişEkranı
{
	public partial class Form2 : Form
	{
		public Form2 (Kullanıcı bulunanKullanıcı)
		{
			InitializeComponent();

			textBoxİsim.Text = bulunanKullanıcı.Isım;
			textBoxSoyisim.Text = bulunanKullanıcı.Soyisim;
			textBoxKullanıcıAdıForm2.Text = bulunanKullanıcı.KullanıcıAdı;
			textBoxKullanıcıAdıForm2.Enabled= false;
			textBoxSifreForm2.Text = bulunanKullanıcı.Sifre;
			textBoxAcıklama.Text = bulunanKullanıcı.Açıklama;

			buttonGuncelle.Tag = bulunanKullanıcı.Id;

		}

		private void Form2_Load(object sender, EventArgs e)
		{

		}

		private void buttonGuncelle_Click(object sender, EventArgs e)
		{
			int id = (int)buttonGuncelle.Tag;

			Kullanıcı kullanıcı = SanalDatabase.KullanıcıList.Find(x => x.Id == id);

			if (kullanıcı != null) 
			{
				if (kullanıcı.Isım == textBoxİsim.Text && kullanıcı.Soyisim == textBoxSoyisim.Text && kullanıcı.Sifre==textBoxSifreForm2.Text && kullanıcı.Açıklama==textBoxAcıklama.Text) 
				{
					MessageBox.Show("Girdiğiniz isim önceki isim ile aynı");
				}

				kullanıcı.Isım=textBoxİsim.Text;
				kullanıcı.Soyisim = textBoxSoyisim.Text;
				kullanıcı.Sifre = textBoxSifreForm2.Text;
				kullanıcı.Açıklama = textBoxAcıklama.Text;

			}
			else
				MessageBox.Show("Kullanıcı Bulunamadı","Hata",MessageBoxButtons.OK, MessageBoxIcon.Error);

			MessageBox.Show("Başarılı");
		}
	}
}
