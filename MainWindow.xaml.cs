using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Calculadora_Basica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }



        private void CalcularButton(object sender, RoutedEventArgs e)
        {
            

            try
            {
                double num1 = int.Parse(OperadorTextBox1.Text);
                double num2 = int.Parse(OperadorTextBox2.Text);
                char operador = char.Parse(OperadorTextBox.Text);

                if (operador == '+')
                {
                    ResultadoTextBox.Text = (num1 + num2).ToString();
                }
                else if (operador == '-')
                {
                    ResultadoTextBox.Text = (num1 - num2).ToString();
                }
                else if (operador == '*')
                {
                    ResultadoTextBox.Text = (num1 * num2).ToString();
                }
                else if (operador == '/')
                {
                    ResultadoTextBox.Text = (num1 / num2).ToString();
                }

            }
            
            catch (Exception e1)
            {
                MessageBox.Show($"ERROR:  {e1}", "Calculadora", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            

        }

        private void LimpiarButton(object sender, RoutedEventArgs e)
        {
            ResultadoTextBox.Text = "";
            OperadorTextBox.Text = "";
            OperadorTextBox1.Text = "";
            OperadorTextBox2.Text = "";

        }

        private void OperadorTextBoxCambiado(object sender, TextChangedEventArgs e)
        {
            string input = OperadorTextBox.Text;
            if (input == "+" || input == "-" || input == "*" || input == "/")
            {
                CalcularBoton.IsEnabled = true;
            }
        }
    }
}
