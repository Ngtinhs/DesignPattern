using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class PetTiger : ITiger
    {
        public void Aboutme()
        {
            Console.WriteLine("Ho thu cung: Toi thich o rap xiec");
        }
    }
}
