using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns_Telecomunication.Proxies
{
    class LazyAccess : IProvider
    {
        private IProvider _provider;

        public void GetAccess(Client client)
        {
            if (_provider == null)
                _provider = new MainProvider();

            _provider.GetAccess(client);
        }


    }
}
