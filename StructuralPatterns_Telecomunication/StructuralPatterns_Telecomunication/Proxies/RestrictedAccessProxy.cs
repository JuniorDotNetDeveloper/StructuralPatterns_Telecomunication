using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns_Telecomunication.Proxies
{
    class RestrictedAccessProxy : IProvider
    {
        private IProvider _provider;

        public RestrictedAccessProxy(IProvider provider)
        {
            _provider = provider;
        }
        public void GetAccess(Client client)
        {
            
        }
    }
}
