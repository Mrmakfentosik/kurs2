using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Kurs
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        public string path,path1;

        private  void Form5_Load(object sender, EventArgs e)
        {
           



         
           
        }
        public void Dob()
        {
            DB.GetConn().Close();
            MySqlCommand cmd = new MySqlCommand($"Insert into Login (Login,pass,Royale,DateReg,Foto) Values('{bunifuMaterialTextbox1.Text}','{bunifuMaterialTextbox2.Text}','{comboBox1.Text}','{DateTime.Now.ToString("yyyy-MM-dd")}','{path1}')", DB.GetConn());
            DB.GetConn().Open();

            MySqlDataReader rd = cmd.ExecuteReader();
            DB.GetConn().Close();


            MySqlCommand cmd1 = new MySqlCommand($"SELECT * FROM login WHERE login='{bunifuMaterialTextbox1.Text}'", DB.GetConn());
            DB.GetConn().Open();

            MySqlDataReader rd1 = cmd1.ExecuteReader();
            rd1.Read();
            Test.Id_user = rd1["id"].ToString();
            rd1.Close();

        }
        

        private   void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox2.Text==string.Empty ||  bunifuMaterialTextbox3.Text == string.Empty|| bunifuMaterialTextbox1.Text == string.Empty||comboBox1.Text==string.Empty)
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                if (bunifuMaterialTextbox2.Text != bunifuMaterialTextbox3.Text)
                {
                    MessageBox.Show("Пароли не совпадают");
                }
                else
                {
                    try
                    {
                        File.Copy(path, Application.StartupPath + @"\Foto\" + path1);
                    }
                    catch
                    {

                    }
                    DB.GetConn().Close();
                    MySqlCommand cmd1 = new MySqlCommand($"INSERT INTO history(Type,Date) VALUES('1','{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}')", DB.GetConn());
                    DB.GetConn().Open();
                    cmd1.ExecuteNonQuery();
              
                    DB.GetConn().Close();
                    MySqlCommand cmd = new MySqlCommand($"SELECT * FROM login WHERE login='{bunifuMaterialTextbox1.Text}'", DB.GetConn());
                    DB.GetConn().Open();
                    MySqlDataAdapter sda = new MySqlDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    sda.Fill(dt);



                    if (dt.Rows.Count == 1)
                    {
                        MessageBox.Show("Такой ползователь есть измените логин");



                    }
                    else
                    {
                        Dob();
                    }



                }
            }
           


        }

        private  void Form5_Activated(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            //Regex rg = new Regex("@");
            //MatchCollection m = rg.Matches(bunifuMaterialTextbox1.Text);
            //if (m.Count >= 1)
            //{
            //    MessageBox.Show("ура");
            //}
            //else
            //    MessageBox.Show("кал");
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            OpenFileDialog ff = new OpenFileDialog();
            if (ff.ShowDialog() != DialogResult.Cancel)
            {

                path = ff.FileName;
                pictureBox1.Image = Image.FromFile(path);
                path1 = ff.SafeFileName;

            }
            //DialogResult dialogResult = MessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    MessageBox.Show("sd");
            //}
            //else if (dialogResult == DialogResult.No)
            //{
            //    MessageBox.Show("sd1");
            //}
        }

    }
}
