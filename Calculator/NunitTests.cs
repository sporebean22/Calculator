using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Calculator
{
    [TestFixture]
    public class NunitTests
    {
        [TestCase(1,'-',4, ExpectedResult = -3)]
        [TestCase(2, '+', 5, ExpectedResult = 7)]
        [TestCase(3, '*', 4, ExpectedResult = 12)]
        [TestCase(5, '/', 100, ExpectedResult = 0.05)]
        [TestCase(2, '/', 10, ExpectedResult = 0.2)]
        public double? Tests(double? InitialParameter, char? Operator, double? SecondaryParameter)
        {
            var MethodTest = new CalculatorMethods(InitialParameter, Operator, SecondaryParameter);
            MethodTest.Operation();
            return MethodTest.operation;
        }
    }
}
