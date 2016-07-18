using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns_Telecomunication.Decorators
{
    class TelephonyAccess : Access
    {
        public override void GetAccess(Client client)
        {
            client.AccessTypes.Add(AccessType.Telephony);
            base.GetAccess(client);
            Console.WriteLine("Telephony access");
        }
    }
}
