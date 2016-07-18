using System;
using System.Collections.Generic;

namespace StructuralPatterns_Telecomunication
{
    public class Client
    {
        public int ClientId { get; }
        public string Name { get; }
        public IProvider Provider { get; private set; }
        public Role Role { get; private set; }
        public IList<AccessType> AccessTypes { get; } = new List<AccessType>();

        //public Client(Client client)
        //{
        //    ClientId = client.ClientId;
        //    Name = client.Name;
        //    Provider = client.Provider;
        //    Role = client.Role;
        //    AccessTypes = client.AccessTypes;
        //}
        public Client(string name, IProvider provider, Role role, IList<AccessType> accesTypes)
        {
            if (name == null)
                throw new ArgumentNullException($"{nameof(name)} cannt be null");
           
            Name = name;
            Provider = provider;
            Role = role;
            AccessTypes = accesTypes;
        }

        public Client(string name, IProvider provider, Role role, AccessType accesTypes)
            : this(name, provider, role, new List<AccessType>())
        {
            AccessTypes.Add(accesTypes);
        }

        public override string ToString()
        {
            return $"Client name: {Name}, Role {Role}";
        }
    }
}