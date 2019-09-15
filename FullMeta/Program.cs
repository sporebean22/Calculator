using System;

namespace FullMeta
{
    class Program
    {
        public static void Main()
        {
            CalculatorConsoleReturn.RequestInput();
            var math = new CalculatorMethods(CalculatorConsoleReturn.InitialParameter, CalculatorConsoleReturn.Operator, CalculatorConsoleReturn.SecondaryParameter);
            math.Operation();
            CalculatorConsoleReturn.MathConsoleReturn(math.operation);
        }
    }
}
