using System;
using Locadora.Entities;
using Locadora.Services.Interfaces;

namespace Locadora.Services
{
    public class CalculosServices : ICalculosServices
    {
        private readonly decimal ValorPorHora;
        private readonly decimal ValorDiario;

        public CalculosServices(decimal valorPorHora)
        {
            if (valorPorHora <= 0)
                throw new ArgumentException("O valor por hora deve ser maior que zero.");

            ValorPorHora = valorPorHora;
            ValorDiario = valorPorHora * 24; 
        }

        public decimal RetornaValorLocacao(Locacao locacao)
        {
            if (locacao.InstanteInicial > locacao.InstanteFinal)
                throw new ArgumentException("Data inicial deve ser menor que data final. Tente novamente.");

            TimeSpan duracao = locacao.InstanteFinal - locacao.InstanteInicial;
            decimal horas = (decimal)duracao.TotalHours;
            decimal dias = Math.Ceiling(horas / 24.0m); //cálculo para converter horas em dias

            return horas <= 12 ? ValorPorHora * horas : ValorDiario * dias;
        }
        public decimal RetornaValorImposto(decimal valor)
        {
            if (valor <= 0)
                throw new Exception("Valor para calcular imposto não pode ser menor ou igual a zero!");

            return valor <= 100 ? valor * 0.20m : valor * 0.15m;
        }

        public decimal RetornaTotalPagamento(Locacao locacao)
        {
            decimal valorLocacao = RetornaValorLocacao(locacao);

            decimal imposto = RetornaValorImposto(valorLocacao);

            return valorLocacao + imposto;
        }
    }
}
