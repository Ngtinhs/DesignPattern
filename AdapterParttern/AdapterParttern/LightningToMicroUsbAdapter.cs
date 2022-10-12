using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterParttern
{
    public class LightningToMicroUsbAdapter : MicroUsbPhone
    {
        private readonly LightningPhone lightningPhone;
        public LightningToMicroUsbAdapter(LightningPhone lightningPhone)
        {
            this.lightningPhone = lightningPhone;
        }
        public void useMicroUsb()
        {
            Console.WriteLine("MicroUsb connected");
            lightningPhone.useLightning();
        }
        public void recharge()
        {
            lightningPhone.recharge();
        }

        public void useLightning()
        {
            throw new NotImplementedException();
        }
    }
}
