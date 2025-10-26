
using AbstracaoPrimeira.Enuns;

namespace AbstracaoPrimeira.Entities
{
    public class Retangulo : Figura
    {
        public double Largura { get; set; }
        public double Altura{ get; set; }

        public Retangulo(double  largura, double altura, CorFigura corFigura, TipoFigura tipoFigura) :base(corFigura, tipoFigura)
        {
            Largura = largura;
            Altura = altura;
        }

        public override double AreaFigura()
            => Largura * Altura;

        public override string ToString()
        {
            return $"Cor do Retangulo: {CorFigura}\n" +
                $"Largura: {Largura}\n" +
                $"Altura: {Altura}\n" +
                $"Área do Retangulo: {AreaFigura():F2}\n" +
                $"-=-=-=-=-=-=-=-=-=-=-=-=\n";
        }
    }
}
