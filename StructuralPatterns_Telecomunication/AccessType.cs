using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns_Telecomunication
{
    public enum AccessType : byte
    {
        Internet,
        SMS,
        Telephony
    }

    public enum Role : byte
    {
        Admin,
        User
    }
}
