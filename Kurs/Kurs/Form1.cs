using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace Kurs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection();
        public void Form1_Load(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Chose();

            loaded();



        }
        public static int fs = 0;
        public string cmdt = "SELECT * FROM Tovar Where Cost>0";
        public void loaded()
        {
            if (Test.Info == "1" && Test.Tender == "0" && Test.kat == "0" && Test.zavki == "0")
            {
                imageComboBoxEdit1.Visible = false;
                DB.GetConn().Close();
                conn = DB.GetConn();
                flowLayoutPanel1.Controls.Clear();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Login", conn);
                conn.Open();
                MySqlDataReader rd = cmd.ExecuteReader();

                Button sa = new Button();
                while (rd.Read())
                {
                    UserControl6 test = new UserControl6(rd[0].ToString(), rd["login"].ToString(), rd["DateReg"].ToString(), rd["Foto"].ToString());

                    test.Dock = DockStyle.Top;

                    flowLayoutPanel1.Controls.Add(test);


                }
                conn.Close();
                rd.Close();
            }
            else
            {
                imageComboBoxEdit1.SelectedIndex = fs;

                DB.GetConn().Close();
                conn = DB.GetConn();
                flowLayoutPanel1.Controls.Clear();
                MySqlCommand cmd = new MySqlCommand(cmdt, conn);
                conn.Open();
                MySqlDataReader rd = cmd.ExecuteReader();


                while (rd.Read())
                {
                    UserControl1 test = new UserControl1(rd[0].ToString(), rd["Foto"].ToString(), rd["Title"].ToString(), rd["cost"].ToString());

                    test.Dock = DockStyle.Top;

                    flowLayoutPanel1.Controls.Add(test);


                }
                conn.Close();
                rd.Close();


                if (Test.Royale == "a")
                {

                    Button butt = new Button();
                    butt.Text = "+";
                    butt.Size = new Size(182, 178);
                    butt.Font = new Font("Microsoft Sans Serif", 48, FontStyle.Bold);
                    butt.Dock = DockStyle.Top;
                    flowLayoutPanel1.Controls.Add(butt);

                    butt.Click += new System.EventHandler(gClick);
                    //UserControl3 test1 = new UserControl3();
                    //test1.Dock = DockStyle.Top;
                    //flowLayoutPanel1.Controls.Add(test1);
                }
                else
                {

                }

            }
        }
        public void gClick(object sender, EventArgs e)
        {
            imageComboBoxEdit1.Visible = false;
            Test.Tovar = "1";
            Test.prost = "1";
            flowLayoutPanel1.Controls.Clear();
            Form2 f = new Form2();
            f.TopLevel = false;
            flowLayoutPanel1.Controls.Add(f);
            f.Show();

        }



        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            Form2 f = new Form2();
            f.TopLevel = false;
            flowLayoutPanel1.Controls.Add(f);
            f.Show();

        }



        private void flowLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {

        }



        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {

        }

        private void imageComboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fs = imageComboBoxEdit1.SelectedIndex;
            int a = imageComboBoxEdit1.SelectedIndex;
            switch (a)
            {
                case 1:
                    {

                        cmdt = $"SELECT * FROM tovar,manufacturer where Type=1 and Cost>0   and tovar.ID=manufacturer.ID_Tovar and CONCAT(tovar.Title,tovar.comment,tovar.Cost,manufacturer.Manufacturer,manufacturer.model,manufacturer.Unique_number) Like '%{textBox1.Text}%'";
                        loaded();
                        break;
                    }
                case 2:
                    {

                        cmdt = $"SELECT * FROM tovar,manufacturer where Type=2 and Cost>0   and tovar.ID=manufacturer.ID_Tovar and CONCAT(tovar.Title,tovar.comment,tovar.Cost,manufacturer.Manufacturer,manufacturer.model,manufacturer.Unique_number) Like '%{textBox1.Text}%'";
                        loaded();
                        break;
                    }
                case 3:
                    {

                        cmdt = $"SELECT * FROM tovar,manufacturer where Type=3 and Cost>0    and tovar.ID=manufacturer.ID_Tovar and CONCAT(tovar.Title,tovar.comment,tovar.Cost,manufacturer.Manufacturer,manufacturer.model,manufacturer.Unique_number) Like '%{textBox1.Text}%' ";
                        loaded();
                        break;
                    }
                case 4:
                    {

                        cmdt = $"SELECT * FROM tovar,manufacturer where Type=4 and Cost>0  and tovar.ID=manufacturer.ID_Tovar and CONCAT(tovar.Title,tovar.comment,tovar.Cost,manufacturer.Manufacturer,manufacturer.model,manufacturer.Unique_number) Like '%{textBox1.Text}%'";
                        loaded();
                        break;
                    }
                case 5:
                    {

                        cmdt = $"SELECT * FROM tovar,manufacturer where Type=5 and Cost>0  and tovar.ID=manufacturer.ID_Tovar and CONCAT(tovar.Title,tovar.comment,tovar.Cost,manufacturer.Manufacturer,manufacturer.model,manufacturer.Unique_number) Like '%{textBox1.Text}%'";
                        loaded();
                        break;
                    }
                case 6:
                    {

                        cmdt = $"SELECT * FROM tovar,manufacturer where Type=6 and Cost>0  and tovar.ID=manufacturer.ID_Tovar and CONCAT(tovar.Title,tovar.comment,tovar.Cost,manufacturer.Manufacturer,manufacturer.model,manufacturer.Unique_number) Like '%{textBox1.Text}%'";
                        loaded();
                        break;
                    }
                case 7:
                    {

                        cmdt = $"SELECT * FROM tovar,manufacturer where Type=7 and Cost>0  and tovar.ID=manufacturer.ID_Tovar and CONCAT(tovar.Title,tovar.comment,tovar.Cost,manufacturer.Manufacturer,manufacturer.model,manufacturer.Unique_number) Like '%{textBox1.Text}%'";
                        loaded();
                        break;
                    }
                case 8:
                    {

                        cmdt = $"SELECT * FROM tovar,manufacturer where Type=8 and Cost>0  and tovar.ID=manufacturer.ID_Tovar and CONCAT(tovar.Title,tovar.comment,tovar.Cost,manufacturer.Manufacturer,manufacturer.model,manufacturer.Unique_number) Like '%{textBox1.Text}%'";
                        loaded();
                        break;
                    }
                case 9:
                    {

                        cmdt = $"SELECT * FROM tovar,manufacturer where Type=9 and Cost>0  and tovar.ID=manufacturer.ID_Tovar and CONCAT(tovar.Title,tovar.comment,tovar.Cost,manufacturer.Manufacturer,manufacturer.model,manufacturer.Unique_number) Like '%{textBox1.Text}%'";
                        loaded();
                        break;
                    }
                case 10:
                    {

                        cmdt = $"SELECT * FROM tovar,manufacturer where Type=10 and Cost>0  and tovar.ID=manufacturer.ID_Tovar and CONCAT(tovar.Title,tovar.comment,tovar.Cost,manufacturer.Manufacturer,manufacturer.model,manufacturer.Unique_number) Like '%{textBox1.Text}%'";
                        loaded();
                        break;
                    }
                case 11:
                    {
                        cmdt = $"SELECT * FROM tovar,manufacturer where Type=11 and Cost>0  and tovar.ID=manufacturer.ID_Tovar and CONCAT(tovar.Title,tovar.comment,tovar.Cost,manufacturer.Manufacturer,manufacturer.model,manufacturer.Unique_number) Like '%{textBox1.Text}%'";
                        loaded();
                        break;
                    }
                case 12:
                    {

                        cmdt = $"SELECT * FROM tovar,manufacturer where Type=12 and Cost>0  and tovar.ID=manufacturer.ID_Tovar and CONCAT(tovar.Title,tovar.comment,tovar.Cost,manufacturer.Manufacturer,manufacturer.model,manufacturer.Unique_number) Like '%{textBox1.Text}%'";
                        loaded();
                        break;
                    }
                case 13:
                    {

                        cmdt = $"SELECT * FROM tovar,manufacturer where Type=13 and Cost>0  and tovar.ID=manufacturer.ID_Tovar and CONCAT(tovar.Title,tovar.comment,tovar.Cost,manufacturer.Manufacturer,manufacturer.model,manufacturer.Unique_number) Like '%{textBox1.Text}%'";
                        loaded();
                        break;
                    }
                case 14:
                    {

                        cmdt = $"SELECT * FROM tovar,manufacturer where Type=14 and Cost>0  and tovar.ID=manufacturer.ID_Tovar and CONCAT(tovar.Title,tovar.comment,tovar.Cost,manufacturer.Manufacturer,manufacturer.model,manufacturer.Unique_number) Like '%{textBox1.Text}%'";
                        loaded();
                        break;
                    }
                case 15:
                    {

                        cmdt = $"SELECT * FROM tovar,manufacturer where Type=15 and Cost>0  and tovar.ID=manufacturer.ID_Tovar and CONCAT(tovar.Title,tovar.comment,tovar.Cost,manufacturer.Manufacturer,manufacturer.model,manufacturer.Unique_number) Like '%{textBox1.Text}%'";
                        loaded();
                        break;
                    }
                case 16:
                    {

                        cmdt = $"SELECT * FROM tovar,manufacturer where Type=16 and Cost>0  and tovar.ID=manufacturer.ID_Tovar and CONCAT(tovar.Title,tovar.comment,tovar.Cost,manufacturer.Manufacturer,manufacturer.model,manufacturer.Unique_number) Like '%{textBox1.Text}%'";
                        loaded();
                        break;
                    }
                case 17:
                    {

                        cmdt = $"SELECT * FROM tovar,manufacturer where Type=17 and Cost>0  and tovar.ID=manufacturer.ID_Tovar and CONCAT(tovar.Title,tovar.comment,tovar.Cost,manufacturer.Manufacturer,manufacturer.model,manufacturer.Unique_number) Like '%{textBox1.Text}%'";
                        loaded();
                        break;
                    }
                case 18:
                    {

                        cmdt = $"SELECT * FROM tovar,manufacturer where Type=18 and Cost>0  and tovar.ID=manufacturer.ID_Tovar and CONCAT(tovar.Title,tovar.comment,tovar.Cost,manufacturer.Manufacturer,manufacturer.model,manufacturer.Unique_number) Like '%{textBox1.Text}%'";
                        loaded();
                        break;
                    }
                default:
                    cmdt = $"SELECT * FROM tovar,manufacturer WHERE Cost>0  and tovar.ID=manufacturer.ID_Tovar and CONCAT(tovar.Title,tovar.comment,tovar.Cost,manufacturer.Manufacturer,manufacturer.model,manufacturer.Unique_number) Like '%{textBox1.Text}%'";
                    loaded();
                    break;
            }
            //MessageBox.Show(imageComboBoxEdit1.SelectedIndex.ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            fs = imageComboBoxEdit1.SelectedIndex;
            int a = imageComboBoxEdit1.SelectedIndex;
            switch (a)
            {
                case 1:
                    {

                        cmdt = $"SELECT * FROM tovar,manufacturer where Type=1 and Cost>0   and tovar.ID=manufacturer.ID_Tovar and CONCAT(tovar.Title,tovar.comment,tovar.Cost,manufacturer.Manufacturer,manufacturer.model,manufacturer.Unique_number) Like '%{textBox1.Text}%'";
                        loaded();
                        break;
                    }
                case 2:
                    {

                        cmdt = $"SELECT * FROM tovar,manufacturer where Type=2 and Cost>0   and tovar.ID=manufacturer.ID_Tovar and CONCAT(tovar.Title,tovar.comment,tovar.Cost,manufacturer.Manufacturer,manufacturer.model,manufacturer.Unique_number) Like '%{textBox1.Text}%'";
                        loaded();
                        break;
                    }
                case 3:
                    {

                        cmdt = $"SELECT * FROM tovar,manufacturer where Type=3 and Cost>0    and tovar.ID=manufacturer.ID_Tovar and CONCAT(tovar.Title,tovar.comment,tovar.Cost,manufacturer.Manufacturer,manufacturer.model,manufacturer.Unique_number) Like '%{textBox1.Text}%' ";
                        loaded();
                        break;
                    }
                case 4:
                    {

                        cmdt = $"SELECT * FROM tovar,manufacturer where Type=4 and Cost>0  and tovar.ID=manufacturer.ID_Tovar and CONCAT(tovar.Title,tovar.comment,tovar.Cost,manufacturer.Manufacturer,manufacturer.model,manufacturer.Unique_number) Like '%{textBox1.Text}%'";
                        loaded();
                        break;
                    }
                case 5:
                    {

                        cmdt = $"SELECT * FROM tovar,manufacturer where Type=5 and Cost>0  and tovar.ID=manufacturer.ID_Tovar and CONCAT(tovar.Title,tovar.comment,tovar.Cost,manufacturer.Manufacturer,manufacturer.model,manufacturer.Unique_number) Like '%{textBox1.Text}%'";
                        loaded();
                        break;
                    }
                case 6:
                    {

                        cmdt = $"SELECT * FROM tovar,manufacturer where Type=6 and Cost>0  and tovar.ID=manufacturer.ID_Tovar and CONCAT(tovar.Title,tovar.comment,tovar.Cost,manufacturer.Manufacturer,manufacturer.model,manufacturer.Unique_number) Like '%{textBox1.Text}%'";
                        loaded();
                        break;
                    }
                case 7:
                    {

                        cmdt = $"SELECT * FROM tovar,manufacturer where Type=7 and Cost>0  and tovar.ID=manufacturer.ID_Tovar and CONCAT(tovar.Title,tovar.comment,tovar.Cost,manufacturer.Manufacturer,manufacturer.model,manufacturer.Unique_number) Like '%{textBox1.Text}%'";
                        loaded();
                        break;
                    }
                case 8:
                    {

                        cmdt = $"SELECT * FROM tovar,manufacturer where Type=8 and Cost>0  and tovar.ID=manufacturer.ID_Tovar and CONCAT(tovar.Title,tovar.comment,tovar.Cost,manufacturer.Manufacturer,manufacturer.model,manufacturer.Unique_number) Like '%{textBox1.Text}%'";
                        loaded();
                        break;
                    }
                case 9:
                    {

                        cmdt = $"SELECT * FROM tovar,manufacturer where Type=9 and Cost>0  and tovar.ID=manufacturer.ID_Tovar and CONCAT(tovar.Title,tovar.comment,tovar.Cost,manufacturer.Manufacturer,manufacturer.model,manufacturer.Unique_number) Like '%{textBox1.Text}%'";
                        loaded();
                        break;
                    }
                case 10:
                    {

                        cmdt = $"SELECT * FROM tovar,manufacturer where Type=10 and Cost>0  and tovar.ID=manufacturer.ID_Tovar and CONCAT(tovar.Title,tovar.comment,tovar.Cost,manufacturer.Manufacturer,manufacturer.model,manufacturer.Unique_number) Like '%{textBox1.Text}%'";
                        loaded();
                        break;
                    }
                case 11:
                    {
                        cmdt = $"SELECT * FROM tovar,manufacturer where Type=11 and Cost>0  and tovar.ID=manufacturer.ID_Tovar and CONCAT(tovar.Title,tovar.comment,tovar.Cost,manufacturer.Manufacturer,manufacturer.model,manufacturer.Unique_number) Like '%{textBox1.Text}%'";
                        loaded();
                        break;
                    }
                case 12:
                    {

                        cmdt = $"SELECT * FROM tovar,manufacturer where Type=12 and Cost>0  and tovar.ID=manufacturer.ID_Tovar and CONCAT(tovar.Title,tovar.comment,tovar.Cost,manufacturer.Manufacturer,manufacturer.model,manufacturer.Unique_number) Like '%{textBox1.Text}%'";
                        loaded();
                        break;
                    }
                case 13:
                    {

                        cmdt = $"SELECT * FROM tovar,manufacturer where Type=13 and Cost>0  and tovar.ID=manufacturer.ID_Tovar and CONCAT(tovar.Title,tovar.comment,tovar.Cost,manufacturer.Manufacturer,manufacturer.model,manufacturer.Unique_number) Like '%{textBox1.Text}%'";
                        loaded();
                        break;
                    }
                case 14:
                    {

                        cmdt = $"SELECT * FROM tovar,manufacturer where Type=14 and Cost>0  and tovar.ID=manufacturer.ID_Tovar and CONCAT(tovar.Title,tovar.comment,tovar.Cost,manufacturer.Manufacturer,manufacturer.model,manufacturer.Unique_number) Like '%{textBox1.Text}%'";
                        loaded();
                        break;
                    }
                case 15:
                    {

                        cmdt = $"SELECT * FROM tovar,manufacturer where Type=15 and Cost>0  and tovar.ID=manufacturer.ID_Tovar and CONCAT(tovar.Title,tovar.comment,tovar.Cost,manufacturer.Manufacturer,manufacturer.model,manufacturer.Unique_number) Like '%{textBox1.Text}%'";
                        loaded();
                        break;
                    }
                case 16:
                    {

                        cmdt = $"SELECT * FROM tovar,manufacturer where Type=16 and Cost>0  and tovar.ID=manufacturer.ID_Tovar and CONCAT(tovar.Title,tovar.comment,tovar.Cost,manufacturer.Manufacturer,manufacturer.model,manufacturer.Unique_number) Like '%{textBox1.Text}%'";
                        loaded();
                        break;
                    }
                case 17:
                    {

                        cmdt = $"SELECT * FROM tovar,manufacturer where Type=17 and Cost>0  and tovar.ID=manufacturer.ID_Tovar and CONCAT(tovar.Title,tovar.comment,tovar.Cost,manufacturer.Manufacturer,manufacturer.model,manufacturer.Unique_number) Like '%{textBox1.Text}%'";
                        loaded();
                        break;
                    }
                case 18:
                    {

                        cmdt = $"SELECT * FROM tovar,manufacturer where Type=18 and Cost>0  and tovar.ID=manufacturer.ID_Tovar and CONCAT(tovar.Title,tovar.comment,tovar.Cost,manufacturer.Manufacturer,manufacturer.model,manufacturer.Unique_number) Like '%{textBox1.Text}%'";
                        loaded();
                        break;
                    }
                default:
                    cmdt = $"SELECT * FROM tovar,manufacturer WHERE Cost>0  and tovar.ID=manufacturer.ID_Tovar and CONCAT(tovar.Title,tovar.comment,tovar.Cost,manufacturer.Manufacturer,manufacturer.model,manufacturer.Unique_number) Like '%{textBox1.Text}%'";
                    loaded();
                    break;
            }
        }
    }
}

