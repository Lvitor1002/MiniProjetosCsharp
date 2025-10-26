

using PolimorfismoPrimeira.Enuns;

namespace PolimorfismoPrimeira.Entities
{
    public class FuncionariosTerceiros : FuncionariosProprios
    {
        public decimal ValorDespesaAdicional{ get; set; }
        private const decimal BONUS_EXTRA = 1.1m;

        public FuncionariosTerceiros(decimal valorDespesaAdicional, string nome, int horasPorDia, decimal valorRecebidoPorDia) : base(nome, horasPorDia, valorRecebidoPorDia) 
            => ValorDespesaAdicional = valorDespesaAdicional;

        public override decimal Pagamento() 
            => base.Pagamento() + (ValorDespesaAdicional * BONUS_EXTRA);

        public override string ToString()
        {
            return ($"\nFuncionário {TipoFuncionario.Terceiro}\n\n" +
                $">Nome: {Nome}\n" +
                $">Horas trabalhadas: {HorasPorDia}\n" +
                $">Despesa Adicional: R${ValorDespesaAdicional:F2}\n" +
                $">Valor por dia recebido: R${ValorRecebidoPorDia:F2}\n" +
                $">Pagamento mensal: R${Pagamento():F2}\n\n");
        }
    }
}
