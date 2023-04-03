using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurs
{
    public partial class UserControl8 : UserControl
    {
        public UserControl8(string id,string title,string cost,string status,string foto,string coment)
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(@Application.StartupPath + @"\Foto\" + foto);
            if (status == "Ожидание")
            {
                pictureBox2.Image = Image.FromFile(@Application.StartupPath + @"\Foto\Ожидание.png");
            }
            else if(status == "Отменено")
            {
                pictureBox2.Image = Image.FromFile(@Application.StartupPath + @"\Foto\Отмена.png");
            }
            else
            {
                pictureBox2.Image = Image.FromFile(@Application.StartupPath + @"\Foto\Принятие.png");
            }

            label2.Text = $"{title}\n {coment}";
            label1.Text = $"Колличество\n{cost}";
            materialLabel1.Text =$"{status}";
            this.id = id;
        }
        public string id;
        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
          
            Test.Id_zavki = id;
            Test.back = 1;
            Test.Id = "1";
            UserControl7.sex = "gaga11";
            Form2 s = new Form2();
            s.Show();
            s.Close();
           
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
