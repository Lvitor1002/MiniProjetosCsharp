using System;

namespace Exceptions
{
    public class MinhaException : Exception
    {
        public DateTime QuandoOcorreu { get; set; }

        public MinhaException(DateTime quandoOcorreu) =>
            QuandoOcorreu = quandoOcorreu;

        //Chamando -> throw new MinhaException(DateTime.Now)

    }
}
