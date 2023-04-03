using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Kurs
{
    public partial class UserControl3 : UserControl
    {
        public UserControl3(string photo, string tovar, string comment, string count,string id,string Totalsumm)
        {
            InitializeComponent();




            pictureBox1.Image = Image.FromFile(@Application.StartupPath + @"\Foto\" + photo);
            materialLabel1.Text = $"Название\n{tovar}\n описание\n{comment}";
            materialLabel2.Text = $"Колличество\n{count}\n Ваша цена за все {Totalsumm}";
          this.a = Convert.ToInt32(count);
            summa += a;
            this.a1 = tovar;
            this.id = id;
            this.totalsumm = Totalsumm;
        }
        public int a,b;
        public string a1,id,totalsumm;
        public static int summa;
        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click_1(object sender, EventArgs e)
        {

        }
        int c, c1;
        private void materialLabel2_Click(object sender, EventArgs e)
        {
            DB.GetConn().Close();
            MySqlCommand cmd2 = new MySqlCommand($"INSERT INTO history(Type,ID_user,Date) VALUES('10','{Test.Id_user}','{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}')", DB.GetConn());
            DB.GetConn().Open();
            cmd2.ExecuteNonQuery();
            DB.GetConn().Close();
           

            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM Tovar WHERE Title='{a1}'", DB.GetConn());
            DB.GetConn().Open();
            MySqlDataReader rd = cmd.ExecuteReader();
          
            if (rd.Read()) { 
                b = Convert.ToInt32(rd["cost"].ToString());
           c = Convert.ToInt32(rd["TotalSum"].ToString());
             c1 = Convert.ToInt32(totalsumm);

            DB.GetConn().Close();
           
        }
            rd.Close();
            DB.GetConn().Close();
            MySqlCommand cmd1 = new MySqlCommand($"update Tovar Set cost={a+b},TotalSum={c1+c} WHERE Title='{a1}';Delete FROM kat1 Where id={id}", DB.GetConn());
            DB.GetConn().Open();
           cmd1.ExecuteNonQuery();
           
            DB.GetConn().Close();
            

            Chose();
            Test.zavki = "1";
            Test.zamena = "2";
            MessageBox.Show("Товар удалён");
         
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
    }

}
