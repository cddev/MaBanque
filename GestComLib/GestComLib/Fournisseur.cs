using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestComLib
{
    public class Fournisseur:Partenaire
    {
        public string Specialité { get; set; }

        public Fournisseur(string _n,string _p,string _s):base(_n,_p)
        {
            Specialité = _s;
        }
    }
}
