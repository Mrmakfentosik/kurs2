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
using MySql.Data;

namespace Kurs
{
    public partial class UserControl7 : UserControl
    {
        public UserControl7(string id,string login, string Datereg, string Datezax,  string zav, string plus, string minus, string maybe)
        {
            InitializeComponent();
         
            
              
               
                materialLabel3.Text += ": " + login;
                materialLabel1.Text += ": " + Datereg.Substring(0, Datereg.Length - 8);
                materialLabel2.Text += ": " + Datezax;
                materialLabel4.Text = $"Заявок размещено:{zav}\nПотверждёных:{plus}\nОтменённых:{minus}\nВ ожидании:{maybe}";
            
          
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
        public string cmdtext;
        public void load()
        {
           
            bunifuCustomDataGrid1.Rows.Clear();
            DB.GetConn().Close();


            MySqlCommand cmd = new MySqlCommand(cmdtext, DB.GetConn());
            DB.GetConn().Open();
            MySqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                bunifuCustomDataGrid1.Rows.Add(rd[7].ToString(), rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), Image.FromFile(@Application.StartupPath + @"\Foto\" + rd[4].ToString()), rd[5].ToString(), Image.FromFile(@Application.StartupPath + @"\Foto\" + rd[6].ToString()));
            }
           
            DB.GetConn().Close();
            rd.Close();
            foreach (DataGridViewRow row in bunifuCustomDataGrid1.Rows)
            {
                if (row.Cells["Column5"].Value.ToString().Equals("Подтверждено"))
                {
                    bunifuCustomDataGrid1.Rows[row.Index].DefaultCellStyle.BackColor = Color.LightGreen;
                }
                if (row.Cells["Column5"].Value.ToString().Equals("Отменено"))
                {
                    bunifuCustomDataGrid1.Rows[row.Index].DefaultCellStyle.BackColor = Color.Red;
                }
                if (row.Cells["Column5"].Value.ToString().Equals("Ожидание"))
                {
                    bunifuCustomDataGrid1.Rows[row.Index].DefaultCellStyle.BackColor = Color.Yellow;
                }
            
            }
          
        }
        private void UserControl7_Load(object sender, EventArgs e)
        {
            bunifuCustomDataGrid1.Controls.Clear();
            imageComboBoxEdit1.SelectedIndex = 0;
            cmdtext = $"SELECT zavki.Title, zavki.comment, zavki.Cost, zavki.sum, zavki.Foto, status.status,status.Foto,zavki.id FROM zavki,status WHERE status.id=zavki.status and zavki.ID_user={UserControl6.id1}";
            load();
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(imageComboBoxEdit1.SelectedIndex);
            if (a == 1)
            {



                cmdtext = $"SELECT zavki.Title, zavki.comment, zavki.Cost, zavki.sum, zavki.Foto, status.status,status.Foto,zavki.id FROM zavki,status,manufacturer WHERE status.id=zavki.status and zavki.ID_user={UserControl6.id1} and zavki.status=1 and manufacturer.ID_zavki=zavki.ID AND  CONCAT(manufacturer.model,manufacturer.Unique_number,manufacturer.Manufacturer,zavki.Title, zavki.comment, zavki.Cost) LIKE '%{textBox1.Text}%'";
                load();
            }
            else if (a == 2)
            {
                cmdtext = $"SELECT zavki.Title, zavki.comment, zavki.Cost, zavki.sum, zavki.Foto, status.status,status.Foto,zavki.id FROM zavki,status,manufacturer WHERE status.id=zavki.status and zavki.ID_user={UserControl6.id1} and zavki.status=2 and manufacturer.ID_zavki=zavki.ID AND  CONCAT(manufacturer.model,manufacturer.Unique_number,manufacturer.Manufacturer,zavki.Title, zavki.comment, zavki.Cost) LIKE '%{textBox1.Text}%'";
                load();
            }
            else if (a == 3)
            {
                cmdtext = $"SELECT zavki.Title, zavki.comment, zavki.Cost, zavki.sum, zavki.Foto, status.status,status.Foto,zavki.id FROM zavki,status,manufacturer WHERE status.id=zavki.status and zavki.ID_user={UserControl6.id1} and zavki.status=3 and manufacturer.ID_zavki=zavki.ID AND  CONCAT(manufacturer.model,manufacturer.Unique_number,manufacturer.Manufacturer,zavki.Title, zavki.comment, zavki.Cost) LIKE '%{textBox1.Text}%'";
                load();
            }
            else
            {

                cmdtext = $"SELECT zavki.Title, zavki.comment, zavki.Cost, zavki.sum, zavki.Foto, status.status,status.Foto,zavki.id FROM zavki,status,manufacturer WHERE status.id=zavki.status and zavki.ID_user={UserControl6.id1} and manufacturer.ID_zavki=zavki.ID AND  CONCAT(manufacturer.model,manufacturer.Unique_number,manufacturer.Manufacturer,zavki.Title, zavki.comment, zavki.Cost) LIKE '%{textBox1.Text}%'";
                load();
            }
        }
        public static void Chose()
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
        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            Chose();
            Test.zamena = "55";
            Test.Info = "1";

            Form2 s = new Form2();
            s.Show();
            s.Close();
           
        }
        public static string id,sex;
        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = this.bunifuCustomDataGrid1.Rows[e.RowIndex];

