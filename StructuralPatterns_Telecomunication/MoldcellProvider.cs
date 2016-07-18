
using System;
using System.Collections.Generic;
using System.Linq;

namespace StructuralPatterns_Telecomunication
{
    class MoldcellProvider : IProvider
    {
        public static readonly Lazy<MoldcellProvider> Instance = new Lazy<MoldcellProvider>(() => new MoldcellProvider(), true);
        public string Name { get; } = "Moldcell";
        private MoldcellProvider() { }

        public IList<Client> Clients { get; set; } = new List<Client>();

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
