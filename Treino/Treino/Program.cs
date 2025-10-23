/*
    Faça um programa que leia 10 valores numéricos e guarde-os em uma lista.
    No final, mostre a lista ordenada e qual foi o maior e o menor valor digitado e as suas respectivas POSIÇÕES na lista.
*/

//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace Treino
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//            => Exibir();

//        private static List<int> LerValores()
//        {
//            var valores = new List<int>();

//            Console.WriteLine("Digite 10 valores numéricos: ");
//            for (int i = 0; i < 10; i++)
//            {
//                int valor;
//                while (true)
//                {
//                    Console.Write($"Valor {i + 1}ª: ");
//                    string entrada = Console.ReadLine().Trim();
//                    if (!int.TryParse(entrada, out valor))
//                    {
//                        Console.Clear();
//                        Console.WriteLine("Valor inválido. Tente novamente.");
//                        continue;
//                    }
//                    break;
//                }
//                valores.Add(valor);
//            }
//            return valores;
//        }
//        private static void Exibir()
//        {
//            var valores = LerValores();
//            Console.Clear();
//            Console.WriteLine($"Todos os valores cadastrados: {string.Join(", ", valores)}.\n-----=====-----=====-----=====-----=====-----=====-----=====\n");
//            Console.WriteLine($"Valores Ordenados: {string.Join(", ", valores.OrderBy(x => x))}.\n-----=====-----=====-----=====-----=====-----=====-----=====\n");
//            Console.WriteLine($"Maior valor: {valores.Max()} | Posição: {valores.IndexOf(valores.Max()) + 1}ª.\n-----=====-----=====-----=====-----=====-----=====-----=====\n");
//            Console.WriteLine($"Menor valor: {valores.Min()} | Posição: {valores.IndexOf(valores.Min()) + 1}ª.\n-----=====-----=====-----=====-----=====-----=====-----=====\n");
//        }
//    }
//}

/*
    Crie um programa onde o usuário possa digitar vários valores numéricos e cadastre-os em uma lista.
    Caso o número já exista lá dentro, ele não será adicionado.
    No final, serão exibidos todos os valores únicos digitados, em ordem crescente.
*/

//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace Treino
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//            => Exibir();

//        private static List<int> LerValores()
//        {
//            var valoresUnicos = new List<int>();
//            int valor;

//            Console.Write("Digite alguns valores abaixo\nPara sair digite 'Sair'\n");
//            while (true)
//            {
//                string entrada = Console.ReadLine().Trim().ToLower();

//                if (entrada == "sair")
//                    break;

//                if (!int.TryParse(entrada, out valor))
//                {
//                    Console.Clear();
//                    Console.WriteLine("Entrada inválida. Tente novamente.");
//                    continue;
//                }
//                if (valoresUnicos.Contains(valor) || valor < 0)
//                {
//                    Console.Clear();
//                    Console.WriteLine($"Valor {valor} duplicado! Não será adicionado.");
//                    continue;
//                }
//                valoresUnicos.Add(valor);
//            }
//            return valoresUnicos;
//        }
//        private static void Exibir()
//        {
//            var valoresUnicos = LerValores();
//            Console.Clear();
//            Console.WriteLine($"Valores únicos cadastrados em ordem crescente: {string.Join(", ", valoresUnicos.OrderBy(x => x))}.\n-----=====-----=====-----=====-----=====-----=====-----=====\n");
//        }
//    }
//}

/*
    Crie um programa que vai ler vários números e colocar em uma lista.
    Depois disso, crie duas listas extras que vão conter apenas os valores pares e os valores ímpares digitados, respectivamente.
    Ao final, mostre o conteúdo das três listas geradas.
*/

//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace Treino
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//            => Exibir();

//        private static List<int> LerValores()
//        {
//            var ListaValores = new List<int>();

//            Console.Write("Digite um número (ou 'sair' para finalizar): ");
//            while (true)
//            {
//                string entrada = Console.ReadLine().Trim().ToLower();
//                if (entrada == "sair")
//                    break;

//                if (!int.TryParse(entrada, out int valor))
//                {
//                    Console.Clear();
//                    Console.WriteLine("Entrada inválida. Tente novamente.");
//                    continue;
//                }
//                ListaValores.Add(valor);
//            }
//            return ListaValores;
//        }

