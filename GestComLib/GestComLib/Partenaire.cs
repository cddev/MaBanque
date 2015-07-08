using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace GestComLib
{
    public class Partenaire
    {
        //public string Trigram { get; private set; }
        private string _trigram;

        public string Trigram
        {
            get { return _trigram; }
            set { _trigram = MakeTrigram(); }
        }

        public string Nom { get; set; }
        public string Prenom { get; set; }
       


        public Partenaire()
        {

        }
        public Partenaire(string _n,string _p)
        {

            Nom = _n;
            Prenom = _p;
            //Specialité = _s;
        }
        private string MakeTrigram()
        {
            string _ret = "";
            string patternPrenom = @"^[A-Z]";
            string patternNom = @"^[A-Z]?[a-z]{1}";


           _ret = Regex.Split(this.Prenom, patternPrenom).Select(x=> x).ToString();
           _ret += Regex.Split(this.Nom, patternNom).Select(x => x).ToString();


            return _ret;
        }
    }
}
