using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class MonHocCuThe : Subject
    {
        public override void DoSomeWork()
        {
            Console.WriteLine("Toi tien hanh yeu cau cua ban");

        }
    }
}
