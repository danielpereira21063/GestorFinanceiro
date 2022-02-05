using GestorFinanceiro.Enums;

namespace GestorFinanceiro.Models
{
    public class Movimento : BaseModel
    {
        public int IdUsuario { get; set; }
        public Categoria Categoria { get; set; }
        public decimal Valor { get; set; }
        public string Local { get; set; }
        public string Descricao { get; set; }
        public DateTime? Data;

        public Movimento()
        {

        }

        public Movimento(int idUsuario, Categoria categoria, decimal valor, string local, string descricao, DateTime? data = null)
        {
            IdUsuario = idUsuario;
            Categoria = categoria;
            Valor = valor;
            Local = local;
            Descricao = descricao;

            if (data == null)
            {
                Data = DateTime.Now;
            }
            else
            {
                Data = data;
            }
        }
    }
}
