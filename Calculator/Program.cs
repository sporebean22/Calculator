using System;

namespace Calculator
{
    class CalculatorLogicEntryPoint
    {
        public static void CalculatorLogic()
        {
            CalculatorConsoleReturn.RequestInput();
            var math = new CalculatorMethods(CalculatorConsoleReturn.InitialParameter, CalculatorConsoleReturn.Operator, CalculatorConsoleReturn.SecondaryParameter);
            math.Operation();
            CalculatorConsoleReturn.MathConsoleReturn(math.operation);
        }
    }
}
