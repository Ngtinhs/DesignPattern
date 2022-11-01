using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPatttern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sourdough sourdough = new Sourdough();
            sourdough.Make();
            TwelveGrain twelveGrain = new TwelveGrain();
            twelveGrain.Make();
            WholeWheat wholeWheat = new WholeWheat();
            wholeWheat.Make();

        }
    }
}
