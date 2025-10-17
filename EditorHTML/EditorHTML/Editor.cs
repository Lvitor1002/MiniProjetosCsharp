

using System;
using System.Text;

namespace EditorHTML
{
    public static class Editor
    {
        public static void Mostrar()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("-----------");
            Iniciar();
        }
        public static void Iniciar()
        {
            //Quando o texto possui muitas linhas o ideal é usar o StringBuilder para melhorar a performance
            var sb = new StringBuilder();
            ConsoleKey key;
            do
            {
                sb.Append(Console.ReadLine());
                sb.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.Clear();
            Console.WriteLine("-----------");
            Console.Write("Deseja salvar o arquivo? ");
            Vizualizar.Exibir(sb.ToString());
        }
    }
}
