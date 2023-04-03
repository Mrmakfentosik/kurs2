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
    public partial class UserControl1 : UserControl
    {
        public Button sq = new Button();
        public UserControl1(string id, string photo,string tovar,string count)
        {
           
            this.id = id;
       
             
            InitializeComponent();
            
                pictureBox1.Image = Image.FromFile(@Application.StartupPath + @"\Foto\" + photo);
          
            
              
                label2.Text = $"{tovar}";
                label1.Text = $"Колличество\n{count}";
           
            

        }
        public string id;
        private void UserControl1_Load(object sender, EventArgs e)
        {
          
        }
        public void sa(object sender, EventArgs e)
        {
            MessageBox.Show("dsdas");
        }
        public void button2_Click(object sender, EventArgs e)
        {
           
            Test.Id = id;
            Test.back = 1;
            Form2 s = new Form2();
            s.Show();
            s.Close();





        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            MessageBox.Show("dsadasdasda");
        }
    }
}
