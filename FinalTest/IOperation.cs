using System;
using System.Security.Cryptography.X509Certificates;

namespace FinalTest.Tests
{
    public interface IOperation
    {


        bool PeutCalculer(String value);
        int Calculer(string value);

    }
}