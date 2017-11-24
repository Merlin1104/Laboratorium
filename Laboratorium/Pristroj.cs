using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium
{
    abstract class Pristroj
    {

        protected bool zapnute;
        
        public string Nazov;

        abstract public void VypisDetailniInformace();

        public virtual void VypisInformaceOPristroji()
        {
            Console.WriteLine("Pristroj kt nazov je {0}",Nazov);
        }

        protected void VypisStav()
        {
            Console.WriteLine("Zapnuto: {0}", zapnute);
        }

       
    }

}
