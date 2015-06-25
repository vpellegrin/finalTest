using System;
using System.Collections.Generic;

namespace FinalTest.Tests
{
    public class D�potR�alis� : IEvenementMetier
    {
        private string numeroDeCompte;
        private Montant montantDepot;
        private DateTime dateDepot;
        public D�potR�alis�(string num�roDeCompte, Montant montantDepot, DateTime dateDepot)
        {
            this.numeroDeCompte = num�roDeCompte;
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

            D�potR�alis� d�potR�alis� = obj as D�potR�alis�;

            if (d�potR�alis�.numeroDeCompte != this.numeroDeCompte) return false;
            if (d�potR�alis�.montantDepot != this.montantDepot) return false;
            if (d�potR�alis�.dateDepot != this.dateDepot) return false;

            return true;
            
        }
        

    }
}