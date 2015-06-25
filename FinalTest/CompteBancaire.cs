using System;
using System.Collections.Generic;

namespace FinalTest.Tests
{
    public class CompteBancaire
    {
        private readonly string numCompte;
        public CompteBancaire(CompteCréé compteCréé)
        {
            this.numCompte = compteCréé.NumeroDeCompte;
        }

        public static IEnumerable<IEvenementMetier> Ouvrir(string numéroDeCompte, int autorisationDeCrédit)
        {
            yield return new CompteCréé(numéroDeCompte, autorisationDeCrédit);
        }

        public IEnumerable<IEvenementMetier> FaireUnDepot(Montant montantDepot, DateTime dateDepot)
        {
            yield return new DépotRéalisé(numCompte, montantDepot, dateDepot);
        }
    }
}