
using AbstracaoPrimeira.Enuns;

namespace AbstracaoPrimeira.Entities
{
    public abstract class Figura : IFigura
    {
        public CorFigura CorFigura{ get; set; }
        public TipoFigura TipoFigura { get; set; }

        protected Figura(CorFigura corFigura, TipoFigura tipoFigura)
        {
            CorFigura = corFigura;
            TipoFigura = tipoFigura;
        } 

        public abstract double AreaFigura();
    }
}
