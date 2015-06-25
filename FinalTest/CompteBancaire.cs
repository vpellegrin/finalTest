using System.Collections.Generic;

namespace FinalTest.Tests
{
    public class CompteBancaire
    {

        public static IEnumerable<IEvenementMetier> Ouvrir(string numéroDeCompte, int autorisationDeCrédit)
        {
            yield return new CompteCréé(numéroDeCompte, autorisationDeCrédit);
        }
    }
}