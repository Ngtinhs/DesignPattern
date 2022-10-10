using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPatternWF
{
    public class Van : Subject
    {
        public override string DoSomeWork()
        {
            {
                return "Toi dang lam bai tap Van";
            }
        }
    }
}
