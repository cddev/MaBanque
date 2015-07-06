using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaBanque_BL
{
    class Banque
    {
        public List<Compte> Comptes { get; private set; }
        public string Nom { get; set; }
        public void AddCompte(Compte compte)
        {
            Comptes.Add(compte);
        }
    }
}
