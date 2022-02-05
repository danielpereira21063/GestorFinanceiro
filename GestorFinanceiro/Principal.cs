using GestorFinanceiro.Data;
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
        private List<Movimento> Movimentos = new List<Movimento>();
        private List<Saldo> Saldos = new List<Saldo>();

        public Principal()
        {
            InitializeComponent();

            DbContext = new DBContext("localhost", "root", "ab12c3");
            InitialSchema initialSchema = new InitialSchema(DbContext);
            initialSchema.CreateSchema();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            DbContext = new DBContext("localhost", "gestor_financeiro", "root", "ab12c3");
            GenerateData data = new GenerateData(DbContext);

            if (!GetAllDados())
            {
                data.Generate();
            }
        }


        private bool GetAllDados()
        {
            try
            {
                DbContext.Connection.Open();
                string sql = "SELECT * FROM `movimentos` ORDER BY `data` DESC";

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
                                Data = DateTime.Parse(reader.GetString("data")),
                            });
                        }
                    }
                    return true;
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

            return false;
        }
    }
}