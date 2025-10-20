using System;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*                          //
            //   Exceptions/Exceções    //
            //                          //

            Funciona como um mecanismo para sinalizar que algo inesperado aconteceu amenizando o estouro de erro para cliente,
            e permiti que o desenvolvedor lide com a situação de forma controlada.

            Para evitar que o programa se encerre abruptamente ao encontrar um erro, usamos Exceptions
            */

            var array = new int[3];

            try
            {
                for (int i = 0; i <= 3; i++)
                    Console.WriteLine($"{array[i] += i}");

                //Cadastrar("");
            }
            catch (IndexOutOfRangeException ex)                     // Personalizando o tipo de exceção || Mais específico
            {
                Console.WriteLine("\nMensagem: " + ex.Message);
            }
            catch (ArgumentNullException ex)                        // Mais específico
            {
                Console.WriteLine("\nMensagem: " + ex.Message);
            }
            catch (Exception ex)                                    // Erro genérico || Mais genérico
            {
                Console.WriteLine("\nMensagem: " + ex.Message);
            }
            finally                                                 // Sempre será executado independente de ter ocorrido erro ou não
            {
                //Aqui pode servir para limpeza de recursos, fechamento de conexões, fechar arquivos, etc..
                Console.WriteLine("\nFim do programa.\n-=-=-=-=-=-=-=-=-=\n");
            }
        }

        //private static void Cadastrar(string texto)
        //{
        //    if (string.IsNullOrEmpty(texto))
        //        throw new ArgumentNullException("O texto não pode ser nulo ou vazio.");
        //}
    }
}
