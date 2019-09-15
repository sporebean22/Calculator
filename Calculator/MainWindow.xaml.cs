using System;
using System.Windows;
using System.Windows.Controls;
using System.Linq;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double? InitialParameter { get; set; }
        public char? Operator { get; set; }
        public double? SecondaryParameter { get; set; }
        public double? Result { get; set; }
        public string TextBoxContent { get; set; }
        public MainWindow()
            => InitializeComponent();
        private void Result_Text_Box(Object sender, RoutedEventArgs e)
        {
            ResultTextBox.AppendText(Result.ToString());
        }
        
        private void Click_One(object sender, RoutedEventArgs e)
        {
            if (Operator == ' ')
            {
                InitialParameter = (InitialParameter * 10) + 1;
                TextBox.AppendText("1");
            }
            else
            {
                SecondaryParameter = (SecondaryParameter * 10) + 1;
                TextBox.AppendText("1");
            }
        }
        private void Click_Two(object sender, RoutedEventArgs e)
        {
            if (Operator == ' ')
            {
                InitialParameter = (InitialParameter * 10) + 2;
                TextBox.AppendText("2");
            }
            else
            {
                SecondaryParameter = (SecondaryParameter * 10) + 2;
                TextBox.AppendText("2");
            }
        }
        private void Click_Three(object sender, RoutedEventArgs e)
        {
            if (Operator == ' ')
            {
                InitialParameter = (InitialParameter * 10) + 3;
                TextBox.AppendText("3");
            }
            else
            {
                SecondaryParameter = (SecondaryParameter * 10) + 3;
                TextBox.AppendText("3");
            }
        }
        private void Click_Four(object sender, RoutedEventArgs e)
        {
            if (Operator == ' ')
            {
                InitialParameter = (InitialParameter * 10) + 4;
                TextBox.AppendText("4");
            }
            else
            {
                SecondaryParameter = (SecondaryParameter * 10) + 4;
                TextBox.AppendText("4");
            }
        }
        private void Click_Five(object sender, RoutedEventArgs e)
        {
            if (Operator == ' ')
            {
                InitialParameter = (InitialParameter * 10) + 5;
                TextBox.AppendText("5");
            }
            else
            {
                SecondaryParameter = (SecondaryParameter * 10) + 5;
                TextBox.AppendText("5");
            }
        }
        private void Click_Six(object sender, RoutedEventArgs e)
        {
            if (Operator == ' ')
            {
                InitialParameter = (InitialParameter * 10) + 6;
                TextBox.AppendText("6");
            }
            else
            {
                SecondaryParameter = (SecondaryParameter * 10) + 6;
                TextBox.AppendText("6");
            }
        }
        private void Click_Seven(object sender, RoutedEventArgs e)
        {
            if (Operator == ' ')
            {
                InitialParameter = (InitialParameter * 10) + 7;
                TextBox.AppendText("7");
            }
            else
            {
                SecondaryParameter = (SecondaryParameter * 10) + 7;
                TextBox.AppendText("7");
            }
        }
        private void Click_Eight(object sender, RoutedEventArgs e)
        {
            if (Operator == ' ')
            {
                InitialParameter = (InitialParameter * 10) + 7;
                TextBox.AppendText("7");
            }
            else
            {
                SecondaryParameter = (SecondaryParameter * 10) + 7;
                TextBox.AppendText("7");
            }
        }
        private void Click_Nine(object sender, RoutedEventArgs e)
        {
            if (Operator == ' ')
            {
                InitialParameter = (InitialParameter * 10) + 9;
                TextBox.AppendText("9");
            }
            else
            {
                SecondaryParameter = (SecondaryParameter * 10) + 9;
                TextBox.AppendText("9");
            }
        }
        private void Click_Zero(object sender, RoutedEventArgs e)
        {
            if (Operator == ' ')
            {
                InitialParameter = (InitialParameter * 10);
                TextBox.AppendText("0");
            }
            else
            {
                SecondaryParameter = (SecondaryParameter * 10);
                TextBox.AppendText("0");
            }
        }
        private void Click_Dot(object sender, RoutedEventArgs e)
        {
            if (Operator == ' ')
            {
                InitialParameter = (InitialParameter * 10) + 1;
                TextBox.AppendText("1");
            }
            else
            {
                SecondaryParameter = (SecondaryParameter * 10) + 1;
                TextBox.AppendText("1");
            }
        }
        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            var calculation = new CalculatorMethods(InitialParameter, Operator, SecondaryParameter);
            Result = calculation.Operation();
            TextBox.MaxLength = 10;
            TextBox.Text += "=" + InitialParameter;

            TextBox.AppendText(Result.ToString());
        }
        private void RemoveCurrent_Click(object sender, RoutedEventArgs e)
            => TextBox.Text.Remove(1, 1);
        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBoxContent;
            Operator = '/';
            var StrOperator = Operator.ToString();
            if (StrOperator.Contains(TextBoxContent))
                TextBox.AppendText(TextBoxContent.Replace("×-+", " ÷ "));
        }
        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            Operator = '*';
            TextBox.AppendText("×");
        }
        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            Operator = '-';
            TextBox.Text += '-';
        }
        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            Operator = '+';
            TextBox.AppendText("+");
        }

        private void ClearAll_Click(object sender, RoutedEventArgs e)
        {
            InitialParameter = null;
            Operator = null;
            SecondaryParameter = null;
            TextBox.Text = null;
        }

        private void ClearCurrent_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = null;
        }
    }
}
