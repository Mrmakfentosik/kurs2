using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.IO;

namespace Kurs
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            if (Test.Tovar == "1"&&  Test.prost == "1"&& Test.zamena == "0")
            {
                Test.kat = "1"; Test.zavki = "0"; Test.Tender = "0";
                Test.zamena = "2";
                Form2 s = new Form2();
                s.Show();
                s.Close();
            }
            else
            {
                Test.back = 0;
                Test.zamena = "0";
                Test.Id = "1";
                Form2 s = new Form2();
                s.Show();
                s.Close();
            }


        }
        public int random;
        public int zav;
        private void Form2_Load(object sender, EventArgs e)
        {
            DB.GetConn().Close();
            MySqlCommand cmd1 = new MySqlCommand($"Select * From login Where ID={Test.Id_user}", DB.GetConn());
            DB.GetConn().Open();
            MySqlDataReader rd1 = cmd1.ExecuteReader();
            if (rd1.Read())
            {
                zav = Convert.ToInt32(rd1[13].ToString());

            }
           
            DB.GetConn().Close();
            rd1.Close();
            if (Test.zamena == "1" )
            {
                try
                {
                    DB.GetConn().Close();

                    MySqlCommand cmd = new MySqlCommand($"SELECT tovar.*,manufacturer.* FROM tovar,manufacturer WHERE tovar.ID_man=manufacturer.ID and tovar.ID={Test.Id}", DB.GetConn());
                    DB.GetConn().Open();
                    MySqlDataReader rd = cmd.ExecuteReader();
                    if (rd.Read())
                    {

                       path1= rd[4].ToString();
                        bunifuMetroTextbox1.Text = rd[1].ToString();

                        bunifuMetroTextbox2.Value = Convert.ToInt32(rd[3].ToString());

                        textBox1.Text = rd[2].ToString();
                        bunifuMetroTextbox3.Value =Convert.ToInt32(rd[5].ToString().Substring(0, rd[5].ToString().Length - 7));
                        pictureBox1.Image = Image.FromFile(@Application.StartupPath + @"\Foto\" + rd[4].ToString());
                        imageComboBoxEdit1.SelectedIndex = Convert.ToInt32(rd[7].ToString());
                        bunifuMetroTextbox5.Text= rd[10].ToString();
                        bunifuMetroTextbox6.Text = rd[11].ToString();
                        random = Convert.ToInt32(rd[12].ToString());
                    }
                   
                    DB.GetConn().Close();
                    rd.Close();
                    imageComboBoxEdit1.SelectedIndex -= 1;
                   
                }
                catch {
                   
                 
                   
                  
                       

                 
                   

                }
              
            }
            else if(Test.zamena == "3")
            {

            }
            else
            {
                if (Test.back == 1)
                {
                    DB.GetConn().Close();

                    MySqlCommand cmd = new MySqlCommand($"SELECT * FROM Tovar Where id={Test.Id}", DB.GetConn());
                    DB.GetConn().Open();
                    MySqlDataReader rd = cmd.ExecuteReader();
                    if (rd.Read()) { 


                    bunifuMetroTextbox1.Text = rd["title"].ToString();
                    bunifuMetroTextbox2.Value = Convert.ToInt32(rd["cost"].ToString());


                }
                    DB.GetConn().Close();
                    rd.Close();
                }
            }
        }
        public string path= string.Empty, path1= string.Empty;

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            if (bunifuMetroTextbox1.Text == string.Empty || bunifuMetroTextbox2.Text == string.Empty || textBox1.Text == string.Empty)
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                if (path1 == string.Empty  )
                {
                    MessageBox.Show("Выберите фото");
                }
                else
                {
                    if (a == 0)
                    {
                        MessageBox.Show("количества не может быть 0");
                    }
                    else
                    {
                        if (Test.prost == "0" && Test.zamena == "1")
                        {
                            DB.GetConn().Close();
                            try
                            {
                                File.Copy(path, Application.StartupPath + @"\Foto\" + path1);
                            }
                            catch
                            {

                            }
                            DB.GetConn().Close();
                            MySqlCommand cmd1 = new MySqlCommand($"INSERT INTO history(Type,ID_user,Date) VALUES('4','{Test.Id_user}','{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}')", DB.GetConn());
                            DB.GetConn().Open();
                            cmd1.ExecuteNonQuery();
                            DB.GetConn().Close();
                            int s1;
                            s1 = Convert.ToInt32(bunifuMetroTextbox3.Value);
                            MySqlCommand cmd = new MySqlCommand($"UPDATE Tovar  Set Title='{bunifuMetroTextbox1.Text}',comment='{textBox1.Text}',cost='{bunifuMetroTextbox2.Text}', Foto='{path1}', Sum='{bunifuMetroTextbox3.Value + " Рублей"} ', TotalSum='{a*s1}', Type='{imageComboBoxEdit1.SelectedIndex+1}' Where id={Test.Id};UPDATE manufacturer SET Manufacturer='{bunifuMetroTextbox5.Text}', model='{bunifuMetroTextbox6.Text}', Unique_number={random} WHERE ID_Tovar={Test.Id}  ", DB.GetConn());
                            DB.GetConn().Open();
                             cmd.ExecuteReader();
                            DB.GetConn().Close();
                            MessageBox.Show("Товар измнён");
                            Test.back = 0;
                            Test.zamena = "0";
                            Test.Id = "1";
                            Form2 s = new Form2();
                            s.Show();
                            s.Close();
                        }
                            if (Test.Tovar == "1" && Test.zamena == "0"&& Test.prost == "1")
                        {
                        
                            DB.GetConn().Close();
                            try
                            {
                                File.Copy(path, Application.StartupPath + @"\Foto\" + path1);
                            }
                            catch
                            {

                            }
                            DB.GetConn().Close();
                            MySqlCommand cmd4 = new MySqlCommand($"INSERT INTO history(Type,ID_user,Date) VALUES('6','{Test.Id_user}','{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}')", DB.GetConn());
                            DB.GetConn().Open();
                            cmd4.ExecuteNonQuery();
                            DB.GetConn().Close();
                            Random rnd = new Random();
                            int s1 = Convert.ToInt32(bunifuMetroTextbox3.Value);
                            MySqlCommand cmd = new MySqlCommand($"Insert into zavki (Title,comment,Cost,ID_user,status,Foto,sum,totalsum,Type) Values('{bunifuMetroTextbox1.Text}','{textBox1.Text}','{bunifuMetroTextbox2.Value}','{Test.Id_user}','{1}','{path1}','{bunifuMetroTextbox3.Value + " Рублей"} ','{a * s1}','{imageComboBoxEdit1.SelectedIndex + 1}');Update login set zav={zav+1} Where id={Test.Id_user}", DB.GetConn());
                            DB.GetConn().Open();
                             cmd.ExecuteReader();
                            DB.GetConn().Close();
                         
                            MySqlCommand cmd1 = new MySqlCommand($"INSERT INTO manufacturer(Manufacturer, model, Unique_number, ID_zavki) VALUES('{ bunifuMetroTextbox5.Text}','{ bunifuMetroTextbox6.Text}',{ rnd.Next(0, 2147483600)},(SELECT MAX(ID) FROM zavki))", DB.GetConn());
                            DB.GetConn().Open();
                            cmd1.ExecuteReader();
                            DB.GetConn().Close();
                            MySqlCommand cmd2 = new MySqlCommand($"SELECT * FROM manufacturer WHERE ID_zavki = (SELECT max(id) FROM zavki)", DB.GetConn());
                            DB.GetConn().Open();
                            string id = "0", idman = "0";
                            MySqlDataReader rs = cmd2.ExecuteReader();
                            if (rs.Read())
                            {
                                id = rs[0].ToString();
                                idman = rs[5].ToString();
                            }
                            rs.Close();
                            DB.GetConn().Close();
                            MySqlCommand cmd3 = new MySqlCommand($" Update zavki set ID_man ={id} Where id={idman}", DB.GetConn());
                            DB.GetConn().Open();
                            cmd3.ExecuteNonQuery();
                            DB.GetConn().Close();
                            //Update Tovar set ID_man = (SELECT manufacturer.ID FROM manufacturer,Tovar Where Tovar.ID manufacturer.ID_Tovar))
                            MessageBox.Show("Товар добавлен");
                            Test.kat = "1"; Test.zavki = "0"; Test.Tender = "0";
                            Test.zamena = "2";
                            Form2 s = new Form2();
                            s.Show();
                            s.Close();

                        }
                        else if (Test.Tovar == "1" && Test.prost=="1")
                        {
                            DB.GetConn().Close();
                            try
                            {
                                File.Copy(path, Application.StartupPath + @"\Foto\" + path1);
                            }
                            catch
                            {

                            }
                            Random rnd = new Random();
                            int s1 = Convert.ToInt32(bunifuMetroTextbox3.Value);
                            MySqlCommand cmd = new MySqlCommand($"Insert into Tovar (Title,comment,Cost,Foto,sum,totalsum,Type) Values('{bunifuMetroTextbox1.Text}','{textBox1.Text}','{bunifuMetroTextbox2.Value}','{path1}','{bunifuMetroTextbox3.Value + " Рублей"} ','{a * s1}','{imageComboBoxEdit1.SelectedIndex+1}')", DB.GetConn());
                            DB.GetConn().Open();
                            cmd.ExecuteReader();
                            DB.GetConn().Close();
                            MySqlCommand cmd1 = new MySqlCommand($"INSERT INTO manufacturer(Manufacturer, model, Unique_number, ID_Tovar) VALUES('{ bunifuMetroTextbox5.Text}','{ bunifuMetroTextbox6.Text}',{ rnd.Next(0, 2147483600)},(SELECT MAX(ID) FROM tovar))", DB.GetConn());
                            DB.GetConn().Open();
                            cmd1.ExecuteReader();
                            DB.GetConn().Close();
                            MySqlCommand cmd2 = new MySqlCommand($"SELECT * FROM manufacturer WHERE ID_Tovar = (SELECT max(id) FROM tovar)", DB.GetConn());
                            DB.GetConn().Open();
                            string id="0", idman="0";
                            MySqlDataReader rs= cmd2.ExecuteReader();
                            if(rs.Read())
                            {
                                id = rs[0].ToString();
                                idman = rs[4].ToString();
                            }
                            rs.Close();
                            DB.GetConn().Close();
                            MySqlCommand cmd3 = new MySqlCommand($" Update Tovar set ID_man ={id} Where id={idman}", DB.GetConn());
                            DB.GetConn().Open();
                            cmd3.ExecuteNonQuery();
                            DB.GetConn().Close();
                            //Update Tovar set ID_man = (SELECT manufacturer.ID FROM manufacturer,Tovar Where Tovar.ID manufacturer.ID_Tovar))
                            MessageBox.Show("Товар добавлен");
                            Test.back = 0;
                            Test.zamena = "0";
                            Test.Id = "1";
                            Form2 s = new Form2();
                            s.Show();
                            s.Close();
                        }
                    }
                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void bunifuMetroTextbox4_OnValueChanged(object sender, EventArgs e)
        {
          
        }
        int a=1;
       

      

      

      
        OpenFileDialog ff = new OpenFileDialog();

      



        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            int a = Convert.ToInt32(bunifuMetroTextbox2.Value);
            int s1 = Convert.ToInt32(bunifuMetroTextbox3.Value);
            materialLabel5.Text = "Сумма поставки " + (a * s1).ToString() + " Рублей";
        }

        private void bunifuMetroTextbox3_ValueChanged(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(bunifuMetroTextbox2.Value);
            int s1 = Convert.ToInt32(bunifuMetroTextbox3.Value);
            materialLabel5.Text = "Сумма поставки " + (a * s1).ToString() + " Рублей";

        }

        private void imageComboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(imageComboBoxEdit1.SelectedIndex.ToString());
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            ff.Filter = "Файлы изображений (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";

          
            if(ff.ShowDialog()!=DialogResult.Cancel)
            {
            
                var size = new FileInfo(ff.FileName).Length;
                int gg = Convert.ToInt32(size);
                if(gg>= 1085117)
                {
                    MessageBox.Show("Файл слишком большой");
                }
                else
                {

                    path = ff.FileName;
                    path1 = ff.SafeFileName;
                    pictureBox1.Image = Image.FromFile(path);
                }
              
              
               
              

            }
        }
    }
}
