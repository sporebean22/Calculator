using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class CalculatorMethods : ICalculatorMethods
    {
        #region Propeties
        public double? InitialParameter { get; set; }
        public char? Operator { get; set; }
        public double? SecondaryParameter { get; set; }
        public static ArgumentException argumentException { get; } = new System.ArgumentException($"The Parameters cannot be null");

        public double? operation;

        #endregion Propeties
        #region Constructors
        /// <summary>
        /// Creating the Methods for Calculators
        /// </summary>
        /// <param name="initialParameter"></param>
        /// <param name="moperator"></param>
        /// <param name="secondaryParameter"></param>
        public CalculatorMethods (double? initialParameter, char? moperator, double? secondaryParameter)
        {
            InitialParameter = initialParameter;
            Operator = moperator;
            SecondaryParameter = secondaryParameter;
            if ((initialParameter == null) || (moperator == null) || (secondaryParameter == null))
                throw argumentException;
        }

        public CalculatorMethods() { }

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
