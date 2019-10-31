﻿using System.Windows;
using System.Windows.Controls;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double? Result { get; set; }

        public string TextBoxContent { get; set; }

        private static readonly ICalculatorMethods _calculatorMethods = new CalculatorMethods();

        private static readonly IMainWindowMethods _mainWindow = new MainWindowMethods();

        public MainWindow() => InitializeComponent();

        private void Result_Text_Box(object sender, RoutedEventArgs e)
            =>  ResultTextBox.AppendText(Result.ToString());

        private void Click_One(object sender, RoutedEventArgs e)
            => _mainWindow.Click(TextBox,'1');

        private void Click_Two(object sender, RoutedEventArgs e)
            => _mainWindow.Click(TextBox, '2');

        private void Click_Three(object sender, RoutedEventArgs e)
            => _mainWindow.Click(TextBox, '3');

        private void Click_Four(object sender, RoutedEventArgs e)
            => _mainWindow.Click(TextBox, '4');

        private void Click_Five(object sender, RoutedEventArgs e)
            => _mainWindow.Click(TextBox, '5');

        private void Click_Six(object sender, RoutedEventArgs e)
            => _mainWindow.Click(TextBox, '6');

        private void Click_Seven(object sender, RoutedEventArgs e)
            => _mainWindow.Click(TextBox, '7');

        private void Click_Eight(object sender, RoutedEventArgs e)
            => _mainWindow.Click(TextBox, '8');

        private void Click_Nine(object sender, RoutedEventArgs e)
            => _mainWindow.Click(TextBox, '9');

        private void Click_Zero(object sender, RoutedEventArgs e)
            => _mainWindow.Click(TextBox, '0');

        private void Click_Dot(object sender, RoutedEventArgs e)
            => _mainWindow.Click(TextBox, '.');

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            var calculation = new CalculatorMethods(_calculatorMethods.InitialParameter, _calculatorMethods.Operator, _calculatorMethods.SecondaryParameter);
            Result = calculation.Operation();
            TextBox.MaxLength = 10;
            TextBox.Text += "=" + _calculatorMethods.InitialParameter;

            TextBox.AppendText(Result.ToString());
        }
        private void RemoveCurrent_Click(object sender, RoutedEventArgs e)
            => TextBox.Text.Remove(1, 1);
        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBoxContent;
            _calculatorMethods.Operator = '/';
            var StrOperator = _calculatorMethods.Operator.ToString();
            if (StrOperator.Contains(TextBoxContent))
                TextBox.AppendText(TextBoxContent.Replace("×-+", " ÷ "));
        }
        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            _calculatorMethods.Operator = '*';
            TextBox.AppendText("×");
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            _calculatorMethods.Operator = '-';
            TextBox.Text += '-';
        }
        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            _calculatorMethods.Operator = '+';
            TextBox.AppendText("+");
        }

        private void ClearAll_Click(object sender, RoutedEventArgs e)
        {
            _calculatorMethods.InitialParameter = null;
            _calculatorMethods.Operator = null;
            _calculatorMethods.SecondaryParameter = null;
            TextBox.Text = null;
        }

        private void ClearCurrent_Click(object sender, RoutedEventArgs e)
            =>  TextBox.Text = null;
    }
}