namespace FormControls
{
    public partial class frmKay�t : Form
    {
        public frmKay�t()
        {
            InitializeComponent();
        }


        private void btn�nizleme_Click(object sender, EventArgs e)
        {
            Form�nizleme �nizleme = new Form�nizleme();

            
            ((TextBox)�nizleme.Controls["txtName�nzl"]).Text=
            ((TextBox)�nizleme.Controls["txtSurname�nzl"]).Text = txtSurname.Text;
            ((TextBox)�nizleme.Controls["txtEmail�nzl"]).Text = txtEmail.Text;
            ((TextBox)�nizleme.Controls["txtNumber�nzl"]).Text = txtNumber.Text;

            �nizleme.ShowDialog();

        }
    }
}