namespace FinalTest.Tests
{
    public class TypeReference
    {
        private int i;
        public TypeReference(int i)
        {
            this.i = i;
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            TypeReference typeReferenceObj = obj as TypeReference;

            if (typeReferenceObj.i != this.i) return false;

            return true;

            
        }
    }
}