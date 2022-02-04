using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorFinanceiro.Migrations
{
    public class InitialSchema
    {
        private DBContext _dbContext;

        public InitialSchema()
        {
            _dbContext = new DBContext();
        }
        public void CreateSchema()
        {

            try
            {
                _dbContext.Connection.Open();

                string sql = String.Empty;

                //database
                sql += "CREATE DATABASE IF NOT EXISTS Gestor_Financeiro DEFAULT CHARACTER SET utf8  COLLATE utf8_general_ci;";
                sql += "\n USE Gestor_Financeiro;\n\n";

                //usuarios
                sql += "\n CREATE TABLE IF NOT EXISTS `usuarios` (";
                sql += "\n `id` int unsigned NOT NULL AUTO_INCREMENT,";
                sql += "\n `nome` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,";
                sql += "\n `email` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,";
                sql += "\n `nomeUsuario` varchar(50) DEFAULT NULL,";
                sql += "\n `senha` char(60) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT '',";
                sql += "\n `dtCadastro` datetime NOT NULL,";
                sql += "\n `admin` enum('0','1') CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,";
                sql += "\n PRIMARY KEY (`id`)";
                sql += "\n) DEFAULT CHARSET=utf8;\n\n";

                //movimentos
                sql += "\n CREATE TABLE IF NOT EXISTS `movimentos` (";
                sql += "\n `id_movimento` int unsigned NOT NULL AUTO_INCREMENT,";
                sql += "\n `id_usuario` int unsigned DEFAULT NULL,";
                sql += "\n `categoria` enum('LANCHES','DESPESAS','MEDICAMENTOS','OUTROS','ADICIONADO'),";
                sql += "\n `valor` decimal(10,2) NOT NULL,";
                sql += "\n `local` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT 'Não informado',";
                sql += "\n `descricao` varchar(100) DEFAULT '',";
                sql += "\n `data` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,";
                sql += "\n PRIMARY KEY (`id_movimento`) USING BTREE,";
                sql += "\n KEY `FK_movimentos_usuarios` (`id_usuario`)";
                sql += "\n ) DEFAULT CHARSET=utf8;\n\n";

                //histórico de saldo
                sql += "\n CREATE TABLE IF NOT EXISTS `saldo` (";
                sql += "\n `idSaldo` int unsigned NOT NULL AUTO_INCREMENT,";
                sql += "`\n idUsuario` int unsigned DEFAULT NULL,";
                sql += "`\n idMovimento` int DEFAULT NULL,";
                sql += "\n `saldoAtual` decimal(10,2) DEFAULT NULL,";
                sql += "\n PRIMARY KEY (`idSaldo`),";
                sql += "\n KEY `FK_saldo_usuarios` (`idUsuario`),";
                sql += "\n KEY `FK_saldo_movimentos` (`idMovimento`)";
                sql += "\n ) DEFAULT CHARSET = utf8;";

                MySqlCommand command = new MySqlCommand(sql, _dbContext.Connection);
                MySqlDataReader reader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (_dbContext.Connection.State == ConnectionState.Open)
                {
                    _dbContext.Connection.Close();
                }
            }


        }
    }

}
