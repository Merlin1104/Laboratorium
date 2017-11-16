using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium
{
    sealed class Mikroskop : Pristroj, IOvladaniPristroje
    {
        public override void VypisDetailniInformace()
        {
            Console.WriteLine("Toto je Mikroskop");
        }

        public override void VypisInformaceOPristroji()
        {
            Console.WriteLine("Cislo pristroja: 1");
        }

        public void vypni()
        {
            Console.WriteLine("Vypinam pristroj");
        }

        public void zapni()
        {
            Console.WriteLine("Zapinam pristroj");
        }
    }
}
