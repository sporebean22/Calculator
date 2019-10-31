using TextBox = System.Windows.Controls.TextBox;

namespace Calculator
{
    class MainWindowMethods : MainWindow, IMainWindowMethods
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

        public double EqualsClick()
        {
            return 23;
        }


  }
}
