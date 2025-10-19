using System;
using Arrays;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var meuArray = new int[5] {0,1,2,3,4};

            Console.WriteLine(meuArray[0]);
            Console.WriteLine(meuArray[1]);
            Console.WriteLine(meuArray[2]);
            Console.WriteLine(meuArray[3]);
            Console.WriteLine(meuArray[4]);

            Console.WriteLine("\n---===---===---===---===---===---===---===---===---===---===---===---===\n");





            //Use for quando precisar de controle total sobre o índice;
            for (var index = 0; index < meuArray.Length; index++) 
                Console.Write($"| {meuArray[index]} ");






            Console.WriteLine("\n\n---===---===---===---===---===---===---===---===---===---===---===---===\n");





            Console.WriteLine($"Array: {string.Join(", ",meuArray)}.\n");





            Console.WriteLine("\n---===---===---===---===---===---===---===---===---===---===---===---===\n");





            //use foreach quando quiser apenas percorrer todos os elementos de forma simples e legível.
            foreach (var item in meuArray)
                Console.WriteLine(item);





            Console.WriteLine("\n---===---===---===---===---===---===---===---===---===---===---===---===\n");




            var funcionarios = new Funcionario[5];
            funcionarios[0] = new Funcionario() 
            {
                Id = 12, 
                Nome = "Luiz"
            };

            foreach (var funcionario in funcionarios)
                Console.WriteLine($"Id: {funcionario.Id}\nNome: {funcionario.Nome}\n-=-=-=-=-=");




            Console.WriteLine("\n---===---===---===---===---===---===---===---===---===---===---===---===\n");

        }
    }
}
