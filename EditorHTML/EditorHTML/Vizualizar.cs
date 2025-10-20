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
            var regexTagStrong = new Regex(@"<strong>(.*?)</strong>", RegexOptions.Singleline);
            int posicaoAtual = 0;

            // Percorre todas as partes do texto que contêm a tag <strong>
            foreach (Match correspondencia in regexTagStrong.Matches(texto))
            {
                // Exibe o trecho texto antes da próxima tag <strong>
                if (correspondencia.Index > posicaoAtual)
                {
                    Console.ForegroundColor = ConsoleColor.White;

                    int tamanhoTrecho = correspondencia.Index - posicaoAtual;

                                                        //Posição     ,Comprimento do trecho
                    string trechoTexto = texto.Substring(posicaoAtual, tamanhoTrecho);
                    Console.Write(trechoTexto);
                }

                // Extrai o texto entre as tags <strong> e </strong>
                string textoComTag = correspondencia.Value; // Exemplo: <strong>Exemplo</strong>

                string textoNegrito = textoComTag
                    .Replace("<strong>", "")
                    .Replace("</strong>", "");

                // Exibe o texto destacado em amarelo
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(textoNegrito);

                // Atualiza a posição para depois da tag atual
                posicaoAtual = correspondencia.Index + correspondencia.Length;
            }

            // Exibe o restante do texto (depois da última tag <strong>)
            if (posicaoAtual < texto.Length)
            {
                Console.ForegroundColor = ConsoleColor.White;

                string trechoRestante = texto.Substring(posicaoAtual); //Garante que nenhum pedaço de texto fique faltando e seja exibido
                Console.Write(trechoRestante);
            }
            Console.WriteLine();
        }
    }
}
