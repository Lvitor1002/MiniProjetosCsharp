using System;
using System.Collections.Generic;
using System.Globalization;

namespace Composicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listaItems = new List<Item>();

            Item item1 = new Item("luiz", 12);
            Item item2 = new Item("vitor", 2);

            item1.RetornaValorTotalItem(2);
            item2.RetornaValorTotalItem((decimal)1.5);

            Cesta cesta = new Cesta(listaItems);
            cesta.ListaItens.Add(item1);
            cesta.ListaItens.Add(item2);

            decimal totalValoresItens = cesta.SomaTotalValoresItens();

            Console.WriteLine($"{string.Join("\n", cesta.ListaItens)}");
            Console.WriteLine($"Valor Total dos itens da Cesta: {totalValoresItens.ToString("C", CultureInfo.CurrentCulture)}\n-=-=-=-=-=-=-=-=-=-=-=-=\n");

        }
    }
}
