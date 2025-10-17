using System;
using System.Text.RegularExpressions;


namespace EditorHTML
{
    public static class Vizualizar
    {
        public static void Exibir(string texto)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Modo de Vizualização");
            Console.WriteLine("---------------------");
            TrocarTexto(texto);
            Console.WriteLine("---------------------");
            Console.ReadKey();
            Menu.Exibir();
        }

        public static void TrocarTexto(string texto)
        {
                                    //Pega tudo que começa com <strong> e termina com </strong> e captura o conteúdo entre eles.
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var palavras = texto.Split(' ');

            for (var i = 0; i < palavras.Length; i++) 
            { 
                if(strong.IsMatch(palavras[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    var buscarPalavra = palavras[i].Substring(palavras[i].IndexOf('>') + 1, 
                                        (
                                            (palavras[i].LastIndexOf('<') - 1) - 
                                            palavras[i].IndexOf('>')
                                        ));

                    Console.Write(buscarPalavra);
                    Console.Write(" ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(palavras[i]);
                    Console.Write(" ");
                }
            }
        }
    }
}
