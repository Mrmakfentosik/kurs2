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
    public partial class UserControl6 : UserControl
    {
        public UserControl6(string id, string login, string date, string Foto)
        {
            InitializeComponent();
            this.id = id;
            pictureBox1.Image = Image.FromFile(@Application.StartupPath + @"\Foto\" + Foto);



            label2.Text = $"Дата создания\n{date}";
            label1.Text = $"{login}";
        }
        public  string id;
        public static string id1;
        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            DB.GetConn().Close();
            MySqlCommand cmd1 = new MySqlCommand($"INSERT INTO history(Type,ID_user,Date) VALUES('11','{Test.Id_user}','{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}')", DB.GetConn());
            DB.GetConn().Open();
            cmd1.ExecuteNonQuery();
            DB.GetConn().Close();

            id1 = id;
          
            Test.back = 1;
            Test.Id = "1";
            Form2 s = new Form2();
            s.Show();
            s.Close();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
