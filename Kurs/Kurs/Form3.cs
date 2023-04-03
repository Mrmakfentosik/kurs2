using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurs
{
    public partial class Form3 :Form
    {
        public Form3()
        {

            InitializeComponent();
            
        }
        public  void sda()
        {


            if (Test.back == 0)
            {

               
                panel1.Controls.Clear();
                Form1 f = new Form1();
                f.TopLevel = false;
                panel1.Controls.Add(f);
                f.Show();
               



            }

            else if (Test.back == 1)
            {

                panel1.Controls.Clear();
                Form4 f = new Form4();
                f.TopLevel = false;
                panel1.Controls.Add(f);
                f.Show();



            }
           
          
           
         
        }

        public void button1_Click(object sender, EventArgs e)
        {

            Chose();
            sda();
        }

        public void Chose()
        {
            UserControl7.sex = string.Empty;
            Test.Tovar = "0";
            Test.zavki = "0";
            Test.kat = "0";
            Test.Tender = "0";
            Test.back = 0;
            Test.Vibor = 0;
            Test.Id = "0";
            Test.Info = "0";
            Test.zamena = string.Empty;
        }
        public void Foto()
        {
            DB.GetConn().Close();
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM login WHERE ID={Test.Id_user}", DB.GetConn());
            DB.GetConn().Open();
            MySqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            try
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\Foto\" + rd["Foto"].ToString());
            }
            catch
            {

            }
            DB.GetConn().Close();
        }
        public  void Form3_Activated(object sender, EventArgs e)
        {
            Foto();
            if(Test.zamena == "2")
            {
                panel1.Controls.Clear();
                Form4 f = new Form4();
                f.TopLevel = false;
                panel1.Controls.Add(f);
                f.Show();
            }
           else if (Test.zamena == "1")
            {
                panel1.Controls.Clear();
                Form2 f = new Form2();
                f.TopLevel = false;
                panel1.Controls.Add(f);
                f.Show();
            }
            else if (Test.zamena == "55")
            {
                panel1.Controls.Clear();
                Form1 f = new Form1();
                f.TopLevel = false;
                panel1.Controls.Add(f);
                f.Show();
            }
            else
            {
                if (Test.Id != "0")
                {
                    sda();

                }
                else
                {

                }
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Chose();
            
            Test.kat = "1";
            panel1.Controls.Clear();
            Form4 f = new Form4();
            f.TopLevel = false;
            panel1.Controls.Add(f);
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Chose();
            Test.Tender = "1";
            panel1.Controls.Clear();
            Form7 f = new Form7();
            f.TopLevel = false;
            panel1.Controls.Add(f);
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Chose();
            Test.zavki = "1";
            panel1.Controls.Clear();
            Form4 f = new Form4();
            f.TopLevel = false;
            panel1.Controls.Add(f);
            f.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private async void Form3_Load_1(object sender, EventArgs e)
        {
            
            //var date = new DateTime(2022, 5, 1);
            //if (DateTime.Today > date)
            //    MessageBox.Show("Меньше дня");
            //else
            //    MessageBox.Show("Больше дня");
            if (Test.Royale!="a")
            {
                bunifuFlatButton7.Visible = false;
                bunifuFlatButton6.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                materialLabel5.Visible = false;
                materialLabel6.Visible = false;
             
            }
            if(Test.Royale== "postav" || Test.Royale == "a")
            {
                bunifuFlatButton9.Visible = true;
                materialLabel5.Visible = true;
                materialLabel4.Visible = true;
                pictureBox5.Visible = true;
            }
            else
            {
                bunifuFlatButton9.Visible = false;
                pictureBox5.Visible = false;
                materialLabel6.Visible = false;
                materialLabel4.Visible = false;
            }
            DB.GetConn().Close(); 

                   MySqlCommand cmd = new MySqlCommand($"UPDATE login  Set Datezax='{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}' Where id={Test.Id_user}", DB.GetConn());
            DB.GetConn().Open();
            MySqlDataReader rd = cmd.ExecuteReader();
            DB.GetConn().Close();
            MySqlCommand cmd1 = new MySqlCommand($"INSERT INTO history(Type,ID_user,Date) VALUES('2','{Test.Id_user}','{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}')", DB.GetConn());
            DB.GetConn().Open();
            cmd1.ExecuteNonQuery();
            DB.GetConn().Close();



            for (int a = 0; a <= 900000; a++)
            {
                await Task.Delay(100);
                label1.Text = DateTime.Now.ToString("dd MMMM dddd \n  HH:mm:ss");
            }
        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Chose();
            Test.Info = "1";
            panel1.Controls.Clear();
            Form1 f = new Form1();
            f.TopLevel = false;
            panel1.Controls.Add(f);
            f.Show();
        }
        public void sexa(string id)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
          
            Form9 f = new Form9();

            f.Show();
        }
    }
}
