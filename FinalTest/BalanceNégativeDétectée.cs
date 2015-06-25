using System;

namespace FinalTest.Tests
{
    public class BalanceNégativeDétectée : IEvenementMetier
    {
        private String _numéroDeCompte;
        private Montant _montant;
        private DateTime _dateRetrait;

        public BalanceNégativeDétectée(string numéroDeCompte, Montant montant, DateTime dateRetrait)
        {
            this._numéroDeCompte = numéroDeCompte;
            this._montant = montant;
            this._dateRetrait = dateRetrait;
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            BalanceNégativeDétectée balanceNégativeDétectée = obj as BalanceNégativeDétectée;

            if (balanceNégativeDétectée._numéroDeCompte != this._numéroDeCompte) return false;
            if (balanceNégativeDétectée._montant != this._montant) return false;
            if (balanceNégativeDétectée._dateRetrait != this._dateRetrait) return false;

            return true;

        }
    }
}