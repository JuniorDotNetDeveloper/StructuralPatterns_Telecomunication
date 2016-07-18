
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
            client.Provider.GetAccess(client);
        }
    }
}
