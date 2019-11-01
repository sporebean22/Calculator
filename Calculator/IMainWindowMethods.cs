using TextBox = System.Windows.Controls.TextBox;

namespace Calculator
{
    public interface IMainWindowMethods
    {
        void Click(TextBox textBox, char character);
        void EqualsClick(TextBox textBox, ICalculatorMethods calculatorMethods);
    }
}
