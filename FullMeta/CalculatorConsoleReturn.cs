using System;
using System.Collections.Generic;
using System.Text;

namespace FullMeta
{   
    public static class CalculatorConsoleReturn
    {
        public static double InitialParameter { get; set; }
        public static char Operator { get; set; }
        public static double SecondaryParameter { get; set; }

        public static void MathConsoleReturn(this Object Operator)
        {
            Console.WriteLine(Operator);
        }        
        public static void RequestInput()
        {
            Console.WriteLine("Please Input an Initial Parameter");
            InitialParameter = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Input an Operator +, -, *, / ");
            Operator = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Please Input a Secondary Parameter");
            SecondaryParameter = Convert.ToDouble(Console.ReadLine());
        }
    }
}
