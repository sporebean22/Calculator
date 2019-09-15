using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class CalculatorMethods
    {
        #region Propeties
        public double? InitialParameter { get; set; }
        public char? Operator { get; set; }
        public double? SecondaryParameter { get; set; }

        public double? operation;

        #endregion Propeties
        #region Constructors
        public CalculatorMethods (double? initialParameter, char? moperator, double? secondaryParameter)
        {
            InitialParameter = initialParameter;
            Operator = moperator;
            SecondaryParameter = secondaryParameter;
            if ((initialParameter == null) || (moperator == null) || (secondaryParameter == null))
                throw new System.ArgumentException($"The Parameters cannot be null");
        }
        #endregion Constructors
        #region Methods
        public double? Operation()
        {
            if (Operator == '+')
                return operation = InitialParameter + SecondaryParameter;
            else if (Operator == '-')
                return operation = InitialParameter - SecondaryParameter;
            else if (Operator == '*')
                return operation = InitialParameter * SecondaryParameter;
            else if (Operator == '/')
                return operation = InitialParameter / SecondaryParameter;
                return operation;
        }
        #endregion Methods
    }
}
