
using System;

namespace StructuralPatterns_Telecomunication
{
    class MainProvider : IProvider
    {
        public void GetAccess(Client client)
        {
            Console.WriteLine($"Get access from main provider to: {client}");
        }
    }
}
