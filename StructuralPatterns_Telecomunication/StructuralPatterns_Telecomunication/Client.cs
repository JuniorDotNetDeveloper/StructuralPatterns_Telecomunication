using System.Collections.Generic;

namespace StructuralPatterns_Telecomunication
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public List<AccessType> AccessTypes { get; set; }
        public Role Role { get; set; }

        public override string ToString()
        {
            return $"Client name: {Name}, Role {Role}";
        }
    }
}