using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium
{
    partial class Laborator
    {
        public Pristroj LaboratornyPristroj1;
        public Pristroj LaboratornyPristroj2;


        public void SpustVyzkum()
        {
            VeduciLaboratoria veduci = new VeduciLaboratoria("Jozko");
            LaboratornyPristroj1 = new Mikroskop();
            LaboratornyPristroj2 = new Odstredivka();
            LaboratornyPristroj1.Nazov = "hn 301";
            LaboratornyPristroj2.Nazov = "abc 3002";

            IOvladaniPristroje ovladanie = (IOvladaniPristroje) LaboratornyPristroj1;
            ovladanie.Zapni();

            LaboratornyPristroj1.VypisDetailniInformace();
            LaboratornyPristroj2.VypisDetailniInformace();
        }

        public void InfoVeduci()
        {
            Console.WriteLine("toto je info o veducom");
        }

        public virtual void VypisASpust()
        {

        }

        
        


    }
}
