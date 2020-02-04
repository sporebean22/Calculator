using TextBox = System.Windows.Controls.TextBox;

namespace Calculator
{
    public interface IMainWindowMethods
    {
        void Click(TextBox textBox, char character);
        void NumberClick(TextBox textBox, int character);
        void EqualsClick(TextBox textBox, ICalculatorMethods calculatorMethods);
        void SymbolClick(TextBox textBox, char symbol);
    }
}
