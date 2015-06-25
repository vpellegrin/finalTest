using System;

namespace FinalTest.Tests
{
    public class Calculatrice
    {
        private IOperation[] _operations;
        public Calculatrice(IOperation[] operations)
        {
            _operations = operations;
        }

        public int Calculer(String value)
        {
            foreach (IOperation operation in _operations)
            {
                if (operation.PeutCalculer(value))
                {
                    return operation.Calculer(value);
                }
                

            }

            return 0;
        }
    }
}