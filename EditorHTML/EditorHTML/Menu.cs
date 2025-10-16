using System;
namespace EditorHTML
{
    public static class Menu
    {
        public static void Exibir()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            DesenharTela();
        }
        public static void DesenharTela()
        {
            LinhasHorizontais();
            LinhasVerticais();
            LinhasHorizontais();
        }

        private static void LinhasHorizontais()
        {
            //Horizontal
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");
        }
        private static void LinhasVerticais()
        {
            //Vertical
            for (int linhas = 0; linhas <= 10; linhas++)
            {
                Console.Write("|");
                for (int i = 0; i <= 30; i++)
                    Console.Write(" ");
                Console.Write("|");
                Console.Write("\n");
            }
        }
    }
}
