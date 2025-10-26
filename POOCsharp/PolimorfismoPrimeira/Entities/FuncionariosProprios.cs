
using System;
using PolimorfismoPrimeira.Enuns;

namespace PolimorfismoPrimeira.Entities
{
    public class FuncionariosProprios
    {
        public string Nome{ get; set; }
        public int HorasPorDia{ get; set; }
        public decimal ValorRecebidoPorDia{ get; set; }


        public FuncionariosProprios(string nome, int horasPorDia, decimal valorRecebidoPorDia)
        {
            Nome = nome;
            HorasPorDia = horasPorDia;
            ValorRecebidoPorDia = valorRecebidoPorDia;
        }

        private int DiasTrabalhados 
            => DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);

        public virtual decimal Pagamento() 
            => ValorRecebidoPorDia * DiasTrabalhados;

        public override string ToString()
        {
            return ($"\nFuncionário {TipoFuncionario.Proprio}\n\n" +
                $">Nome: {Nome}\n" +
                $">Horas trabalhadas: {HorasPorDia}\n" +
                $">Valor por dia recebido: R${ValorRecebidoPorDia:F2}\n" +
                $">Pagamento mensal: R${Pagamento():F2}\n\n");
        }
    }
}
