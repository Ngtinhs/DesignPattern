using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPatternWF
{
    public class Toan : Subject
    {
        public override String DoSomeWork()
        {
            return "Toi dang lam bai tap toan";
        }
    }
}
