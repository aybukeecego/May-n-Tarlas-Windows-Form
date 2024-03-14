using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsKullanıcıGirişEkranı
{
	internal class SanalDatabase
	{
		public static List<Kullanıcı> KullanıcıList = new List<Kullanıcı>();

		static SanalDatabase() 
		{
			KullanıcıList.Add(new Kullanıcı()
			{
				Id= 1,
				Isım="Aybuke",
				Soyisim="Aktaş",
				KullanıcıAdı="aybukecego",
				Sifre="1234",
				Açıklama="AAA"
			});

			KullanıcıList.Add(new Kullanıcı()
			{
				Id = 2,
				Isım="Burak",
				Soyisim="Aktaş",
				KullanıcıAdı = "burak.akts",
				Sifre = "123456",
				Açıklama = "BBB"
			});
		}
		
	}
}
