using System;
using System.Text;
using System.Collections.Generic;

namespace EditorHTML
{
    public static class Editor
    {
        private static List<string> listaLinhas = new List<string>();

        private static StringBuilder sbTextoCompleto = new StringBuilder();

        public static void MostrarEditor()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Console.WriteLine("MODO EDITOR (Pressione ESC para salvar e voltar ao menu)");
            Console.WriteLine("========================================================");
            Console.WriteLine();

            Iniciar();
        }

        public static void Iniciar()
        {
            listaLinhas.Clear();
            sbTextoCompleto.Clear();

            Console.WriteLine("Digite seu texto HTML (suporta tags <strong>):");
            Console.WriteLine();

            while (true)
            {
                string linha = LerLinha();

                if (linha == null) // ESC pressionado
                    break;

                listaLinhas.Add(linha);
                sbTextoCompleto.AppendLine(linha);
            }

            Console.WriteLine();
            Console.WriteLine("Texto salvo! Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        private static string LerLinha()
        {
            StringBuilder linha = new StringBuilder();
            ConsoleKeyInfo tecla;

            while (true)
            {
                tecla = Console.ReadKey(true);

                if (tecla.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    return linha.ToString();
                }
                else if (tecla.Key == ConsoleKey.Escape)
                {
                    return null;
                }
                else if (tecla.Key == ConsoleKey.Backspace)
                {
                    if (linha.Length > 0)
                    {
                        linha.Remove(linha.Length - 1, 1);
                        Console.Write("\b \b");
                    }
                }
                else
                {
                    linha.Append(tecla.KeyChar);
                    Console.Write(tecla.KeyChar);
                }
            }
        }

        public static string retornaStringBuilderTexto()
        {
            return sbTextoCompleto.ToString();
        }
    }
}
