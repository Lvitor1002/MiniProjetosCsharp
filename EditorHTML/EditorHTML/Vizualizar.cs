using System;
using System.Text.RegularExpressions;

namespace EditorHTML
{
    public static class Vizualizador
    {
        public static void ExibirTexto(string texto)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Console.WriteLine("MODO VISUALIZAÇÃO");
            Console.WriteLine("=================");
            Console.WriteLine();

            if (string.IsNullOrEmpty(texto))
                Console.WriteLine("Nenhum texto para visualizar.");
            else
                ProcessarTexto(texto);

            Console.WriteLine("=================");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        private static void ProcessarTexto(string texto)
        {
            var tagStrong = new Regex(@"<strong>(.*?)</strong>", RegexOptions.Singleline);

            int ultimaPosicao = 0;

            // Percorre cada correspondência de <strong> no texto
            foreach (Match match in tagStrong.Matches(texto))
            {
                // Exibe o texto normal antes da próxima tag <strong>
                if (match.Index > ultimaPosicao)
                {
                    Console.ForegroundColor = ConsoleColor.White;

                    string textoNormal = texto.Substring(ultimaPosicao, match.Index - ultimaPosicao);
                    Console.Write(textoNormal);
                }

                // Extrai o texto entre as tags <strong> e </strong>
                string tagCompleta = match.Value; // Exemplo: <strong>Exemplo</strong>

                string textoNegrito = tagCompleta
                    .Replace("<strong>", "")
                    .Replace("</strong>", "");

                // Exibe o texto destacado em amarelo
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(textoNegrito);

                // Atualiza a posição para depois da tag atual
                ultimaPosicao = match.Index + match.Length;
            }

            // Exibe o restante do texto (depois da última tag <strong>)
            if (ultimaPosicao < texto.Length)
            {
                Console.ForegroundColor = ConsoleColor.White;

                string textoRestante = texto.Substring(ultimaPosicao);
                Console.Write(textoRestante);
            }

            Console.WriteLine();
        }

    }
}
