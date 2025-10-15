

using System;
using System.Threading;

namespace Cronometro
{
    internal class Program
    {
        static void Main(string[] args)
            => Menu();

        private static void Menu()
        {
            Console.Clear();
            while (true)
            {
                Console.Write("\nS = Contar em Segundos\nM = Contar em Minutos\n0 = Sair do Programa\n\nEscolha o modo do cronômetro: ");
                string opcao = Console.ReadLine().ToLower().Trim();

                switch (opcao)
                {
                    case "s":
                        int segundos = RetornaUnidadeTempo("Segundos");
                        Console.WriteLine($"Iniciando cronômetro de {segundos} segundos...");
                        IniciarCronometro(segundos);
                        break;

                    case "m":
                        int minutos = RetornaUnidadeTempo("Minutos");
                        Console.WriteLine($"Iniciando cronômetro de {minutos} minutos...");
                        IniciarCronometro(minutos * 60); // Converte minutos para segundos
                        break;

                    case "0":
                        Console.Clear();
                        Console.WriteLine("Saindo..\n\n");
                        return;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida, tente novamente.");
                        continue;

                }
            }
        }

        private static void IniciarCronometro(int tempoTotalSegundos)
        {
            Thread.Sleep(2000);

            int tempoAtual = 0;
            while (tempoAtual < tempoTotalSegundos)
            {
                Console.Clear();
                tempoAtual++;
                Console.Write($"{tempoAtual}s\t\t\t\t");
                Thread.Sleep(1000); //Segundos
            }
            Console.Clear();
            Console.WriteLine("\nCronômetro finalizado!");
        }

        private static int RetornaUnidadeTempo(string unidade)
        {
            Console.Clear();
            Console.Write($"Digite quantos {unidade} deseja no seu cronômetro: ");
            while (true)
            {
                string entrada = Console.ReadLine().Trim();
                if (!int.TryParse(entrada, out int unidadeTempo) || unidadeTempo < 1)
                {
                    Console.Clear();
                    Console.WriteLine("Valor inválido! Digite um valor maior ou igual a 1");
                    continue;
                }
                return unidadeTempo;
            }
        }
    }
}

