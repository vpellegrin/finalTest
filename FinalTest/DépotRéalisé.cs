using System;
using System.Collections.Generic;

namespace FinalTest.Tests
{
    public class DépotRéalisé : IEvenementMetier
    {
        private string numeroDeCompte;
        private Montant montantDepot;
        private DateTime dateDepot;
        public DépotRéalisé(string numéroDeCompte, Montant montantDepot, DateTime dateDepot)
        {
            this.numeroDeCompte = numéroDeCompte;
            this.montantDepot = montantDepot;
            this.dateDepot = dateDepot;
        }

        public Montant MontantDepot
        {
            get { return montantDepot; }
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            DépotRéalisé dépotRéalisé = obj as DépotRéalisé;

            if (dépotRéalisé.numeroDeCompte != this.numeroDeCompte) return false;
            if (dépotRéalisé.montantDepot != this.montantDepot) return false;
            if (dépotRéalisé.dateDepot != this.dateDepot) return false;

            return true;
            
        }
        

    }
}