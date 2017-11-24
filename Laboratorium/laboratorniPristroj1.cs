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
            base.VypisInformaceOPristroji();
            Console.WriteLine("Som mikroskop");
                       
        }

        public void Zapni ()
        {
            zapnute = true;
        }

        public void Vypni ()
        {
            zapnute = false;
        }


        
        
    }
}
