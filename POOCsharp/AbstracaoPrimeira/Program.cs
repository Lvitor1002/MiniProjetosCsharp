/*
Fazer um programa em design [Herança juntamente com Interface] e ler primeiramente a quantidade total de figuras, 
depois os dados de cada N figuras (N fornecido pelo usuário);
                                                                Retângulo ou Círculo?
                                                if == Retângulo:
                                                                CorFigura[preto,azul,vermelho]:,
                                                                Largura:,
                                                                Altura:,
                                                if == Círculo:
                                                                CorFigura[preto,azul,vermelho]:,
                                                                Raio:
e depois mostrar as áreas destas figuras na mesma ordem em que foram digitadas.
 */


using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using AbstracaoPrimeira.Entities;
using AbstracaoPrimeira.Enuns;

namespace AbstracaoPrimeira
{
    internal class Program
    {
        public static void Main(string[] args)
            => Exibir();


        public static List<Figura> Leitura()
        {
            double raio, largura, altura;
            int qtdTotalFiguras;
            CorFigura corFigura;
            TipoFigura tipoFigura;
            var listaFiguras = new List<Figura>();

            while (true)
            {
                Console.Write($"Entre com a quantidade total de figuras: ");
                string entrada = Console.ReadLine().Trim();
                if(!int.TryParse(entrada, out qtdTotalFiguras) || qtdTotalFiguras < 0)
                {
                    Console.Clear();
                    Console.WriteLine("Entrada inválida. Entre com um número inteiro positivo maior que zero.");
                    continue;
                }
                break;
            }

            for (int i = 0; i < qtdTotalFiguras; i++) 
            {
                Console.Clear();
                Console.WriteLine($"\t  {i + 1}ª Figura\n");

                while (true)
                {
                    Console.Write("Retângulo ou Círculo?\nDigite apenas uma das opções a seguir: [Retangulo | Circulo] - ");
                    string entrada = Console.ReadLine().Trim().ToLower();
                    if(!Enum.TryParse<TipoFigura>(entrada, true, out tipoFigura)) {
                        Console.Clear();
                        Console.WriteLine("Entrada inválida. Digite Circulo ou Retangulo!");
                        continue;
                    }
                    break;
                }
                while (true)
                {
                    Console.Write($"Escolha uma cor para {tipoFigura}: [Preto | Azul | Vermelho] ");
                    string entrada = Console.ReadLine().Trim();
                    if (!Enum.TryParse<CorFigura>(entrada, true, out corFigura))
                    {
                        Console.Clear();
                        Console.WriteLine("Entrada inválida. Entre com uma das cores: [Preto | Azul | Vermelho]\n");
                        continue;
                    }
                    break;
                }

                if(tipoFigura == TipoFigura.Retangulo)
                {
                    while (true)
                    {
                        Console.Write($"Entre com a largura do {tipoFigura}: ");
                        string entrada = Console.ReadLine().Trim();
                        if (!double.TryParse(entrada, out largura) || largura< 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Entrada inválida. Entre com um número inteiro ou real, positivo e maior que zero.");
                            continue;
                        }
                        break;
                    }
                    while (true)
                    {
                        Console.Write($"Entre com a altura do {tipoFigura}: ");
                        string entrada = Console.ReadLine().Trim();
                        if (!double.TryParse(entrada, out altura) || altura< 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Entrada inválida. Entre com um número inteiro ou real, positivo e maior que zero.");
                            continue;
                        }
                        break;
                    }
                    Retangulo retangulo = new Retangulo(largura,altura,corFigura, tipoFigura);
                    listaFiguras.Add(retangulo);
                }

                if (tipoFigura == TipoFigura.Circulo)
                {
                    while (true)
                    {
                        Console.Write($"Entre com o raio do {tipoFigura}: ");
                        string entrada = Console.ReadLine().Trim();
                        entrada = entrada.Replace(',', '.');
                        if (!double.TryParse(entrada, NumberStyles.Any, CultureInfo.InvariantCulture, out raio) || raio <= 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Entrada inválida. Entre com um número inteiro ou real, positivo e maior que zero.");
                            continue;
                        }
                        break;
                    }
                    Circulo circulo = new Circulo(raio,corFigura,tipoFigura);
                    listaFiguras.Add(circulo);
                }
            }
            return listaFiguras;
        }

        private static void Exibir()
        {
            var listaFiguras = Leitura();
            
            Console.Clear();
            Console.WriteLine($"Figuras:\n\n{string.Join("", listaFiguras)}\n");
        }
    }
}
