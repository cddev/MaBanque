namespace MaBanque_BL
{
    internal class CompteEpargne : Compte
    {
        public double TauxAbondement { get; private set; }

        public CompteEpargne(string proprietaire) : base(proprietaire)
        {
            TauxAbondement = 0;
        }

        public CompteEpargne(string proprietaire, double tauxAbondement)
            : this(proprietaire)
        {
            TauxAbondement = tauxAbondement;
        }

        public void VerserAbondement()
        {
            Solde *= (1 + TauxAbondement);
        }
    }
}