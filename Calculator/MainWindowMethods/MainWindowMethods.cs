using TextBox = System.Windows.Controls.TextBox;
using FluentValidation;

namespace Calculator
{
    class MainWindowMethods : IMainWindowMethods
    {
        private static readonly ICalculatorMethods _calculatorMethods = new CalculatorMethods();
        public void NumberClick(TextBox textBox, int character)
        {
            if (_calculatorMethods.Operator == ' ')
                _calculatorMethods.InitialParameter = character;
            else
                _calculatorMethods.SecondaryParameter = character;

            if (_calculatorMethods.Operator == ' ')
            {
                _calculatorMethods.InitialParameter = _calculatorMethods.InitialParameter * 10 + _calculatorMethods.InitialParameter;
                textBox.AppendText(character.ToString());
            }

            else
            {
                _calculatorMethods.SecondaryParameter = (_calculatorMethods.SecondaryParameter * 10) + _calculatorMethods.InitialParameter;
                textBox.AppendText(character.ToString());
            }
        }

        public void Click(TextBox textBox, char character)
        {
            if (_calculatorMethods.Operator == ' ')
            {
                _calculatorMethods.InitialParameter = _calculatorMethods.InitialParameter * 10 + _calculatorMethods.InitialParameter;
                textBox.AppendText(character.ToString());
            }

            else
            {
                _calculatorMethods.SecondaryParameter = (_calculatorMethods.SecondaryParameter * 10) + _calculatorMethods.InitialParameter;
                textBox.AppendText(character.ToString());
            }
        }

        public void EqualsClick(TextBox textBox, ICalculatorMethods parameters)
        {
            var result = parameters.Operation();
            textBox.MaxLength = 10;
            textBox.Text = " ";
            textBox.AppendText(result.ToString());
        }

        public void SymbolClick(TextBox textBox, char symbol)
        {
            _calculatorMethods.Operator = symbol;

            if (_calculatorMethods.Operator == ' ')
            {
                _calculatorMethods.InitialParameter = _calculatorMethods.InitialParameter * 10 + _calculatorMethods.InitialParameter;
                textBox.AppendText(symbol.ToString());
            }

            else
            {
                _calculatorMethods.SecondaryParameter = (_calculatorMethods.SecondaryParameter * 10) + _calculatorMethods.InitialParameter;
                textBox.AppendText(symbol.ToString());
            }
        }
    }
}
