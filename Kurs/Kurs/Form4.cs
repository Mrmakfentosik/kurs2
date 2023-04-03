using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Word = Microsoft.Office.Interop.Word;

namespace Kurs
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }


        public static string delete;
        public static int a,b,c;
        private void Form4_Load(object sender, EventArgs e)
        {
            if (Test.zavki == "1" && Test.kat == "0" && Test.Tender == "0")
            {
                DB.GetConn().Close();

                flowLayoutPanel1.Controls.Clear();
                MySqlCommand cmd1 = new MySqlCommand($"SELECT COUNT(ID),SUM(Sum) FROM kat1 WHERE ID_user={Test.Id_user}", DB.GetConn());
                MySqlCommand cmd = new MySqlCommand($" SELECT tovar.*,kat1.* FROM kat1,tovar WHERE kat1.ID_TOVAR=tovar.ID AND kat1.ID_user={Test.Id_user}", DB.GetConn());
                DB.GetConn().Open();
                MySqlDataReader rd1 = cmd1.ExecuteReader();

                string zap;
                if (rd1.Read())
                {
                    int count1 = Convert.ToInt32(rd1[0].ToString());
                    if (count1 >= 1)
                    {

                        MaterialFlatButton butt =
                        new MaterialFlatButton();
                        butt.Text = "Купить";
                        butt.Size = new Size(182, 178);
                        butt.Font = new Font("Microsoft Sans Serif", 48, FontStyle.Bold);
                        butt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                        butt.Dock = DockStyle.Top;
                        flowLayoutPanel1.Controls.Add(butt);

                        butt.Click += new System.EventHandler(gClick2);
                        MaterialLabel butt1 =
                       new MaterialLabel();
                        butt1.Text = $"Общая сумма к оплате: {rd1[1].ToString()} Руб";
                        butt1.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
                        butt1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
                        butt1.Dock = DockStyle.Top;
                        flowLayoutPanel1.Controls.Add(butt1);

                       




                    }
                    else
                    {

                    }
                }
                rd1.Close();
                MySqlDataReader rd = cmd.ExecuteReader();
                
                while (rd.Read())
                {
                    UserControl3 test = new UserControl3(rd[4].ToString(), rd[1].ToString(), rd[2].ToString(), rd[14].ToString(),rd[9].ToString(), rd[11].ToString());
                    delete += "," + rd[9].ToString();
                    test.Dock = DockStyle.Top;

                    flowLayoutPanel1.Controls.Add(test);


                }
                DB.GetConn().Close();
                rd.Close();
            }
            else if (Test.kat == "1" && Test.zavki == "0" && Test.Tender == "0")
            {
                if (Test.Royale != "a")
                {
                    DB.GetConn().Close();
                    
                    flowLayoutPanel1.Controls.Clear();
                    MySqlCommand cmd = new MySqlCommand($"SELECT zavki.id, zavki.Title,zavki.cost,status.status,zavki.Foto,zavki.comment FROM zavki,status Where zavki.status=status.id and ID_user={Test.Id_user}  ", DB.GetConn());
                    DB.GetConn().Open();
                    MySqlDataReader rd = cmd.ExecuteReader();
                   
                   
                    while (rd.Read())
                    {
                        UserControl8 test = new UserControl8(rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString(), rd[5].ToString()) ;

                        test.Dock = DockStyle.Left;

                        flowLayoutPanel1.Controls.Add(test);


                    }
                    
                    DB.GetConn().Close();
                    rd.Close();
                  
                        MaterialFlatButton butt =
                        new MaterialFlatButton();
                        butt.Text = "Добавить товар";
                        butt.Size = new Size(182, 178);
                        butt.Font = new Font("Microsoft Sans Serif", 48, FontStyle.Bold);
                        butt.Dock = DockStyle.Bottom;
                        flowLayoutPanel1.Controls.Add(butt);

                        butt.Click += new System.EventHandler(gClick1);
                        DB.GetConn().Close();
                       rd.Close();
                    
                    if (Test.Id != "0" || UserControl7.sex== "gaga" )
                    {
                        DB.GetConn().Close();
                        flowLayoutPanel1.Controls.Clear();
                        MySqlCommand cmd1 = new MySqlCommand($"SELECT * FROM zavki,manufacturer WHERE manufacturer.ID_zavki=zavki.ID and zavki.id={Test.Id_zavki}", DB.GetConn());
                        DB.GetConn().Open();
                        MySqlDataReader rd1 = cmd1.ExecuteReader();
                      
                        if (rd1.Read())
                        {
                            UserControl2 test = new UserControl2(rd1[0].ToString(), rd1[6].ToString(), rd1[1].ToString(), rd1[3].ToString(), rd1[2].ToString(), rd1[7].ToString(), rd1[8].ToString(), rd1[13].ToString(), rd1[14].ToString());

                            test.Dock = DockStyle.Top;

                            flowLayoutPanel1.Controls.Add(test);

                        }

                        else
                        {

                        }
                        DB.GetConn().Close();
                        rd1.Close();
                    }
                }
                else
                {
                    if (Test.Id != "0")
                    {
                        MessageBox.Show("WAT");
                        flowLayoutPanel1.Controls.Clear();
                        Test.ag = string.Empty;
                       // UserControl8 test = new UserControl8();
                       // test.Dock = DockStyle.Top;
                      //  flowLayoutPanel1.Controls.Add(test);
                    }
                    else
                    {
                        DB.GetConn().Close();
                    
                        MySqlCommand cmd2 = new MySqlCommand("Select count(status) From zavki Where status<=1", DB.GetConn());
                        DB.GetConn().Open();
                        MySqlDataReader rd2 = cmd2.ExecuteReader();
                        rd2.Read();

                        int agl1 = Convert.ToInt32(rd2[0].ToString());



                        DB.GetConn().Close();
                        rd2.Close();
                        DB.GetConn().Close();

                        flowLayoutPanel1.Controls.Clear();
                        MySqlCommand cmd = new MySqlCommand("SELECT zavki.id, zavki.Title,zavki.cost,zavki.comment,zavki.Foto,zavki.sum,zavki.Type,zavki.ID_man FROM zavki,status Where zavki.status=status.id and zavki.status=1  ", DB.GetConn());
                        DB.GetConn().Open();
                        MySqlDataReader rd = cmd.ExecuteReader();
                      
                        Button sa = new Button();
                        while (rd.Read())
                        {
                            UserControl4 test = new UserControl4(rd[0].ToString(), rd[1].ToString(), rd[3].ToString(), rd[2].ToString(), rd[4].ToString(), rd[5].ToString(), rd[6].ToString(), rd[7].ToString());

                            test.Dock = DockStyle.Top;

                            flowLayoutPanel1.Controls.Add(test);


                        }
                        
                        
                        if (agl1 >= 1)
                        {
                            MaterialFlatButton butt =
                       new MaterialFlatButton();

                            butt.Text = "Выполнить";
                            butt.Size = new Size(182, 178);
                            butt.Font = new Font("Microsoft Sans Serif", 100, FontStyle.Bold);
                            butt.Dock = DockStyle.Bottom;
                            flowLayoutPanel1.Controls.Add(butt);
                            butt.Click += new System.EventHandler(gClick);
                        }
                        else
                        {

                        }
                    }
                }

            }
            else if (Test.Tender == "1" && Test.kat == "0" && Test.zavki == "0" && Test.Info == "0")
            {
            

            }

            else if (Test.Info == "1" && Test.Tender == "0" && Test.kat == "0" && Test.zavki == "0" && Test.back == 1 )
            {
                if (Test.Id != "0" /*|| Test.back == 1 && Test.Id == "1"*/)
                {
                    string zap1;
                    DB.GetConn().Close();
                    MySqlCommand cmd1 = new MySqlCommand($"SELECT login.id,login.Login,login.DateReg,login.Datezax,login.zav,(SELECT COUNT(status) From zavki WHERE status=1 and Id_user={UserControl6.id1}  ),(SELECT COUNT(status) From zavki WHERE status=2 and Id_user={UserControl6.id1}),(SELECT COUNT(status) From zavki WHERE status=3 and Id_user={UserControl6.id1}) FROM login,zavki WHERE zavki.ID_user=login.ID and Login.ID={UserControl6.id1} and zavki.ID_user={UserControl6.id1}  ", DB.GetConn());
                    DB.GetConn().Open();
                    object result = cmd1.ExecuteScalar();
                    if (result == null)
                    {
                        zap1 = "Net";
                    }
                    else
                    {
                        zap1 = "da";
                    }
                    DB.GetConn().Close();

                    if (zap1 == "da")
                    {
                        flowLayoutPanel1.Controls.Clear();
                        MySqlCommand cmd = new MySqlCommand($"SELECT login.id,login.Login,login.DateReg,login.Datezax,login.zav,(SELECT COUNT(status) From zavki WHERE status=1 and Id_user={UserControl6.id1}  ),(SELECT COUNT(status) From zavki WHERE status=2 and Id_user={UserControl6.id1}),(SELECT COUNT(status) From zavki WHERE status=3 and Id_user={UserControl6.id1}) FROM login,zavki WHERE zavki.ID_user=login.ID and Login.ID={UserControl6.id1} and zavki.ID_user={UserControl6.id1}  ", DB.GetConn());
                        DB.GetConn().Open();
                        MySqlDataReader rd = cmd.ExecuteReader();



                        while (rd.Read())
                        {
                            UserControl7 test = new UserControl7(rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString(), rd[7].ToString(), rd[6].ToString(), rd[5].ToString());
                            test.Dock = DockStyle.Top;
                           

                            flowLayoutPanel1.Controls.Add(test);
                            break;


                        }

                        DB.GetConn().Close();
                        rd.Close();
                    }
                    else
                    {
                        flowLayoutPanel1.Controls.Clear();
                        MySqlCommand cmd = new MySqlCommand($"SELECT * FROM login Where id={UserControl6.id1}", DB.GetConn());
                        DB.GetConn().Open();
                        MySqlDataReader rd = cmd.ExecuteReader();



                        while (rd.Read())
                        {
                            UserControl7 test = new UserControl7(rd[0].ToString(), rd[1].ToString(), rd[5].ToString(), rd[7].ToString(), rd["zav"].ToString(), "0", "0", "0");
                            test.Dock = DockStyle.Top;
                           

                            flowLayoutPanel1.Controls.Add(test);
                            break;


                        }

                        DB.GetConn().Close();
                        rd.Close();
                    }
                }
                else
                {
                 
                    DB.GetConn().Close();

                    flowLayoutPanel1.Controls.Clear();
                    MySqlCommand cmd = new MySqlCommand($"SELECT login.id,login.Login,login.DateReg,login.Datezax,login.zav,(SELECT COUNT(status) From zavki WHERE status=1 and Id_user=14  ),(SELECT COUNT(status) From zavki WHERE status=2 and Id_user=14),(SELECT COUNT(status) From zavki WHERE status=3 and Id_user=14) FROM login,zavki WHERE zavki.ID_user=login.ID and Login.ID={Test.Id_user} and zavki.ID_user={Test.Id_user}  ", DB.GetConn());
                    DB.GetConn().Open();
                    MySqlDataReader rd = cmd.ExecuteReader();


                    while (rd.Read())
                    {
                        UserControl7 test = new UserControl7(rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString(), rd[7].ToString(), rd[6].ToString(), rd[5].ToString());
                        test.Dock = DockStyle.Top;
                        c = Convert.ToInt32(rd[5].ToString());
                        b = Convert.ToInt32(rd[6].ToString());
                        a = Convert.ToInt32(rd[7].ToString());
                        flowLayoutPanel1.Controls.Add(test);
                      



                    }

                    DB.GetConn().Close();
                    rd.Close();
                }
            }
            else if(Test.Tender == "0" && Test.kat == "0" && Test.zavki == "0"&& Test.Info == "0")
            {
                DB.GetConn().Close();
                flowLayoutPanel1.Controls.Clear();
                MySqlCommand cmd = new MySqlCommand($"SELECT * FROM tovar,manufacturer WHERE manufacturer.ID_Tovar=tovar.ID and tovar.id={Test.Id}", DB.GetConn());
                DB.GetConn().Open();
                MySqlDataReader rd = cmd.ExecuteReader();
             
                if (rd.Read())
                {
                    UserControl2 test = new UserControl2(rd[0].ToString(), rd[4].ToString(), rd[1].ToString(), rd[3].ToString(), rd[2].ToString(), rd[5].ToString(), rd[6].ToString(),rd[10].ToString(),rd[11].ToString());

                    test.Dock = DockStyle.Top;

                    flowLayoutPanel1.Controls.Add(test);

                }
              
                else
                {
                   
                }
                DB.GetConn().Close();
                rd.Close();
            }
        }
        public void gClick1(object sender, EventArgs e)
        {

            Test.Tovar = "1";
            Test.prost = "1";
            Test.zamena = "0";
            flowLayoutPanel1.Controls.Clear();
            Form2 f = new Form2();
            f.TopLevel = false;
            flowLayoutPanel1.Controls.Add(f);
            f.Show();




        }
        public void gClick2(object sender, EventArgs e)
        {
            int kat=0;
            DB.GetConn().Close();
            MySqlCommand cmd1 = new MySqlCommand($"SELECT Kat FROM login Where id={Test.Id_user}", DB.GetConn());
            DB.GetConn().Open();
            MySqlDataReader rd = cmd1.ExecuteReader();
            if(rd.Read())
            {
                kat = Convert.ToInt32(rd[0].ToString());
            }
            rd.Close();
            DB.GetConn().Close();
            delete = delete.Remove(0, 1);
            //Тут вывести договор о покупке
            Regex rg = new Regex(",");
            MatchCollection m = rg.Matches(delete);
            MySqlCommand cmd = new MySqlCommand($"UPDATE login set Kat={UserControl3.summa+kat} Where id={Test.Id_user};DELETE FROM kat1 WHERE ID in({delete});DELETE FROM Tovar Where cost=0", DB.GetConn());
            DB.GetConn().Open();
            cmd.ExecuteNonQuery();
            DB.GetConn().Close();
            Test.Tovar = "0";
            Test.prost = "0";
            Test.zavki = "1";
            Test.zamena = "2";
            flowLayoutPanel1.Controls.Clear();
            Form2 f = new Form2();
            f.TopLevel = false;
            flowLayoutPanel1.Controls.Add(f);
            f.Show();
            f.Close();
            MessageBox.Show("Товар куплен");
            //try
            //{

            //    var helper = new WordHelper("Dogovor.doc");
            //    var items = new Dictionary<string, string>
            //{
            //   { "<ORG>","СЕЕЕЕЕЕЕЕЕЕКС" },
            //    //{ "<Agent>",textBox3.Text },
            //    //{ "<DATA>",maskedTextBox1.Text },
            //    //{ "<Dog>",textBox2.Text },
            //    //{ "<Sum>",textBox1.Text },
            //    //{ "<Sum1>",dataGridView1.Rows[0].Cells[0].Value.ToString()},
            //    //{ "<Sum2>",dataGridView1.Rows[0].Cells[2].Value.ToString()},
            //    //{ "<Sum3>",dataGridView1.Rows[0].Cells[1].Value.ToString()}

            //    };
            //    helper.Procces(items);
            //    MessageBox.Show("Создано на рабочем столе!");

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(this, ex.Message);
            //}


        }
        public void gClick(object sender, EventArgs e)
        {
            //Test.Id_zavki_pot = Test.Id_zavki_pot.Substring(0, Test.Id_zavki_pot.Length - 1);
            try
            {
                DB.GetConn().Close();
                MySqlCommand cmd = new MySqlCommand($"{Test.Id_zavki_pot}", DB.GetConn());
                DB.GetConn().Open();
                MySqlDataReader rd = cmd.ExecuteReader();
                DB.GetConn().Close();
                MessageBox.Show("Заявки расмотрены");
                Test.back = 0;
                Test.zamena = "0";
                Test.Id = "1";
                Form2 s = new Form2();
                Test.ag = "0";
                Test.Id_zavki_pot = string.Empty;
                s.Show();
                s.Close();
            }
            catch
            {
                MessageBox.Show("Выберите товар");
            }
           

        }
        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {
            
        }

        private void bunifuSwitch1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Activated(object sender, EventArgs e)
        {
          
        }
    }
}
