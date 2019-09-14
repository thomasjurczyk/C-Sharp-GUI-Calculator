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

namespace Assignment_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string currentFieldContents="";
        string previousOperand="";
        int operationToPerform = 0;
        bool isCompoundExpression = false;
        /*
            1=add
            2=subtract
            3=multiply
            4=divide
        */
        public MainWindow()
        {
            InitializeComponent();
        }

        private void divide_Click(object sender, RoutedEventArgs e)
        {
            operationToPerform = 4;
            if (!isCompoundExpression)
            {
                previousOperand = currentFieldContents;
            }
            isCompoundExpression = false;
            currentFieldContents = "";
            MainBox.Text = "";
        }

        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            operationToPerform = 3;
            if (!isCompoundExpression)
            {
                previousOperand = currentFieldContents;
            }
            isCompoundExpression = false;
            currentFieldContents = "";
            MainBox.Text = "";
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            currentFieldContents += "7";
            MainBox.Text = currentFieldContents;
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            currentFieldContents += "8";
            MainBox.Text = currentFieldContents;
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            currentFieldContents += "9";
            MainBox.Text = currentFieldContents;
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            operationToPerform = 2;
            if (!isCompoundExpression)
            {
                previousOperand = currentFieldContents;
            }
            isCompoundExpression = false;
            currentFieldContents = "";
            MainBox.Text = "";
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            currentFieldContents += "4";
            MainBox.Text = currentFieldContents;
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            currentFieldContents += "5";
            MainBox.Text = currentFieldContents;
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            currentFieldContents += "6";
            MainBox.Text = currentFieldContents;
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            operationToPerform = 1;
            if (!isCompoundExpression)
            {
                previousOperand = currentFieldContents;
            }
            isCompoundExpression = false;
            currentFieldContents = "";
            MainBox.Text = "";
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            currentFieldContents += "1";
            MainBox.Text = currentFieldContents;
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            currentFieldContents += "2";
            MainBox.Text = currentFieldContents;
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            currentFieldContents += "3";
            MainBox.Text = currentFieldContents;
        }

        private void equals_Click(object sender, RoutedEventArgs e)
        {
            double tempPreviousOperand;
            double tempCurrentFieldContents;
            string solution="";
            Double.TryParse(previousOperand, out tempPreviousOperand);
            Double.TryParse(currentFieldContents, out tempCurrentFieldContents);
            if(operationToPerform!=0)
            {
                if(tempCurrentFieldContents==0)
                {
                    MessageBox.Show("ERROR: Divide by zero!");
                }
                else
                {
                    if(operationToPerform==1)
                    {
                        solution=(tempPreviousOperand + tempCurrentFieldContents).ToString();
                        MainBox.Text = solution;
                    }
                    else if(operationToPerform==2)
                    {
                        solution = (tempPreviousOperand - tempCurrentFieldContents).ToString();
                        MainBox.Text = solution;
                    }
                    else if (operationToPerform == 3)
                    {
                        solution = (tempPreviousOperand * tempCurrentFieldContents).ToString();
                        MainBox.Text = solution;
                    }
                    else if (operationToPerform == 4)
                    {
                        solution = (tempPreviousOperand / tempCurrentFieldContents).ToString();
                        MainBox.Text = solution;
                    }
                    previousOperand = solution;
                    currentFieldContents = "";
                    operationToPerform = 0;
                    isCompoundExpression = true;
                }
            }
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            currentFieldContents += "0";
            MainBox.Text = currentFieldContents;
        }

        private void decimalPoint_Click(object sender, RoutedEventArgs e)
        {
            if (!currentFieldContents.Contains("."))
            {
                currentFieldContents += ".";
                MainBox.Text = currentFieldContents;
            }
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            currentFieldContents = "";
            previousOperand = "";
            isCompoundExpression = false;
            operationToPerform = 0;
            MainBox.Text = currentFieldContents;
        }

        private void negative_Click(object sender, RoutedEventArgs e)
        {
            if (currentFieldContents != "")
            {
                if (currentFieldContents[0] == '-')
                {
                    currentFieldContents.Remove(0, 1);
                }
                else
                {
                    currentFieldContents = '-' + currentFieldContents;
                }
                MainBox.Text = currentFieldContents;
            }
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete)
            {
                clear_Click(new object(), new RoutedEventArgs());
            }
            else if (e.Key==Key.Divide || e.Key==Key.Oem2)
            {
                divide_Click(new object(), new RoutedEventArgs());
            }
            else if (e.Key==Key.Multiply)
            {
                multiply_Click(new object(), new RoutedEventArgs());
            }
            else if (e.Key == Key.OemPlus)
            {
                plus_Click(new object(), new RoutedEventArgs());
            }
            else if (e.Key == Key.OemMinus)
            {
                minus_Click(new object(), new RoutedEventArgs());
            }
            else if (e.Key == Key.OemPeriod)
            {
                decimalPoint_Click(new object(), new RoutedEventArgs());
            }
            else if (e.Key == Key.D9 || e.Key == Key.NumPad9)
            {
                nine_Click(new object(), new RoutedEventArgs());
            }
            else if (e.Key == Key.D8 || e.Key == Key.NumPad8)
            {
                eight_Click(new object(), new RoutedEventArgs());
            }
            else if (e.Key==Key.D7 || e.Key==Key.NumPad7)
            {
                seven_Click(new object(), new RoutedEventArgs());
            }
            else if (e.Key == Key.D6 || e.Key == Key.NumPad6)
            {
                six_Click(new object(), new RoutedEventArgs());
            }
            else if (e.Key == Key.D5 || e.Key == Key.NumPad5)
            {
                five_Click(new object(), new RoutedEventArgs());
            }
            else if (e.Key == Key.D4 || e.Key == Key.NumPad4)
            {
                four_Click(new object(), new RoutedEventArgs());
            }
            else if (e.Key == Key.D3 || e.Key == Key.NumPad3)
            {
                three_Click(new object(), new RoutedEventArgs());
            }
            else if (e.Key == Key.D2 || e.Key == Key.NumPad2)
            {
                two_Click(new object(), new RoutedEventArgs());
            }
            else if (e.Key == Key.D1 || e.Key == Key.NumPad1)
            {
                one_Click(new object(), new RoutedEventArgs());
            }
            else if (e.Key == Key.D0 || e.Key == Key.NumPad0)
            {
                zero_Click(new object(), new RoutedEventArgs());
            }
            else if (e.Key == Key.Enter)
            {
                equals_Click(new object(), new RoutedEventArgs());
            }
        }
    }
}
