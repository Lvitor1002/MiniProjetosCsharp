
using Locadora.Entities;

namespace Locadora.Services.Interfaces
{
    public interface ICalculosServices
    {
        decimal RetornaValorLocacao(Locacao locacao);
        decimal RetornaValorImposto(decimal valorLocacao);
        decimal RetornaTotalPagamento(Locacao locacao);
    }
}
