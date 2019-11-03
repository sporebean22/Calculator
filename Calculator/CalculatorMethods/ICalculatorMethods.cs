using System;

namespace Calculator
{
    public interface ICalculatorMethods
    {
        double InitialParameter { get; set; }
         char Operator { get; set; }
         double SecondaryParameter { get; set; }
         double Operation();
    }
}