
/*
Uma empresa possui funcionários próprios e terceirizados.
Para cada funcionário, deseja-se registrar; 
                                            nome, 
                                            horas trabalhadas,
                                            valor por hora, considerando que os mesmos trabalham 30 dias.. 
                

Funcionários terceirizados possuem ainda uma despesa adicional.
O pagamento dos funcionários terceirizados corresponde ao (valor da hora trabalhadas multiplicado pelas dias trabalhados), 
sendo que os funcionários terceirizados ainda recebem um bônus correspondente a 110% de sua despesa adicional.

Faça um programa para ler os dados de N funcionários (N fornecido pelo usuário) e armazená-los em uma lista. 

Depois de ler todos os dados, 
                            mostrar nome,
                            pagamento mensal de cada funcionário,

na mesma ordem em que foram digitados.
 
*/
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using PolimorfismoPrimeira.Entities;
using PolimorfismoPrimeira.Enuns;

namespace PolimorfismoPrimeira
{
    internal class Program
    {
        static void Main(string[] args)
            => Exibir();

        private static List<FuncionariosProprios> Leitura()
        {
            string nome;
            int horasPorDia, qtdFuncionarios;
            decimal valorRecebidoPorDia, despesa;
            TipoFuncionario tipo;

            var listaFuncionarios = new List<FuncionariosProprios>();

            while (true)
            {
                Console.Write("Digite a quantidade de funcionários ao todo: ");
                string entrada = Console.ReadLine().Trim();
                if(!int.TryParse(entrada, out qtdFuncionarios) || qtdFuncionarios <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Valor inválido. Tente novamente.");
                    continue;
                }
                break;
            }

            for (int i = 0; i < qtdFuncionarios; i++)
            {
                Console.Clear();
                Console.WriteLine($"{i + 1}ª Funcionário");

                while (true)
                {
                    Console.Write("É funcionário [Proprio ou Terceiro]? ");
                    string tipoF = Console.ReadLine().Trim();
                    if (!Enum.TryParse<TipoFuncionario>(tipoF, true, out tipo))
                    {
                        Console.Clear();
                        Console.WriteLine("Entrada inválida. Digite uma das opções a seguir: [Proprio ou Terceiro]");
                        continue;
                    }
                    break;
                }

                while (true)
                {
                    Console.Write($"Entre com o nome do funcionario {tipo}: ");
                    nome = Console.ReadLine().Trim().ToLower();
                    if (string.IsNullOrWhiteSpace(nome) || !nome.All(c => char.IsLetter(c) || c == ' '))
                    {
                        Console.Clear();
                        Console.WriteLine("Entrada inválida. Digite um nome válido!");
                        continue;
                    }
                    nome = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome.ToLower());
                    break;
                }

                while (true)
                {
                    Console.Write($"Entre com as horas trabalhadas por dia do funcionario {nome}: ");
                    string horasT = Console.ReadLine().Trim();
                    if (!int.TryParse(horasT, out horasPorDia) || horasPorDia <= 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Entrada inválida. Digite um número 'inteiro' maior que zero!");
                        continue;
                    }
                    break;
                }

                while (true)
                {
                    Console.Write($"Entre com valor recebido por dia do funcionario {nome}: R$ ");
                    string valorH = Console.ReadLine().Trim();
                    if (!decimal.TryParse(valorH, out valorRecebidoPorDia) || valorRecebidoPorDia <= 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Entrada inválida. Digite um número 'inteiro' ou 'real' maior que zero!");
                        continue;
                    }
                    break;
                }

                if (tipo == TipoFuncionario.Proprio)
                {
                    listaFuncionarios.Add(new FuncionariosProprios(nome, horasPorDia, valorRecebidoPorDia));
                }

                if (tipo == TipoFuncionario.Terceiro)
                {
                    while (true)
                    {
                        Console.Write($"Entre com valor de despesa do funcionario {nome}: R$ ");
                        string despesaF = Console.ReadLine().Trim();
                        if (!decimal.TryParse(despesaF, out despesa) || despesa < 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Entrada inválida. Digite um número 'inteiro' ou 'real' maior ou igual há zero!");
                            continue;
                        }
                        break;
                    }
                    listaFuncionarios.Add(new FuncionariosTerceiros(despesa, nome, horasPorDia, valorRecebidoPorDia));
                }
            }
            return listaFuncionarios;
        }
        private static void Exibir()
        {
            var listaFuncionarios = Leitura();

            Console.Clear();
            Console.WriteLine($"Funcionarios:\n{string.Join("",listaFuncionarios)}\n");
        }
    }
}
