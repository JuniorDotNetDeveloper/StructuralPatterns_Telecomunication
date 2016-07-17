using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns_Telecomunication.Decorators
{
    abstract class Access : IProvider
    {
        protected IProvider _provider;

        public void SetPermission(IProvider provider)
        {
            _provider = provider;
        }
        public virtual void GetAccess(Client client)
        {
            _provider?.GetAccess(client);
        }
    }
}
