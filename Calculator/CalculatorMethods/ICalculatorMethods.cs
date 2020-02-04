using System;
using System.Windows.Controls;

namespace Calculator
{
    public interface ICalculatorMethods
    {
        double InitialParameter { get; set; }
        char Operator { get; set; }
        double SecondaryParameter { get; set; }
        double Operation(TextBox textBox);
        char[] OperatorValidset { get; }
    }
}