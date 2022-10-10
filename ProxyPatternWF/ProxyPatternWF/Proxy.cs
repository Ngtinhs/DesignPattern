using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPatternWF
{
    public class Proxy : Subject
    {
        Subject subject;
        public Proxy()
        {
            subject = null;
        }
        public Proxy (Subject subject)
        {
            this.subject = subject;
        }
        public override string DoSomeWork()
        {
            string t = "Xin chao ban";

            if (subject == null)
            {
                subject = new Toan();
            }
            return t + "\n" + subject.DoSomeWork() + "\n";
        }
    }
}
