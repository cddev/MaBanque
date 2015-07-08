using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace GestComLib
{
    public class Annuaire<P>:IDictionary<String,P> where P:Partenaire
    {
        public List<P> Lpart { get; set; }

        public ICollection<string> Keys
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ICollection<P> Values
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int Count
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsReadOnly
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        P IDictionary<string, P>.this[string key]
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public Annuaire()
        {

        }
        

        public P this[string index]
        {
            get { return Lpart.Find(cpt => cpt.Trigram == index); }
        }
        public P GetbyName(P a)
        {
            return Lpart.Find(p => p.Nom == a.Nom);
        }
        public P GetbyPrenom(P a)
        {
            return Lpart.Find(p => p.Prenom == a.Prenom);
        }
        public IEnumerator<P> GetEnumerator()
        {
            return Lpart.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool ContainsKey(string key)
        {
            throw new NotImplementedException();
        }

        public void Add(string key, P value)
        {
            throw new NotImplementedException();
        }

        public bool Remove(string key)
        {
            throw new NotImplementedException();
        }

        public bool TryGetValue(string key, out P value)
        {
            throw new NotImplementedException();
        }

        public void Add(KeyValuePair<string, P> item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(KeyValuePair<string, P> item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(KeyValuePair<string, P>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(KeyValuePair<string, P> item)
        {
            throw new NotImplementedException();
        }

        IEnumerator<KeyValuePair<string, P>> IEnumerable<KeyValuePair<string, P>>.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
