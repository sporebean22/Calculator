using System.Text;

namespace Calculator
{
    public class Expression
    {
        private StringBuilder ExpressionInstance { get; set; }

        public Expression() 
        {
            var expression = new StringBuilder();
        }

        public Expression(string expression)
        {
            var Stringexpression = new StringBuilder(expression);
            ExpressionInstance = Stringexpression;
        }

        public void Add(string addition)
        {
            ExpressionInstance.Append(addition);
        }
    }
}
