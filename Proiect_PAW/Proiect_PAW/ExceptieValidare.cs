using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    class ExceptieValidare : Exception
    {
        public override string Message
        {
            get { return "Exceptie validare input"; }
        }
    }
}
