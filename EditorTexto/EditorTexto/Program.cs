using System;
using System.ComponentModel.Design;

namespace EditorTexto
{
    class Program
    {
        static void Main(string[] args)
            =>Menu();
        private static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que deseja fazer?\n1 - Abrir Arquivo\n2 - Criar Novo Arquivo\n0 - Sair\n");
            while (true)
            {
                string entrada = Console.ReadLine().Trim(); //short para otimizar o uso de memória, Usa 2 bytes de memória.
                
                if(!short.TryParse(entrada, out short escolha) || escolha < 0 || escolha > 2)
                {
                    Console.Clear();
                    Console.WriteLine("Escolha inválida! ente novamente");
                    continue;
                }

                switch (escolha)
                {
                    case 1:
                        Abrir();
                        break;

                    case 2:
                        Editar();
                        break;

                    case 0:
                        Console.Clear();
                        Console.WriteLine("Saindo...");
                        return;

                    default:
                        Console.Clear();
                        Console.WriteLine("Escolha inválida!");
                        continue;
                }
            }
        }

        private static void Editar()
        {
            Console.WriteLine("Editou");
        }

        private static void Abrir()
        {
            Console.WriteLine("Abriu");
        }
    }
}