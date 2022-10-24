using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // Sản phẩm thực
     class WildTiger : ITiger
    {
        public void Aboutme()
        {
            Console.WriteLine("Con cop hoang da: Tui thich di san. Hmmmmm");
        }
    }
}
