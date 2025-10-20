using System;
using System.Globalization;


namespace Moedas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //                      //
            // CultureInfo em Moedas //
            //                      //


            Console.WriteLine("\n---==---==---==--==--==\n");
            decimal valor = 100.55m;
            Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))); // R$ 100,55

            Console.WriteLine("\n---==---==---==--==--==\n");
            Console.WriteLine(Math.Round(valor)); // Arredonda para o inteiro mais próximo: 101


            Console.WriteLine("\n---==---==---==--==--==\n");
            Console.WriteLine(Math.Ceiling(valor)); // Arredonda para cima: 101


            Console.WriteLine("\n---==---==---==--==--==\n");
            Console.WriteLine(Math.Floor(valor)); // Arredonda para baixo: 100 
        }
    }
}