//        private static (List<int> listaValoresPares, List<int> listaValoresImpares, List<int> listaValores) ManipulaLista()
//        {
//            var listaValoresImpares = new List<int>();
//            var listaValoresPares = new List<int>();

//            var listaValores = LerValores();

//            foreach (var valor in listaValores)
//                if (valor % 2 == 0)
//                    listaValoresPares.Add(valor);
//                else
//                    listaValoresImpares.Add(valor);

//            return (listaValoresPares, listaValoresImpares, listaValores);
//        }

//        private static void Exibir()
//        {
//            var (listaValoresPares, listaValoresImpares, listaValores) = ManipulaLista();
//            Console.Clear();

//            if (listaValoresPares.Count == 0 && listaValoresImpares.Count == 0)
//            {
//                Console.WriteLine("Nenhum valor foi digitado.");
//                return;
//            }
//            Console.WriteLine($"Lista de valores: {string.Join(", ", listaValores.OrderBy(x => x))}.\n----------------------------------------");
//            Console.WriteLine($"Lista de valores pares: {string.Join(", ", listaValoresPares.OrderBy(x => x))}.\n----------------------------------------");
//            Console.WriteLine($"Lista de valores ímpares: {string.Join(", ", listaValoresImpares.OrderBy(x => x))}.\n----------------------------------------");
//        }
//    }
//}

/*
    Crie um programa que declare uma matriz de dimensão 3x3 e preencha com valores lidos pelo teclado.
    No final, mostre a matriz na tela, com a formatação correta.

    mostrando no final:
    A) A soma de todos os valores pares digitados.
    B) A soma dos valores da terceira coluna.
    C) O maior valor da segunda linha.
*/
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography;

//namespace Treino
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//            => Exibir();

//        private static int[,] LerValores()
//        {
//            var matriz = new int[3, 3];

//            Console.WriteLine("Digite os valores abaixo para preencher a matriz 3x3\n");
//            for (int linha = 0; linha < 3; linha++)
//            {
//                for (int coluna = 0; coluna < 3; coluna++)
//                {
//                    Console.Write($"[{linha + 1}ª,{coluna + 1}ª]: ");

//                    int valor;
//                    while (true)
//                    {
//                        string entrada = Console.ReadLine().Trim();
//                        if (!int.TryParse(entrada, out valor) || valor < 0)
//                        {
//                            Console.Clear();
//                            Console.WriteLine("Entrada inválida. Digite um número inteiro positivo.");
//                            continue;
//                        }
//                        break;
//                    }
//                    matriz[linha, coluna] = valor;
//                }

//            }
//            return matriz;
//        }

//        private static void Exibir()
//        {
//            var matriz = LerValores();
//            Console.Clear();
//            Console.WriteLine("\n-=-= Matriz 3x3 preenchida =-=-\n");
//            Console.WriteLine("_______________________________");
//            for (int linha = 0; linha < 3; linha++)
//            {
//                Console.Write("|");

//                for (int coluna = 0; coluna < 3; coluna++)
//                    Console.Write($"{matriz[linha, coluna],5}    |");

//                Console.WriteLine("");
//            }
//            Console.WriteLine("-------------------------------\n");

//            //A) A soma de todos os valores pares digitados.
//            double somaMatrizPares = matriz.Cast<int>().Where(x => x % 2 == 0).Sum();
//            Console.WriteLine($"A soma de todos os valores pares digitados: {somaMatrizPares}");

//            //B) A soma dos valores da terceira coluna.
//            double somaTerceiraColuna = Enumerable.Range(0, 3).Select(i => matriz[i, 2]).Sum(); //Enumerable.Range(0, 3) gera uma sequência: 0, 1, 2
//            Console.WriteLine($"A soma dos valores da terceira coluna: {somaTerceiraColuna}");

//            //C) O maior valor da segunda linha.
//            double MaiorValorSegundaLinha = Enumerable.Range(0, 3).Select(i => matriz[1, i]).Max(); //Enumerable.Range(0, 3) gera uma sequência: 0, 1, 2
//            Console.WriteLine($"O maior valor da segunda linha: {MaiorValorSegundaLinha}\n");
//            Console.WriteLine("-------------------------------\n");
//        }
//    }
//}

/*
 Crie um programa que leia nome e duas notas de vários alunos e guarde tudo em uma lista composta.
No final, mostre um boletim contendo a média de cada um e permita que o usuário possa mostrar as notas de cada aluno individualmente.
 */
