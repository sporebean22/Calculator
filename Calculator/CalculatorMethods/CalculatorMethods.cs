﻿using System;
using System.Data;
using System.Windows.Controls;

namespace Calculator
{
public class CalculatorMethods : ICalculatorMethods
{
    #region Propeties
    public char[] OperatorValidset { get; } = { '+', '-', '×', '÷', '^','√','ˣ', ' '};
    public double InitialParameter { get; set; }
    public char Operator { get; set; }
    public double SecondaryParameter { get; set; }
    public static ArgumentException CalculatorNullArgumentException { get; } = new System.ArgumentException($"The Parameters cannot be null");
    
    public double? operation;

    #endregion Propeties
    #region Constructors
    /// <summary>
    /// Creating the Methods for Calculators
    /// </summary>
    /// <param name="initialParameter"></param>
    /// <param name="moperator"></param>
    /// <param name="secondaryParameter"></param>
    public CalculatorMethods (double initialParameter, char moperator, double secondaryParameter)
    {
        InitialParameter = initialParameter;
        Operator = moperator;
        SecondaryParameter = secondaryParameter;
        if ((initialParameter == double.NaN) || (moperator == ' ') || (secondaryParameter == double.NaN))
            throw CalculatorNullArgumentException;
    }

    public CalculatorMethods() { }

    #endregion Constructors
    #region Methods

    private double Sum(double initialParameter, double secondaryParameter)
        =>  initialParameter + secondaryParameter;
    private double Subtract(double initialParameter, double secondaryParameter)
        => initialParameter - secondaryParameter;
    private double Multiply(double initialParameter, double secondaryParameter)
        => initialParameter * secondaryParameter;
    private double Divide(double initialParameter, double secondaryParameter)
        => initialParameter / secondaryParameter;
    private double Square(double parameter, double power)
        =>  Math.Pow(parameter, power);

        public double eval(string expression)
        {
            var table = new DataTable();
            return Convert.ToDouble(table.Compute(expression, String.Empty));
        }

        public double Operation(TextBox textBox)
        {
            return eval(textBox.Text);

            /*if (Operator == OperatorValidset[0])
                return Sum(InitialParameter, SecondaryParameter);
            else if (Operator.Equals(OperatorValidset[1]))
                return Subtract(InitialParameter, SecondaryParameter);
            else if (Operator.Equals(OperatorValidset[2]))
                return Multiply(InitialParameter, SecondaryParameter);
            else if (Operator.Equals(OperatorValidset[3]))
                return Divide(InitialParameter, SecondaryParameter);
            else if (Operator.Equals(OperatorValidset[4]))
                return Square(InitialParameter, SecondaryParameter);
            else if (Operator.Equals(OperatorValidset[5]))
                return Square(Divide(1, InitialParameter), SecondaryParameter);
            else if (Operator.Equals(OperatorValidset[6]))
                return Multiply(SecondaryParameter, 10);
            else 
                throw CalculatorNullArgumentException;*/
        }
    }

    #endregion Methods
}
