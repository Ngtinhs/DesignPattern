using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // Sản phẩm thực
    class WildDog : IDog
    {
        public void Aboutme()
        {
            Console.WriteLine("Con cho hoang da: Tui thich tu do.Gaugauauuuu");
        }
    }
}
