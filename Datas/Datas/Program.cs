
using System;

namespace Datas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var data = new DateTime(2025,10,01);
            Console.WriteLine(data.ToString("data"));
            Console.WriteLine(data.Year);
            Console.WriteLine(data.Month);
            Console.WriteLine(data.Day);
            Console.WriteLine(data.Hour);
            Console.WriteLine((int)data.DayOfWeek);
        }
    }
}
