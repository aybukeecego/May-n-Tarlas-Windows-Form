using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FormControls
{
    public partial class FormÖnizleme : Form
    {
        public FormÖnizleme()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Müşteri müşteri = new Müşteri();

 
            müşteri.Name = txtNameÖnzl.Text;
            müşteri.Surname = txtSurnameÖnzl.Text;
            müşteri.Email = txtEmailÖnzl.Text;
            müşteri.Phone = txtNumberÖnzl.Text;


            SanalDataBase.Ekle(müşteri);
        }
    }
}
