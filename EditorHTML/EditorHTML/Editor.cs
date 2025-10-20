using System;
using System.Text;
using System.Collections.Generic;

namespace EditorHTML
{
    public static class Editor
    {
        //private static List<string> listaLinhas { get; set; } = new List<string>();

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
            //listaLinhas.Clear();
            sbTextoCompleto.Clear();

            Console.WriteLine("Digite seu texto HTML (suporta tags <strong>):");
            Console.WriteLine();

            while (true)
            {
                string conteudo = retornaConteudoDigitado();

                if (conteudo == null) // ESC pressionado
                    break;

                //listaLinhas.Add(conteudo);
                sbTextoCompleto.AppendLine(conteudo);
            }

            Console.WriteLine();
            Console.WriteLine("Texto salvo! Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        private static string retornaConteudoDigitado()
        {
            StringBuilder conteudoDigitado = new StringBuilder();
            ConsoleKeyInfo tecla;

            while (true)
            {
                tecla = Console.ReadKey(true);

                if (tecla.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    return conteudoDigitado.ToString();
                }
                else if (tecla.Key == ConsoleKey.Escape)
                {
                    return null;
                }
                else if (tecla.Key == ConsoleKey.Backspace && conteudoDigitado.Length > 0) // Se o usuário pressionar BACKSPACE e houver pelo menos um caractere digitado:
                {
                    conteudoDigitado.Remove(conteudoDigitado.Length - 1, 1); // Remove o último caractere da string armazenada
                    Console.Write("\b \b"); // Move o cursor uma posição para trás, apaga o caractere na tela e move de novo para trás
                }
                else
                {
                    conteudoDigitado.Append(tecla.KeyChar);
                    Console.Write(tecla.KeyChar);
                }
            }
        }

        public static string retornaStringBuilderTextoDigitado()
        {
            return sbTextoCompleto.ToString();
        }
    }
}
