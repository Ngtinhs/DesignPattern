using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Day la demo Astract Factory Pattern ***");
            IAnimalFactory animalFactory = FactoryProvider.GetAnimalFactory("wild");
            IDog dog = animalFactory.GetDog();
            dog.Aboutme();



            ITiger tiger = animalFactory.GetTiger();
            tiger.Aboutme();

            Console.WriteLine("**********************");


            animalFactory = FactoryProvider.GetAnimalFactory("pet");
            dog = animalFactory.GetDog();
            dog.Aboutme();
            tiger = animalFactory.GetTiger();
            tiger.Aboutme();
            Console.WriteLine("**********************");

        }
    }
}
