using System;
using System.Collections.Generic;

namespace FinalTest.Tests
{
    public class CompteBancaire
    {
        private readonly string numCompte;
        private CompteCréé unCompteCréé;
        private int balance = 0;
        public CompteBancaire(CompteCréé compteCréé)
        {
            this.numCompte = compteCréé.NumeroDeCompte;
        }

        public CompteBancaire(CompteCréé compteCréé, DépotRéalisé dépotRéalisé)
        {
            balance += dépotRéalisé.MontantDepot.Value;
        }

        public static IEnumerable<IEvenementMetier> Ouvrir(string numéroDeCompte, int autorisationDeCrédit)
        {
            yield return new CompteCréé(numéroDeCompte, autorisationDeCrédit);
        }

        public IEnumerable<IEvenementMetier> FaireUnDepot(Montant montantDepot, DateTime dateDepot)
        {
            yield return new DépotRéalisé(numCompte, montantDepot, dateDepot);
        }

        public IEnumerable<IEvenementMetier> FaireUnRetrait(Montant montantRetrait, DateTime dateRetrait)
        {
            yield return new RetraitRéalisé(numCompte, montantRetrait, dateRetrait);

            if (this.unCompteCréé.AutorisationDeCrédit < (this.balance - montantRetrait.Value))
            {
                yield return new BalanceNégativeDétectée(numCompte, montantRetrait, dateRetrait);
                throw new RetraitNonAutorisé();

            }
        }
    }
}