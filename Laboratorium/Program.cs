using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium
{
    class Program
    {
        static void Main(string[] args)
        {
            Laborator labak = new Laborator();

            Mikroskop mikroskop = new Mikroskop();
            mikroskop.VypisDetailniInformace();
            mikroskop.VypisInformaceOPristroji();
            mikroskop.zapni();

            
            
            
            

            Console.ReadLine();
        }
    }
}
