
using System;
using System.Collections.Generic;

namespace StructuralPatterns_Telecomunication
{
    class MoldcellProvider : IProvider
    {
        public static readonly Lazy<MoldcellProvider> Instance = new Lazy<MoldcellProvider>(() => new MoldcellProvider(), true);

        private MoldcellProvider() { }

        public List<Client> Clients { get; set; }

        public void GetAccess(Client client)
        {
            Console.WriteLine($"Moldcell get access to {client}");
        }
    }
}
