namespace FinalTest.Tests
{
    public class CompteCréé : IEvenementMetier
    {
        private string _numeroDeCompte;
        private int _autorisationDeCrédit;
        public CompteCréé(string numéroDeCompte, int autorisationDeCrédit)
        {
            _numeroDeCompte = numéroDeCompte;
            _autorisationDeCrédit = autorisationDeCrédit;
            
        }

        public string NumeroDeCompte
        {
            get { return _numeroDeCompte; }
        }

        public int AutorisationDeCrédit
        {
            get { return _autorisationDeCrédit; }
        }

        public override string ToString()
        {
            return string.Format("NumeroDeCompte: {0}, AutorisationDeCrédit: {1}", _numeroDeCompte, _autorisationDeCrédit);
        }

        // override object.Equals
        public override bool Equals(object obj)
        {

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            CompteCréé compteCreeObj = obj as CompteCréé;

            if (compteCreeObj._numeroDeCompte != this._numeroDeCompte) return false;
            if (compteCreeObj._autorisationDeCrédit != this._autorisationDeCrédit) return false;

            return true;
            
        }

    }
}