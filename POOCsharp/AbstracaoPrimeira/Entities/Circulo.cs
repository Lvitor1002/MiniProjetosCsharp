using System;
using AbstracaoPrimeira.Enuns;

namespace AbstracaoPrimeira.Entities
{
    internal class Circulo : Figura
    {
        public double Raio{ get; set; }
     
        public Circulo(double raio, CorFigura corFigura, TipoFigura tipoFigura) : base(corFigura, tipoFigura)
            => Raio = raio;

        public override double AreaFigura()
            => (Math.PI * Math.Pow(Raio, 2));

        public override string ToString()
        {
            return $"Cor do Círculo: {CorFigura}\n" +
                $"Raio: {Raio}\n" +
                $"Área do Círculo: {AreaFigura():F2}\n" +
                $"-=-=-=-=-=-=-=-=-=-=-=-=\n";
        }
    }
}
