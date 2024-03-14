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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void buttonGiris_Click(object sender, EventArgs e)
		{
			string kullanıcıAdı = textBoxKullanıcıAdı.Text;
			string sifre= textBoxSifre.Text;

			

			Kullanıcı kullanıcı=SanalDatabase.KullanıcıList.Find(x=> x.KullanıcıAdı==kullanıcıAdı && x.Sifre==sifre);

			string isim = kullanıcı.Isım;
			string soyisim = kullanıcı.Soyisim;
			string açıklama = kullanıcı.Açıklama;

			if(kullanıcı!=null) 
			{
				Form2 form2 = new Form2(kullanıcı);
				form2.Show();
			}
			else 
			{

				MessageBox.Show("Kullanıcı Adı ve Şifre Hatalı","",MessageBoxButtons.OK , MessageBoxIcon.Error);
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
