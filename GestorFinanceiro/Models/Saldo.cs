namespace GestorFinanceiro.Models
{
    public class Saldo : BaseModel
    {
        public int IdUsuario { get; set; }
        public int IdMovimento { get; set; }
        public decimal SaldoAtual { get; set; }

        public Saldo()
        {

        }

        public Saldo(int idUsuario, int idMovimento, decimal saldoAtual)
        {
            IdUsuario = idUsuario;
            IdMovimento = idMovimento;
            SaldoAtual = saldoAtual;
        }
        
    }
}
