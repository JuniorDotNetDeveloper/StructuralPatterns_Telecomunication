namespace StructuralPatterns_Telecomunication.Proxies
{
    class LazyAccess
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
