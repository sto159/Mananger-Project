using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5.domain
{
    class Userinfo
    {
        string Id { get; }
        string Pw { get; }
        string Name{ get; }
        int Age { get; }
        int Gender { get; }

        public Userinfo(string Id, string Pw, string Name, int Age, int Gender)
        {
            
        }
    }
}
