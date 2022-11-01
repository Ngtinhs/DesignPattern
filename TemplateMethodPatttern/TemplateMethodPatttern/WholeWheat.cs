using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPatttern
{
    class WholeWheat : Bread
    {
        public override void Bake()
        {
            Console.WriteLine("Baking the Whole Wheat Bread. (15 minutes)");
        }

        public override void MixIngredients()
        {
            Console.WriteLine("Grather Ingredients for Whole Wheat Bread.");
        }
    }
}
