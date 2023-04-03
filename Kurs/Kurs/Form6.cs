using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Kurs
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection();
        private void Button_Click(object sender, EventArgs e)
        {
            //try
            //{

            //    var helper = new WordHelper("Dogovor.doc");
            //    var items = new Dictionary<string, string>
            //{
            //    { "<ORG>","sdadasdasdasda" },


            //    };
            //    helper.Procces(items);
            //    MessageBox.Show("Создано на рабочем столе!");

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(this, ex.Message);
            //}
            //Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application(); // Создаем СОМ - объект Excel //
            //excel.Workbooks.Add(Type.Missing); // добавляем книгу //
            //Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks[1]; // получаем ссылку на первую открытую книгу  //
            //Microsoft.Office.Interop.Excel.Worksheet sheet = workbook.Worksheets.get_Item(1); //  получаем ссылку на первый лист //

            //int rowExcel = 2; // начать со второй строки //
            //for (int i = 0; i < 15; i++) // int i = 0 - начальное положение, индекс первого просматриваемого элемента; условие выхода из цикла; шаг движения по циклу // 
            //{
            //    sheet.Cells[rowExcel, "A"] = "dsadasdasd";  // заполняем строку // 
            //    sheet.Cells[rowExcel, "B"] = "dsadasdasd"; // В столбец "В" заполняем значения из колонки 2 ДатаГрида //
            //    sheet.Cells[rowExcel, "C"] = "dsadasdasd";

            //    ++rowExcel;
            //}
            //sheet.Cells[1, 1] = "Приложение 1 к договору" + " " + "das2"+ " " + "от" + " " + "dsad23";
            //sheet.Cells[2, 1] = "Наименование товара";
            //sheet.Cells[2, 2] = "Цена за единицу(тыс.руб)";
            //sheet.Cells[2, 3] = "Количество единиц";
            //sheet.Cells.get_Range("A1", "E1").Font.Bold = true; // делаем их жирными // 
            //sheet.Columns.EntireColumn.AutoFit();
            //sheet.Cells.get_Range("A1", "M1").ColumnWidth = 15; // размер шрифта //


            //object newFileName = Path.Combine(@"C:\Users\MRmakfentos\Desktop\Kurs\Kurs\bin\Debug","Prilochenie_1.xlsx");
            //workbook.SaveAs(newFileName);
            //MessageBox.Show("Пакет документов создан на рабочем столе!");
            conn = DB.GetConn();
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM login WHERE login='{Text1.Text}' and pass='{Text2.Text}'", conn);
            conn.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            
            DataTable dt = new DataTable();
            sda.Fill(dt);
         


            if (dt.Rows.Count == 1)
            {
                MySqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                Test.Id_user = rd["id"].ToString();
                Test.Royale = rd["Royale"].ToString();
                rd.Close();

                Form3 mainForm = new Form3();
                this.Hide();
                mainForm.ShowDialog();
                this.Close();
               
            }


            else
            {
                MessageBox.Show("Неверные данные");
                Text1.Focus();
            }

        
            conn.Close();
           
            MySqlCommand cmd1 = new MySqlCommand($"INSERT INTO history(Type,ID_user,Date) VALUES('18','{Test.Id_user}','{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}')", conn);
            conn.Open();
            cmd1.ExecuteNonQuery();
            conn.Close();
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


        

        private void Form6_Load(object sender, EventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(pictureBox1.DisplayRectangle);
            pictureBox1.Region = new Region(gp);
            Text1.Text = Properties.Settings.Default.Login1;
            pictureBox2.Region = new Region(gp);
            Text2.Text = Properties.Settings.Default.Login;
            Check1.Checked = false;
            Check2.Checked = false;
        }

        private void Check1_OnChange(object sender, EventArgs e)
        {
            if(Check1.Checked)
            {
                Text2.isPassword = false;
              
            }
            else
            {
                Text2.isPassword = true;
            }
        }

        private void Text1_OnValueChanged(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Check2_OnChange(object sender, EventArgs e)
        {
            if(Check2.Checked)
            {
                Properties.Settings.Default.Login1 = Text1.Text;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Login = Text2.Text;
                Properties.Settings.Default.Save();

            }
            else
            {

            }
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {
            Form5 mainForm = new Form5();
            this.Hide();
            mainForm.ShowDialog();
            Form6 m = new Form6();
            this.Hide();
            m.ShowDialog();
            this.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
