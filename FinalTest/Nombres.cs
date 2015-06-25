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
    }
}