using System.Collections.Generic;
using System.Linq;

namespace Composicao
{
    public class Cesta
    {
        public List<Item> ListaItens { get; set; } //Composição, pois a cesta "tem" relação com itens que vem de outra classe

        public Cesta(List<Item> listaItens) // Sobrescreve o método ToString para retornar o nome do item.
            => ListaItens = listaItens;

        public decimal SomaTotalValoresItens()
            => ListaItens.Sum(x => x.ValorTotal);

    }
}
