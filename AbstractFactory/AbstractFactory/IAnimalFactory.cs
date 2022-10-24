using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //Astracrt Product
     public interface IAnimalFactory
    {
        IDog GetDog();
        ITiger GetTiger();
    }
}
