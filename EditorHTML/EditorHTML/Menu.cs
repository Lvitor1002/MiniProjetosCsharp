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

            short opcao;
            while (true)
            {
                ExibirOpcoes();
                string entrada = Console.ReadLine().Trim();
                if(!short.TryParse(entrada, out opcao))
                {
                    Console.Clear();
                    Console.SetCursorPosition(10, 11);
                    Console.Write("Opção inválida!");
                    continue;
                }
                break;
            }
            ManipularOpcaoMenu(opcao);
        }
        

        private static void ManipularOpcaoMenu(short opcao)
        {
            switch (opcao)
            {
                case 1:
                    Console.Clear();
                    Editor.Mostrar(); 
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Vizualizar"); 
                    break;

                case 0:
                    Console.Clear();
                    Environment.Exit(0);
                    break;
            }
        }
        private static void ExibirOpcoes()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("============");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo Arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
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
