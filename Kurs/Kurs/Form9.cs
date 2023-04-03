using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            bunifuCustomDataGrid1.Rows.Clear();
            DB.GetConn().Close();

            string cmdtext = "SELECT history.id, t_history.Title_type,history.Date,login.Login FROM history,login,t_history WHERE history.ID_user=login.ID and history.Type=t_history.ID ORDER BY ID DESC";
            MySqlCommand cmd = new MySqlCommand(cmdtext, DB.GetConn());
            DB.GetConn().Open();
            MySqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                bunifuCustomDataGrid1.Rows.Add(rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString());
            }

            DB.GetConn().Close();
            rd.Close();
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
