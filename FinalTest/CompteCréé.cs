namespace FinalTest.Tests
{
    public class CompteCréé : IEvenementMetier
    {
        private string numeroDeCompte;
        private int autorisationDeCrédit;
        public CompteCréé(string numéroDeCompte, int autorisationDeCrédit)
        {
            this.numeroDeCompte = numeroDeCompte;
            this.autorisationDeCrédit = autorisationDeCrédit;
            
        }

        // override object.Equals
        public override bool Equals(object obj)
        {

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            CompteCréé compteCreeObj = obj as CompteCréé;

            if (compteCreeObj.numeroDeCompte != this.numeroDeCompte) return false;
            if (compteCreeObj.autorisationDeCrédit != this.autorisationDeCrédit) return false;

            return true;
            
        }

    }
}