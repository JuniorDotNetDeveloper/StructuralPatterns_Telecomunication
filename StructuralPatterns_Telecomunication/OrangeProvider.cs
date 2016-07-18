using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns_Telecomunication
{
    class OrangeProvider : IProvider
    {
        public static readonly Lazy<OrangeProvider> Instance = new Lazy<OrangeProvider>( () => new OrangeProvider(), true);
        public string Name { get; } = "Orange";
        private OrangeProvider() {}

        public List<Client> Clients { get; set; }

        public void GetAccess(Client client)
        {
            Console.WriteLine($"Moldcell get access to {client}");

            if (client.AccessTypes.Contains(AccessType.Telephony))
                GetTelephonyAccess(client);
            if (client.AccessTypes.Contains(AccessType.SMS))
                GetSMSAccess(client);
            if (client.AccessTypes.Contains(AccessType.Internet))
                GetInternetAccess(client);
        }


        private void GetInternetAccess(Client client)
        {

            Console.WriteLine("Internet access");
        }

        private void GetTelephonyAccess(Client client)
        {

            Console.WriteLine("Telephony access");
        }

        private void GetSMSAccess(Client client)
        {

            Console.WriteLine("SMS access");
        }
    }
}
