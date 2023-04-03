using Aspose.Cells;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurs
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        public static string gaga;
        private async void Form8_Load(object sender, EventArgs e)
        {
            //Workbook workbook = new Workbook(@Application.StartupPath + @"\Foto\" +"Excel.xlsx");
            //ReplaceOptions replace = new ReplaceOptions();
            //replace.CaseSensitive = false;
            //replace.MatchEntireCellContents = false;
            //// Set RegexKey to true to indicate that the searched key is a Regex
            //replace.RegexKey = true;
            //// Replace text
            //workbook.Replace("Слово", "Замена слова", replace);

            //// Save updated Excel workbook
            //workbook.Save(@Application.StartupPath + @"\Foto\" +"PLZ.xlsx");



            //DB.GetConn().Open();

            //MySqlCommand cmd = new MySqlCommand("SELECT * FROM TOVAR ", DB.GetConn());
            //MySqlDataReader rd = cmd.ExecuteReader();
            //rd.Read();

            //while (rd.Read())
            //{


            //     gaga+= $";UPDATE Tovar set cost=3 Where id={rd[0].ToString()}";


            //}
            //DB.GetConn().Close();
            //rd.Close();
            //MessageBox.Show(gaga);
            //MySqlCommand cmd1 = new MySqlCommand(gaga, DB.GetConn());
            //DB.GetConn().Open();

            //cmd1.ExecuteNonQuery();
            //DB.GetConn().Close();

            ss();
            await Task.Delay(5000);

            this.Close();
        }
       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private async void ss()
            {
            while (bunifuCircleProgressbar1.Value != 100)
            {
                bunifuCircleProgressbar1.Value ++;
                await Task.Delay(40);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
