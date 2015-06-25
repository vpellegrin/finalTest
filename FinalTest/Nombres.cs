using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace FinalTest.Tests
{
    public class Nombres
    {
        private IEnumerable<KeyValuePair<string, int>> value;
        public Nombres(IEnumerable<KeyValuePair<string, int>> keyValuePairs)
        {
            this.value = keyValuePairs;
        }

        public IEnumerable<int> NombresPairs
        {
            get
            {
                return value.Where(x => (x.Value % 2) == 0).Select(x => x.Value);
            }
        }

        public String TexteNombresImpairs
        {
            get
            {
                return value.OrderBy(x => x.Value).Where(x => (x.Value % 2) != 0).Select(x => x.Key).Aggregate(String.Empty, (s, s1) => s + ", " + s1).Substring(2);
            }
        }
        public String PremierNombreDontLeTexteContientPlusDe5Caractères
        {
            get
            {
                return value.Select(x => x.Key).First(x => x.Length > 5);
            }
        }

        public IEnumerable<int> QuatreNombresSupérieursSuivant3
        {
            get { return value.OrderBy(x => x.Value).Where(x => x.Value > 3).Select(x => x.Value).Take(4); }
        }
    }
}