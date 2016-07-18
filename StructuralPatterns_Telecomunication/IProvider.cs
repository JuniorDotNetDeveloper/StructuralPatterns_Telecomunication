using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns_Telecomunication
{
    interface IProvider
    {
        void GetAccess(Client client);
    }
}
