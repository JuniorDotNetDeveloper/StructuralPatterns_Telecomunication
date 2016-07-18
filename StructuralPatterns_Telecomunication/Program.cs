using StructuralPatterns_Telecomunication.Decorators;
using StructuralPatterns_Telecomunication.Proxies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns_Telecomunication
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MoldcellProvider moldcellProvider = MoldcellProvider.Instance.Value;
            OrangeProvider orangeProvider = OrangeProvider.Instance.Value;

            InternetAccess addInternetAccess = new InternetAccess();
            TelephonyAccess addTepephonyAccess = new TelephonyAccess();
            SMSAccess addSmsAccess = new SMSAccess();


            Client c = new Client("Tom", moldcellProvider , Role.User, new List<AccessType> { AccessType.Internet, AccessType.Telephony });
            moldcellProvider.Clients.Add(c);

            RestrictedAccessProxy proxy = new RestrictedAccessProxy(moldcellProvider);
            proxy.GetAccess(c);

           // addSmsAccess.GetAccess(c);

            Console.ReadKey();
        }
    }
}
