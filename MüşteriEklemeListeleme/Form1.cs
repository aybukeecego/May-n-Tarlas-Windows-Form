namespace MüşteriEklemeListeleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int result = yeniMüsteriEkle(new Müşteri()
            {
                Id = 1,
                İsim=txtBoxİsim.Text,
                Soyisim=txtBoxSoyisim.Text,
                Email=txtBoxMail.Text

            });
            if (result > 0) 
            {
                DialogResult res =MessageBox.Show("Müşteri ekleme işlemi başarılı","Müşteri ekleme",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    bildirimcbg = new NotifyIcon();
                    bildirimcbg.BalloonTipText = "Eklenen Müşteri Sayısı" + SanalDatabase.Müşteriler.Count.ToString();
                    bildirimcbg.BalloonTipTitle = "Müşteri adet bilgisi";
                    bildirimcbg.Visible = true;
                    bildirimcbg.Icon = SystemIcons.Information;
                    bildirimcbg.ShowBalloonTip(2000);

                }
                else if (res == DialogResult.No)
                {

                }

                EkranTemizle();
                EkranListe();
            }
            else 
            {
                MessageBox.Show("Hata");
            }
        }
        private int yeniMüsteriEkle(Müşteri müşteri) 
        {
            SanalDatabase.Müşteriler.Add(müşteri);
            return 1;
        }
        private void EkranTemizle() 
        {
            txtBoxİsim.Text = string.Empty;
            txtBoxSoyisim.Text = string.Empty;
            txtBoxMail.Text = string.Empty;
        }

        private void EkranListe() 
        {
            dgwLst.DataSource = SanalDatabase.Müşteriler;
        }
    }
}