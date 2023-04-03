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
    public partial class UserControl4 : UserControl
    {
        public UserControl4(string id, string title, string comment, string cost, string foto, string sum,string type,string Id_man)
        {
            InitializeComponent();
            
            
          
            pictureBox1.Image = Image.FromFile(@Application.StartupPath + @"\Foto\" + foto);



            materialLabel1.Text = $"{title}";
            materialLabel2.Text = $"Количество:{cost}";
            this.id = id;
            this.sum = sum;
            this.title = title;
            this.comment = comment;
            this.cost = cost;
            this.foto = foto;
            this.type = type;
            this.id_man = Id_man;
        }
        public string id, sum,title,comment,cost,foto, type,id_man;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void UserControl4_Load(object sender, EventArgs e)
        {
            bunifuCheckbox1.Checked = false;
            bunifuCheckbox2.Checked = false;
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox1.Checked)
            {
                bunifuCheckbox2.Checked = false;
                DB.GetConn().Close();
                MySqlCommand cmd1 = new MySqlCommand($"INSERT INTO history(Type,ID_user,Date) VALUES('7','{Test.Id_user}','{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}')", DB.GetConn());
                DB.GetConn().Open();
                cmd1.ExecuteNonQuery();
                DB.GetConn().Close();
                Test.ag = Test.ag.Remove(0, 1);
                    Test.ag += "3";
               int s =Convert.ToInt32( sum.Substring(0,sum.Length-8));
                int s1 = Convert.ToInt32(cost);
                Test.Id_zavki_pot += $";UPDATE zavki set status='{Test.ag}', Print=1 Where id='{id}';Insert into tovar (Title,comment,Cost,Foto,sum,totalsum,type,ID_man) Values('{title}','{comment}','{cost}','{foto}','{sum}','{s*s1}','{type}','{id_man}');Update manufacturer set ID_Tovar=(SELECT MAX(ID) FROM tovar) Where ID_zavki={id}";
             
            }
            else
            {
                bunifuCheckbox1.Checked = true;
               
            }
        }

        private void bunifuCheckbox2_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox2.Checked)
            {
                bunifuCheckbox1.Checked = false;
                DB.GetConn().Close();
                MySqlCommand cmd1 = new MySqlCommand($"INSERT INTO history(Type,ID_user,Date) VALUES('8','{Test.Id_user}','{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}')", DB.GetConn());
                DB.GetConn().Open();
                cmd1.ExecuteNonQuery();
                DB.GetConn().Close();

                Test.ag = Test.ag.Remove(0, 1);
                    Test.ag += "2";
                    Test.Id_zavki_pot += $";UPDATE zavki set status='{Test.ag}' Where id='{id}'";
             

            }
            else
            {
            
                bunifuCheckbox2.Checked = true;
            }
        }
    }
}
