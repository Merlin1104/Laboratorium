using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium
{
    abstract class Pristroj
    {
        

        abstract public void VypisDetailniInformace();

        public virtual void VypisInformaceOPristroji()
        {
            Console.WriteLine("Cislo pristroja: 0");
        }
    }
}
