using System;

namespace FinalTest.Tests
{
    public class Montant
    {
        private int value;
        public Montant(int i)
        {
            this.value = i;
        }

        public int Value
        {
            get { return value; }
        }
    }
}