using System;
using System.Collections.Generic;
using System.Linq;

namespace FinalTest.Tests
{
    public class Nombres
    {
        private IEnumerable<KeyValuePair<string, int>> value; 
        public Nombres(IEnumerable<KeyValuePair<string, int>> keyValuePairs)
        {
            this.value = keyValuePairs;
        }

        public IEnumerable<int> NombresPairs { get {  return value.Where(x => (x.Value%2) == 0).Select(x => x.Value); } }
        public String TexteNombresImpairs { get { return value.OrderBy(x => x.Value).Where(x => (x.Value % 2) != 0).Select(x => x.Key).Aggregate(String.Empty, (s, s1) => s + ", " + s1).Substring(2); } }
    }
}