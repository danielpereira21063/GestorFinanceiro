using GestorFinanceiro.Enums;
using GestorFinanceiro.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorFinanceiro.Data
{
    public class GenerateData
    {
        private DBContext _dBContext = null;

        public GenerateData(DBContext dBContext)
        {
            _dBContext = dBContext;
        }

        public void Generate()
        {
            string sql = string.Empty;
            sql = "SELECT * FROM ´movimentos´";

            List<Movimento> movimentos = new List<Movimento>();
            List<Saldo> saldos = new List<Saldo>();
            List<Usuario> usuarios = new List<Usuario>();

            movimentos.Add(new Movimento(1, Categoria.ADICIONADO, 1000.00M, "EMPREGO", "Salário"));
            movimentos.Add(new Movimento(1, Categoria.DESPESAS, -94.3M, "Caixa", "Conta de luz"));
            movimentos.Add(new Movimento(1, Categoria.MEDICAMENTOS, -92.34M, "Farmácia", "Dipirona"));
            movimentos.Add(new Movimento(1, Categoria.DESPESAS, 46.5M, "Lugar nenhum", "Conta de luz"));
            movimentos.Add(new Movimento(1, Categoria.DESPESAS, 200.99M, "Rua silva", "Conta de luz"));
            movimentos.Add(new Movimento(1, Categoria.LANCHES, 22.33M, "Casa", "Hamburger"));
            movimentos.Add(new Movimento(1, Categoria.OUTROS, 100.3M, "Aliexpress", "Placa de vídeo"));

            saldos.Add(new Saldo(1, 1, 3034.51M));
            saldos.Add(new Saldo(1, 2, 2343.51M));
            saldos.Add(new Saldo(1, 3, 3422.55M));
            saldos.Add(new Saldo(1, 4, 1434.50M));
            saldos.Add(new Saldo(1, 5, 5214.34M));
            saldos.Add(new Saldo(1, 6, 1473.50M));
            saldos.Add(new Saldo(1, 7, 2124.41M));

            sql = string.Empty;
            sql += "INSERT INTO movimentos (`id_usuario`, `categoria`, `valor`, `local`, `descricao`)";
            sql += "\nVALUES";

            int i = 0;
            foreach (Movimento m in movimentos)
            {
                i++;
                sql += $"\n('{m.IdUsuario}', '{m.Categoria}', '{m.Valor.ToString().Replace(",", ".")}', '{m.Local}', '{m.Descricao}')";
                if (i < movimentos.Count)
                {
                    sql += ",";
                }
                else
                {
                    sql += ";";
                }
            }

            sql += "\n\n";

            sql += "INSERT INTO saldo (`idUsuario`, `idMovimento`, `saldoAtual`)";
            sql += "\n VALUES";

            i = 0;
            foreach (Saldo s in saldos)
            {
                i++;
                sql += $"\n('{s.IdUsuario}', '{s.IdMovimento}', '{s.SaldoAtual.ToString().Replace(",", ".")}')";
                if (i < saldos.Count)
                {
                    sql += ",";
                }
                else
                {
                    sql += ";";
                }
            }

            try
            {
                _dBContext.Connection.Open();
                MySqlCommand command = new MySqlCommand(sql, _dBContext.Connection);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (_dBContext.Connection.State == ConnectionState.Open)
                {
                    _dBContext.Connection.Close();
                }
            }
        }
    }
}
