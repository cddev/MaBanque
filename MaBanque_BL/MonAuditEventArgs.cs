using System;

namespace MaBanque_BL
{
    public delegate void MonAuditEventHandler(object sender, MonAuditEventArgs e);

    public class MonAuditEventArgs : EventArgs
    {
        public MonAuditEventArgs(int numCpte, string description)
        {
            NumCpte = numCpte;
            Description = description;
        }

        public int NumCpte { get; protected set; }

        public string Description { get; protected set; }
    }
}