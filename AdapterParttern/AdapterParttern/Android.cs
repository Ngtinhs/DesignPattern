using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterParttern
{
    public class Android : MicroUsbPhone
    {
        private bool connector;
        public void useMicroUsb()
        {
            connector = true;
            Console.WriteLine("MicroUsb connected");

        }
        public void recharge()
        {
            if (connector)
            {
                Console.WriteLine("Recharge started");
                Console.WriteLine("Recharge finished");
            }
            else
            {
                Console.WriteLine("Connect MicroUsb first");
            }
        }

        public void useLightning()
        {
            throw new NotImplementedException();
        }
    }
}

