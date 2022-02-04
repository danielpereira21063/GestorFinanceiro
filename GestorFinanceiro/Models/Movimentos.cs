using GestorFinanceiro.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorFinanceiro.Models
{
    public class Movimentos : BaseModel
    {
        public int IdUsuario { get; set; }
        public Categoria Categoria { get; set; }
        public decimal Valor { get; set; }
        public string Local { get; set; }
        public string Descricao { get; set; }
        public DateTime? Data;

        public Movimentos(int idUsuario, Categoria categoria, decimal valor, string local, string descricao,DateTime data)
        {
            IdUsuario = idUsuario;
            Categoria = categoria;
            Valor = valor;
            Local = local;
            Descricao = descricao;

            if(data == null)
            {
                Data = DateTime.Now;
            } else
            {
                Data = data;
            }
        }
    }
}
