using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dataPadrao = new DateTime(); //Retorna data padrão

            var dataHoraAtual = DateTime.Now; //Retorna data padrão

            Console.WriteLine($"{dataHoraAtual}\n");

            Console.WriteLine($"Ano: {dataHoraAtual.Day}");
            Console.WriteLine($"Mês: {dataHoraAtual.Month}");
            Console.WriteLine($"Ano: {dataHoraAtual.Year}\n");
            Console.WriteLine($"Hora:  {dataHoraAtual.Hour}");
            Console.WriteLine($"Minutos: {dataHoraAtual.Minute}");
            Console.WriteLine($"Segundos: {dataHoraAtual.Second}\n\n");


            var dataFormatada1 = dataHoraAtual.ToString("dd/MM/yyyy HH:mm:ss");
            Console.WriteLine($"dataFormatada1: {dataFormatada1}\n");

            var dataFormatada2 = string.Format("{0:d}", dataHoraAtual);
            Console.WriteLine($"dataFormatada2: {dataFormatada2}\n");

            var dataFormatada3 = string.Format("{0:D}", dataHoraAtual);
            Console.WriteLine($"dataFormatada3: {dataFormatada3}\n");

            var dataFormatada4 = string.Format("{0:f}", dataHoraAtual);
            Console.WriteLine($"dataFormatada4: {dataFormatada4}\n\n---==---==---==--==--==\n");






            //                      //
            // Comparação de Datas  //
            //                      //

            if (dataHoraAtual == DateTime.Now)
                Console.WriteLine("As datas são iguais");
            else 
                Console.WriteLine("As datas são diferentes");




            ///////////////////////////////////////////////////////////
            




            if (dataHoraAtual.Date == DateTime.Now.Date)
                Console.WriteLine("As datas são iguais");
            else
                Console.WriteLine("As datas são diferentes");




            Console.WriteLine("\n---==---==---==--==--==\n");
            //                      //
            // CultureInfo em Datas //
            //                      //
            var br = new CultureInfo("pt-BR");
            var pt = new CultureInfo("pt-PT");
            var en = new CultureInfo("en-US");
            var de = new CultureInfo("de-DE");
            var culturaAtualMaquina = CultureInfo.CurrentCulture;

            Console.WriteLine($"{DateTime.Now.ToString("D",culturaAtualMaquina)}");






            Console.WriteLine("\n---==---==---==--==--==\n");
            //                      //
            //       TimeSpan       //              Subtrair uma hora da outra
            //                      //
            var tsHoraMinuto = new TimeSpan(2,20,0);
            var tsHoraMinutoSegundo = new TimeSpan(2, 20, 30);

            var diferenca = tsHoraMinutoSegundo - tsHoraMinuto;
            Console.WriteLine($"Diferença: {diferenca}");
        }
    }
}
