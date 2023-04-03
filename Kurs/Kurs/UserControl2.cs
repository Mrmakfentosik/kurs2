using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kurs
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2(string id, string photo, string tovar, string count, string comment, string summ, string Totalsumm,string man,string model)
        {
            InitializeComponent();
            int cc = Convert.ToInt32(count);
            if (cc <= 0)
            {
                Test.back = 0;
                Test.Id = "3";
                Test.zamena = "3";
                Form2 s = new Form2();
                s.Show();
                s.Close();
            }
            else
            {
                pictureBox1.Image = Image.FromFile(@Application.StartupPath + @"\Foto\" + photo);
                if (Test.Royale == "a")
                {
                    bunifuMetroTextbox2.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    MaterialFlatButton butt =
                   new MaterialFlatButton();
                    butt.Text = "Удалить";
                    butt.Size = new Size(230, 30);
                    butt.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                    butt.Dock = DockStyle.Fill;
                    butt.Click += new System.EventHandler(gClick);
                    tableLayoutPanel5.Controls.Add(butt);
                    MaterialFlatButton butt1 =
                  new MaterialFlatButton();
                    butt1.Text = "Изменить";
                    butt1.Size = new Size(230, 30);
                    butt1.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                    butt1.Dock = DockStyle.Fill;

                    tableLayoutPanel6.Controls.Add(butt1);
                    butt1.Click += new System.EventHandler(gClick1);


                }
                else if (Test.kat == "1" && Test.Royale != "a")
                {
                    label1.Dock = DockStyle.Bottom;
                }
                else
                {
                    bunifuMetroTextbox2.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    tableLayoutPanel6.Visible = false;
                    tableLayoutPanel5.Visible = false;
                    MaterialFlatButton butt1 =
                   new MaterialFlatButton();
                    butt1.Text = "Купить";
                    butt1.Size = new Size(230, 30);
                    butt1.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                    butt1.Dock = DockStyle.Fill;
                    tableLayoutPanel4.ColumnStyles[1].Width = 0;
                    tableLayoutPanel4.Controls.Add(butt1);
                    butt1.Click += new System.EventHandler(gClick3);
                }

                this.id = id;
                this.photo = photo;
                this.tovar = tovar;
                this.count = count;
                b = Convert.ToInt32(count);
                this.comment = comment;
                label2.Text = $"{tovar}";
                label1.Text = $"Цена за 1ед {summ}\nКолличество\n{count} ";
                materialLabel1.Text =$"Производитель:{man}\nМодель:{model}\n{comment}";
                this.sum = summ;
                this.Totalsum = Totalsumm;
            }
            this.man = man;
            this.model = model;
        }
        public string  photo, tovar, count, comment,sum,id, Totalsum, man, model;
        private void button2_Click(object sender, EventArgs e)
        {
            //MySqlCommand cmd = new MySqlCommand("Insert into AKZ (sex,Title,Cost) Values('1','1','1')", conn);
            //conn.Open();
            //MySqlDataReader rd = cmd.ExecuteReader();
            //rd.Read();
            //conn.Close();
            //rd.Close();
            if (UserControl7.sex == "gaga11")
            {
                Test.zamena = "2"; Test.Id="0";  Test.kat = "1"; Test.zavki = "0"; Test.Tender = "0"; Test.back = 0;
                Form2 s = new Form2();
                s.Show();
                s.Close();
            }
           else if (UserControl7.sex == "gaga")
            {
                Test.Info = "1"; Test.Tender = "0"; Test.kat = "0"; Test.zavki = "0"; Test.back = 1;
                Form2 s = new Form2();
                s.Show();
                s.Close();
            }
                else {
                        Test.back = 0;
                        Test.Id = "3";
                        Test.zamena = "3";
                        Form2 s = new Form2();
                        s.Show();
                        s.Close();
                    }

        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
           
        }
        public void gClick(object sender, EventArgs e)
        {
            DB.GetConn().Close();
            MySqlCommand cmd1 = new MySqlCommand($"INSERT INTO purchased(Foto, Title, Cost, Coment, summ, TotalSum, manufacturer, model) VALUES ('{photo}','{tovar}','{count}','{comment}','{sum}','{Totalsum}','{man}','{model}')", DB.GetConn());
            DB.GetConn().Open();
            cmd1.ExecuteNonQuery();
            DB.GetConn().Close();
            MySqlCommand cmd2 = new MySqlCommand($"INSERT INTO history(Type,ID_user,Date) VALUES('5','{Test.Id_user}','{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}')", DB.GetConn());
            DB.GetConn().Open();
            cmd2.ExecuteNonQuery();
            DB.GetConn().Close();
            MySqlCommand cmd = new MySqlCommand($"DELETE FROM tovar WHERE ID={Test.Id};DELETE FROM manufacturer WHERE ID_Tovar={Test.Id}", DB.GetConn());
            DB.GetConn().Open();
             cmd.ExecuteReader();
            DB.GetConn().Close();
            MessageBox.Show("Товар удалён");
            Test.back = 0;
            Test.zamena = "3";
            Form2 s = new Form2();
            s.Show();
            s.Close();



        }
       public int a=1,b;
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            a += 1;
             if (a > b)
            {
                a -= 0;
            }
            bunifuMetroTextbox2.Text = a.ToString();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            a -= 1;
            if (a < 0)
            {
                a = 0;
            }
            else if(a>b)
            {
                a -= 0;
            }
            bunifuMetroTextbox2.Text = a.ToString();
        }

        private void bunifuMetroTextbox2_OnValueChanged(object sender, EventArgs e)
        {
              if (a > b)
            {

                a = 0;
                MessageBox.Show("Больше чем количества на складе");
            }
            a = Convert.ToInt32(bunifuMetroTextbox2.Text);
        }

        private void bunifuMetroTextbox2_MouseLeave(object sender, EventArgs e)
        {
            if (a > b)
            {

                a = 0;
                MessageBox.Show("Больше чем количества на складе");
            }
            a = Convert.ToInt32(bunifuMetroTextbox2.Text);
        }

        private void bunifuMetroTextbox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                return;
            }
            else
                {
                    e.Handled = true;
                }
            

        }

        public void gClick3(object sender, EventArgs e)
        {
            sum = sum.Substring(0, sum.Length - 7);
            int g = Convert.ToInt32(sum);
            
            int Gaga = g*a;
            DialogResult dialogResult = MessageBox.Show($"Ваша итоговая цена {Gaga}\n вы согласны? ", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                MySqlCommand cmd1 = new MySqlCommand($"INSERT INTO history(Type,ID_user,Date) VALUES('3','{Test.Id_user}','{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}')", DB.GetConn());
                DB.GetConn().Open();
                cmd1.ExecuteNonQuery();
                DB.GetConn().Close();
                int totalsuma = Convert.ToInt32(Totalsum);
                DB.GetConn().Close();
                MySqlCommand cmd = new MySqlCommand($"INSERT INTO kat1(ID_TOVAR, Sum, TotalSum, ID_user,cost) VALUES('{id}', '{Gaga}', '', '{Test.Id_user}', '{a}');update Tovar Set cost={b - a},TotalSum='{totalsuma- Gaga}' where ID={id};", DB.GetConn());
                DB.GetConn().Open(); 
                MySqlDataReader rd = cmd.ExecuteReader();
                
                DB.GetConn().Close();
                rd.Close();
                MessageBox.Show("Товар добавлен в корзину");
            }
            else if (dialogResult == DialogResult.No)
            {
              
            }
           


        }
        public static string PLZ; 
        public void gClick1(object sender, EventArgs e)
        {
          
            Form2 f = new Form2();


           


            Test.Tovar = "1";
            Test.prost = "0";
          
            Test.zamena = "1";
            f.Show();
            f.Close();
         


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
