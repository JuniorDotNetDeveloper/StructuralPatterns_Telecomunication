using System;

namespace StructuralPatterns_Telecomunication.Decorators
{
    class SMSAccess : Access
    {
        public override void GetAccess(Client client)
        {
            client.AccessTypes.Add(AccessType.SMS);
            base.GetAccess(client);
            Console.WriteLine("Sms access");
        }
    }
}
