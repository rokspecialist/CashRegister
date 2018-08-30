using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterEngineV2
{
    interface IRegister
    {
        void Scan(string barcode, float quantity);

        string GetBill();
    }
}
