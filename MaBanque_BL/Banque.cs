using System.Collections.Generic;
using System.IO;

namespace MaBanque_BL
{
    internal class Banque
    {
        public Banque()
        {
            isAudit = false;
        }

        public List<Compte> Comptes { get; private set; }

        public string Nom { get; set; }

        public void AddCompte(Compte compte)
        {
            Comptes.Add(compte);
        }

        private bool isAudit;

        public void ChangerAudit()
        {
            if (!isAudit)
            {
                isAudit = true;
                foreach (Compte cpte in Comptes)
                {
                    cpte.MonAudit += Cpte_MonAudit;
                }
            }
            else
            {
                isAudit = false;
                foreach (Compte cpte in Comptes)
                {
                    cpte.MonAudit -= Cpte_MonAudit;
                }
            }
        }

        private void Cpte_MonAudit(object sender, MonAuditEventArgs e)
        {
            if (File.Exists(@"c:\temp\Audit.bak"))
            {
                StreamWriter writer = File.AppendText(@"c:\temp\Audit.bak");
                writer.WriteLine("Num Cpte :" + e.NumCpte + ", " + e.Description);
                writer.Close();
            }
        }
    }
}