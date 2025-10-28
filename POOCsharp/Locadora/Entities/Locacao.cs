using System;
using Locadora.Services.Interfaces;
using treino.Entities.Enums;

namespace Locadora.Entities
{
    public class Locacao
    {
        public Modelo Modelo { get; set; }
        public DateTime InstanteInicial { get; set; }
        public DateTime InstanteFinal { get; set; }
        public ICalculosServices Cobranca { get; set; } 


        public Locacao(Modelo modelo, DateTime instanteFinal, ICalculosServices cobranca)
        {
            Modelo = modelo;
            InstanteInicial = DateTime.Now;
            InstanteFinal = instanteFinal;
            Cobranca = cobranca;
        }

        public override string ToString()
        {
            decimal valorLocacao = Cobranca.RetornaValorLocacao(this); // Passe 'this' para passar a própria instância de Locacao nos métodos.
            decimal imposto = Cobranca.RetornaValorImposto(valorLocacao); // Aplicando imposto
            TimeSpan duracao = InstanteFinal - InstanteInicial;

            return $"\n>Carro {Modelo}\n" +
                   $">Ato do contrato: {InstanteInicial:dd/MM/yyyy HH:mm:ss}\n" +
                   $">Duração total: {(int)duracao.TotalHours}:{duracao.Minutes:D2} horas\n" +
                   $">Valor da locação: R${valorLocacao:F2}\n" +
                   $">Valor do Imposto: R${imposto:F2}\n" +
                   $">Valor total do pagamento: R${Cobranca.RetornaTotalPagamento(this):F2}\n";
        }
    }
}

