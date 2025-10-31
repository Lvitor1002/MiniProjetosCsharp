using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco.Entites
{
    public class ContaBancaria
    {
        public Titular Titular{ get; set; }
        public double Saldo{ get; set; }

        public ContaBancaria(Titular titular, double saldo)
        {
            Titular = titular;
            Saldo = saldo;
        }
        https://www.udemy.com/course/aprenda-poo-com-c-net-60-visualstudio-code/learn/lecture/31657664#overview
    }
}
