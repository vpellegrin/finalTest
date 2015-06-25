namespace FinalTest.Tests
{
    public class Multiplication
    {
        public Multiplication()
        {
        }

        public bool PeutCalculer(string value)
        {
            if (value.Substring(1, 1) != "*")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int Calculer(string value)
        {
            int value1 = int.Parse(value.Substring(0, 1));
            int value2 = int.Parse(value.Substring(2, 1));
            int result = value1*value2;
            return result;

        }
    }
}