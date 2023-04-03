using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace Kurs
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            DB.GetConn().Close();

            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM Login Where id={Test.Id_user}", DB.GetConn());
            DB.GetConn().Open();
            MySqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            Syda1.Text= rd["Kat"].ToString();
            Syda2.Text = rd["zav"].ToString();
            materialLabel7.Text = rd["login"].ToString();
            materialLabel6.Text = rd["pass"].ToString();
            materialLabel11.Text = rd["DateReg"].ToString();
            bunifuMetroTextbox1.Text = rd["Phone"].ToString();
            bunifuMetroTextbox2.Text = rd["Adres"].ToString();
            bunifuMetroTextbox3.Text = rd["Email"].ToString();
            path = rd["Foto"].ToString();
            pictureBox1.Image = Image.FromFile(@Application.StartupPath + @"\Foto\" + rd["Foto"].ToString());


            DB.GetConn().Close();
            rd.Close();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {             Regex rg = new Regex("@");
          
            MatchCollection m = rg.Matches(bunifuMetroTextbox3.Text);
            if (m.Count >= 1 && m.Count < 2 )
            {

                if (path1=="a")
                {
                    path1 = path;
                }
                else
                {
                    path1 = path1;

                }
                try
                {
                    File.Copy(ps, Application.StartupPath + @"\Foto\" + path1);
                }
                catch
                {

                }
                DB.GetConn().Close();
                MySqlCommand cmd1 = new MySqlCommand($"INSERT INTO history(Type,ID_user,Date) VALUES('9','{Test.Id_user}','{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}')", DB.GetConn());
                DB.GetConn().Open();
                cmd1.ExecuteNonQuery();
                DB.GetConn().Close();
                MySqlCommand cmd = new MySqlCommand($"UPDATE login  Set Email='{bunifuMetroTextbox3.Text}',Phone='{bunifuMetroTextbox1.Text}',Adres='{bunifuMetroTextbox2.Text}', Foto='{path1}' Where id={Test.Id_user}", DB.GetConn());
                DB.GetConn().Open();
                MySqlDataReader rd = cmd.ExecuteReader();
                DB.GetConn().Close();
                MessageBox.Show("Профиль изменён");
                Test.back = 0;
                Test.zamena = "0";
                Test.Id = "1";
                Form2 s = new Form2();
                s.Show();
                s.Close();
            }
            else
            {
                MessageBox.Show("неправильный формат email");
            }
               
           
        }
        OpenFileDialog ff = new OpenFileDialog();
        string path, path1="a",ps;

        private void bunifuMetroTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!double.TryParse(bunifuMetroTextbox1.Text + e.KeyChar.ToString(), out double a) && e.KeyChar != 8 )
            {
               
                    e.Handled = true;

                errorProvider1.SetError(bunifuMetroTextbox1, "Только числовые значения!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {
           

        }

        private void bunifuMetroTextbox3_OnValueChanged(object sender, EventArgs e)
        {
         
        }
            private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            ff.Filter = "Файлы изображений (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";


            if (ff.ShowDialog() != DialogResult.Cancel)
            {

                var size = new FileInfo(ff.FileName).Length;
                int gg = Convert.ToInt32(size);
                if (gg >= 1085117)
                {
                    MessageBox.Show("Файл слишком большой");
                }
                else
                {

                    ps = ff.FileName;
                    path1 = ff.SafeFileName;
                    pictureBox1.Image = Image.FromFile(ps);
                }





            }
        }
    }
}
