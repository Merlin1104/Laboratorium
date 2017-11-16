using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium
{
    partial class Laborator
    {
        class VeduciLaboratoria : Laborator
        {
            private string name;
            private string surname;

            public void VypisMeno()
            {
                Console.WriteLine("Meno: {0} {1} ",name, surname);
            }

            public VeduciLaboratoria(string name, string surname)
            {
                this.name = name;
                this.surname = surname;
            }
        }
    }
}
