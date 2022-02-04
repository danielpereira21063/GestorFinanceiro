using GestorFinanceiro.Enums;
using GestorFinanceiro.Migrations;
using GestorFinanceiro.Models;
using MySql.Data.MySqlClient;
using System.Data;

namespace GestorFinanceiro
{
    public partial class Principal : Form
    {
        private DBContext DbContext;

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

            InitialSchema initialSchema = new InitialSchema();

            initialSchema.CreateSchema();

            DbContext = new DBContext();
            try
            {
                DbContext.Connection.Open();
                string sql = "SELECT * FROM MOVIMENTOS ORDER BY `data` DESC";

                MySqlCommand command = new MySqlCommand(sql, DbContext.Connection);
                MySqlDataReader reader = command.ExecuteReader();

                List<Movimento> movimentos = new List<Movimento>();


                //criar um classe de movimentos
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        while (reader.Read())
                        {
                            movimentos.Add(new Movimento
                            {
                                Id = reader.GetInt32("id_movimento"),
                                IdUsuario = reader.GetInt32("id_usuario"),
                                Categoria = (Categoria)Enum.Parse(typeof(Categoria), reader.GetString("categoria")),
                                Descricao = reader.GetString("descricao"),
                                Local = reader.GetString("local"),
                                Valor = reader.GetInt32("valor"),
                                Data = DateTime.Parse( reader.GetString("data")),
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (DbContext.Connection.State == ConnectionState.Open)
                {
                    DbContext.Connection.Close();
                }
            }
        }
    }
}