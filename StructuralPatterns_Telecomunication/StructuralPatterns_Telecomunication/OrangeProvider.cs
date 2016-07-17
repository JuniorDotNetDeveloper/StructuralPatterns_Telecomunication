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

        private OrangeProvider() {}

        public List<Client> Clients { get; set; }

        public void GetAccess(Client client)
        {
            Console.WriteLine($"Orange get access to {client}");
        }
    }
}
