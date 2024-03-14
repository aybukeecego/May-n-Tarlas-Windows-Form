using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mayın_Tarlası
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        


        private void btnUret_Click(object sender, EventArgs e)
        {
            int mayin1 = 0;
            int mayin2 = 0;
            int mayin3 = 0;

            Random rnd = new Random();

            mayin1 = rnd.Next(1, 20);
            mayin2 = rnd.Next(21,40);
            mayin3 = rnd.Next(41, 50);

            for (int i=1; i<=50; i++) 
            {
                Button btnTemp= new Button();
                btnTemp.Name = "btnTemp";
                btnTemp.Size = new System.Drawing.Size(35,35);
                btnTemp.Text= i.ToString();
                btnTemp.UseVisualStyleBackColor = true;
                if(mayin1==i || mayin2==i || mayin3 == i) 
                {
                    btnTemp.Tag = true;

                }
                else
                {
                    btnTemp.Tag = false;
                }

                btnTemp.Click += BtnTemp_Click;
                flowLayoutPanel.Controls.Add(btnTemp);
            }

        }

        private void BtnTemp_Click(object sender, EventArgs e)
        {
            Button basılanButon= (Button)sender;

            bool mayınBulundu = (bool)basılanButon.Tag;

            int gösterge = 0;
            lblMayınGösterge.Text = gösterge.ToString();
            int skor = 0;
            lblSkorGösterge.Text = skor.ToString();

            if (mayınBulundu)
            {
                MessageBox.Show("Mayın");
                basılanButon.BackColor = Color.Red;
                gösterge++;
                lblMayınGösterge.Text=gösterge.ToString();

            }
            else
            {
                basılanButon.BackColor = Color.Green;
                skor++;
                lblSkorGösterge.Text+= skor.ToString();
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

//this.btnTemp.Location = new System.Drawing.Point(3, 3);
//this.btnTemp.Name = "btnTemp";
//this.btnTemp.Size = new System.Drawing.Size(45, 40);
//this.btnTemp.TabIndex = 0;
//this.btnTemp.Text = "1";
//this.btnTemp.UseVisualStyleBackColor = true;
