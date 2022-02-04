using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorFinanceiro
{
    public class DBContext
    {
        public MySqlConnection Connection { get; set; }
        public MySqlCommand Command { get; set; }
        public DBContext()
        {
            string connString = "Server=localhost;Database=gestor-financeiro; Uid=root;Pwd=ab12c3";
            Connection = new MySqlConnection(connString);
            Command = new MySqlCommand();
        }
    }
}
