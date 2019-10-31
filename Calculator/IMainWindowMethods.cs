using TextBox = System.Windows.Controls.TextBox;

namespace Calculator
{
    public interface IMainWindowMethods
    {
        void Click(TextBox textBox, char character);
    }
}
