using TextBox = System.Windows.Controls.TextBox;

namespace Calculator
{
    class MainWindowMethods : IMainWindowMethods
  {
    private static readonly ICalculatorMethods _calculatorMethods = new CalculatorMethods();
    public void Click(TextBox textBox, char character)
    {

      if (_calculatorMethods.Operator == null)
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
            textBox.Text += "=" + _calculatorMethods.InitialParameter;
            textBox.AppendText(result.ToString());
        }


  }
}
