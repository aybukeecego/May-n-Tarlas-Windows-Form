namespace FormControls
{
    public partial class frmKayýt : Form
    {
        public frmKayýt()
        {
            InitializeComponent();
        }


        private void btnÖnizleme_Click(object sender, EventArgs e)
        {
            FormÖnizleme önizleme = new FormÖnizleme();

            
            ((TextBox)önizleme.Controls["txtNameÖnzl"]).Text=
            ((TextBox)önizleme.Controls["txtSurnameÖnzl"]).Text = txtSurname.Text;
            ((TextBox)önizleme.Controls["txtEmailÖnzl"]).Text = txtEmail.Text;
            ((TextBox)önizleme.Controls["txtNumberÖnzl"]).Text = txtNumber.Text;

            önizleme.ShowDialog();

        }
    }
}