using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns_Telecomunication.Decorators
{
    class InternetAccess : Access
    {
        public override void GetAccess(Client client)
        {
            client.AccessTypes.Add(AccessType.Internet);
            base.GetAccess(client);
        }
    }
}
