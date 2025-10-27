using System.Globalization;

namespace Composicao
{
    public class Item
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorTotal { get; set; }
        public Item(string nome, int quantidade)
        {
            Nome = nome;
            Quantidade = quantidade;
        }

        public void RetornaValorTotalItem(decimal valorUnitario)
            => ValorTotal = Quantidade * valorUnitario;

        override public string ToString()
            => $"Nome: {Nome}\nQuantidade: {Quantidade}\nValor Total: {ValorTotal.ToString("C", CultureInfo.CurrentCulture)}\n-=-=-=-=-=-=-=-=-=-=-=-=\n";
    }
}
