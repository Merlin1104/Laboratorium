using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium
{
    sealed class Odstredivka : Pristroj, IOvladaniPristroje
    {
        public override void VypisDetailniInformace()
        {
            Console.WriteLine("Toto je Odstredivka");
        }

        public override void VypisInformaceOPristroji()
        {
            Console.WriteLine("Cislo pristroja: 2");
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
