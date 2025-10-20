using System;
using System.Collections.Generic;

namespace EditorHTML
{
    public static class Menu
    {
        private static string textoAtual = "";

        public static void ExibirMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;

                DesenharTela();

                short opcao;
                while (true)
                {
                    ExibirOpcoes();

                    string entrada = Console.ReadLine().Trim();

                    if (!short.TryParse(entrada, out opcao) || opcao < 0 || opcao > 2)
                    {
                        Console.SetCursorPosition(3, 12);
                        Console.Write("Opção inválida! Pressione qualquer tecla...");
                        Console.ReadKey();

                        Console.SetCursorPosition(3, 12);
                        Console.Write(new string(' ', 50));
                        continue;
                    }
                    break;
                }

                if (!ManipularOpcaoMenu(opcao))
                    break;
            }
        }

        private static bool ManipularOpcaoMenu(short opcao)
        {
            switch (opcao)
            {
                case 1:
                    Editor.MostrarEditor();
                    textoAtual = Editor.retornaStringBuilderTexto();
                    break;

                case 2:
                    if (!string.IsNullOrEmpty(textoAtual))
                        Vizualizador.ExibirTexto(textoAtual);
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Nenhum texto para visualizar!");
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                    }
                    break;

                case 0:
                    Console.Clear();
                    Console.WriteLine("Saindo do Editor HTML...");
                    return false;
            }
            return true;
        }

        private static void ExibirOpcoes()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("EDITOR HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("============");
            Console.SetCursorPosition(3, 5);
            Console.WriteLine("Selecione uma opção abaixo:");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("1 - Novo Arquivo");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("2 - Visualizar Arquivo");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 11);
            Console.Write("Opção: ");
        }

        private static void DesenharTela()
        {
            LinhasHorizontais();
            LinhasVerticais();
            LinhasHorizontais();
        }

        private static void LinhasHorizontais()
        {
            Console.Write("+");
            for (int i = 0; i <= 50; i++)
                Console.Write("-");
            Console.Write("+");
            Console.WriteLine();
        }

        private static void LinhasVerticais()
        {
            for (int linhas = 0; linhas <= 15; linhas++)
            {
                Console.Write("|");
                for (int i = 0; i <= 50; i++)
                    Console.Write(" ");
                Console.Write("|");
                Console.WriteLine();
            }
        }
    }
}
