using MySql.Data.MySqlClient;

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
        }
    }
}
