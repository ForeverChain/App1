using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the input values from text boxes
            double firstNumber = double.Parse(FirstNumberTextBox.Text);
            double secondNumber = double.Parse(SecondNumberTextBox.Text);

            // Perform the addition
            double result = firstNumber + secondNumber;

            // Update the ResultTextBox with the calculated result
            ResultTextBox.Text = "Result: " + result;
        }

        private void SubButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the input values from text boxes
            double firstNumber = double.Parse(FirstNumberTextBox.Text);
            double secondNumber = double.Parse(SecondNumberTextBox.Text);

            // Perform subtraction
            double result = firstNumber - secondNumber;

            // Update the ResultTextBox with the calculated result
            ResultTextBox.Text = "Result: " + result;
        }

        private void MulButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the input values from text boxes
            double firstNumber = double.Parse(FirstNumberTextBox.Text);
            double secondNumber = double.Parse(SecondNumberTextBox.Text);

            // Perform multiplication
            double result = firstNumber * secondNumber;

            // Update the ResultTextBox with the calculated result
            ResultTextBox.Text = "Result: " + result;
        }

        private void DivButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the input values from text boxes
            double firstNumber = double.Parse(FirstNumberTextBox.Text);
            double secondNumber = double.Parse(SecondNumberTextBox.Text);

            // Check for division by zero and handle it as needed
            if (secondNumber != 0)
            {
                // Perform division
                double result = firstNumber / secondNumber;

                // Update the ResultTextBox with the calculated result
                ResultTextBox.Text = "Result: " + result;
            }
            else
            {
                // Handle the case of division by zero (optional)
                ResultTextBox.Text = "Result: Cannot divide by zero";
            }
        }
    }
}
