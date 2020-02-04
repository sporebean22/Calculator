using TextBox = System.Windows.Controls.TextBox;

namespace Calculator
{
    class MainWindowMethods : IMainWindowMethods
    {
        private ICalculatorMethods _calculatorMethods = MainWindow._calculatorMethods;

        public void NumberClick(TextBox textBox, int character)
        {
            if (_calculatorMethods.Operator.Equals('\0'))
            {
                _calculatorMethods.InitialParameter = character;
                textBox.AppendText(character.ToString());
            }
            else
            { 
                _calculatorMethods.SecondaryParameter = character;
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
            var result = parameters.Operation(textBox);
            textBox.MaxLength = 10;
            textBox.Text = " ";
            textBox.AppendText(result.ToString());
            parameters.InitialParameter = result;
            parameters.Operator = '\0';
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
