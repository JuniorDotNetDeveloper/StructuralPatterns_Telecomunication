﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns_Telecomunication.Decorators
{
    class InternetAccess : Access
    {
        //private IProvider _provider;
        //public InternetAccess(IProvider provider)
        //{
        //    _provider = provider;
        //}
        public override void GetAccess(Client client)
        {
            client.AccessTypes.Add(AccessType.Internet);
            base.GetAccess(client);
            Console.WriteLine("Internet access");
        }
    }
}
