using MySql.Data.MySqlClient;

namespace GestorFinanceiro
{
    public class DBContext
    {
        private string _server;
        private string _database;
        private string _uid;
        private string _pwd;

        public MySqlConnection Connection { get; set; }
        public MySqlCommand Command { get; set; }
        public DBContext(string server, string uid, string pwd)
        {
            string connString = $"Server={server};Uid={uid}; Pwd={pwd}";
            Connection = new MySqlConnection(connString);
        }

        public DBContext(string server, string database, string uid, string pwd)
        {
            _server = server;
            _database = database;
            _uid = uid;
            _pwd = pwd;

            string connString = $"Server={server}; Database={database}; Uid={uid}; Pwd={pwd}";
            Connection = new MySqlConnection(connString);
        }
    }
}
