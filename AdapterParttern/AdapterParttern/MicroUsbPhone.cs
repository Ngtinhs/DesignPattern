using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterParttern
{
    public interface MicroUsbPhone
    {
        void recharge();
        void useLightning();
        void useMicroUsb();
    }
}