                Test.Id_zavki = row.Cells["Column8"].Value.ToString();
                Test.back = 1;
                Test.Id = "1";
                Test.kat = "1";
                    sex = "gaga";
                Test.Royale = "p";
                Form2 s = new Form2();
                s.Show();
                s.Close();
                Test.Royale = "a";
            }
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(imageComboBoxEdit1.SelectedIndex);
            if (a == 1)
            {



                cmdtext = $"SELECT zavki.Title, zavki.comment, zavki.Cost, zavki.sum, zavki.Foto, status.status,status.Foto,zavki.id FROM zavki,status,manufacturer WHERE status.id=zavki.status and zavki.ID_user={UserControl6.id1} and zavki.status=1 and manufacturer.ID_zavki=zavki.ID AND  CONCAT(manufacturer.model,manufacturer.Unique_number,manufacturer.Manufacturer,zavki.Title, zavki.comment, zavki.Cost) LIKE '%{textBox1.Text}%'";
                load();
            }
            else if (a == 2)
            {
                cmdtext = $"SELECT zavki.Title, zavki.comment, zavki.Cost, zavki.sum, zavki.Foto, status.status,status.Foto,zavki.id FROM zavki,status,manufacturer WHERE status.id=zavki.status and zavki.ID_user={UserControl6.id1} and zavki.status=2 and manufacturer.ID_zavki=zavki.ID AND  CONCAT(manufacturer.model,manufacturer.Unique_number,manufacturer.Manufacturer,zavki.Title, zavki.comment, zavki.Cost) LIKE '%{textBox1.Text}%'";
                load();
            }
            else if (a == 3)
            {
                cmdtext = $"SELECT zavki.Title, zavki.comment, zavki.Cost, zavki.sum, zavki.Foto, status.status,status.Foto,zavki.id FROM zavki,status,manufacturer WHERE status.id=zavki.status and zavki.ID_user={UserControl6.id1} and zavki.status=3 and manufacturer.ID_zavki=zavki.ID AND  CONCAT(manufacturer.model,manufacturer.Unique_number,manufacturer.Manufacturer,zavki.Title, zavki.comment, zavki.Cost) LIKE '%{textBox1.Text}%'";
                load();
            }
            else
            {

                cmdtext = $"SELECT zavki.Title, zavki.comment, zavki.Cost, zavki.sum, zavki.Foto, status.status,status.Foto,zavki.id FROM zavki,status,manufacturer WHERE status.id=zavki.status and zavki.ID_user={UserControl6.id1} and manufacturer.ID_zavki=zavki.ID AND  CONCAT(manufacturer.model,manufacturer.Unique_number,manufacturer.Manufacturer,zavki.Title, zavki.comment, zavki.Cost) LIKE '%{textBox1.Text}%'";
                load();
            }
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
