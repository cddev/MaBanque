using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestComLib
{
    public class Client:Partenaire
    {
        public string Societé{ get; set; }


        public Client(string _n, string _p, string _s):base(_n,_p)
        {
            Societé = _s;
    }

    }
}
