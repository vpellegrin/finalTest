using System;

namespace FinalTest.Tests
{
    public class RetraitRéalisé : IEvenementMetier
    {
        private String _numeroDeCompte;
        private Montant _montantRetrait;
        private DateTime _dateRetrait;

        public RetraitRéalisé(string numéroDeCompte, Montant montantRetrait, DateTime dateRetrait)
        {
            _numeroDeCompte = numéroDeCompte;
            _montantRetrait = montantRetrait;
            _dateRetrait = dateRetrait;
        }

        
        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            RetraitRéalisé retraitRéalisé = obj as RetraitRéalisé;

            if (retraitRéalisé._numeroDeCompte != this._numeroDeCompte) return false;
            if (retraitRéalisé._montantRetrait != this._montantRetrait) return false;
            if (retraitRéalisé._dateRetrait != this._dateRetrait) return false;

            return true;
            
        }
    }
}