using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace Kurs
{
   public class DB
    {
      
        static MySqlConnection conn = new MySqlConnection("Host=localhost;Port=3307;User=root;Password=root;Database=kurs");
       

        public static MySqlConnection GetConn()
        {
            return conn;
        }
    }
}
