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
using System.Windows.Shapes;

namespace _3_task
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Window
    {
        public Page2()
        {
            InitializeComponent();
        }
        string sign = "";


        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }

        private void Slo_Click(object sender, RoutedEventArgs e)
        {
            double operand1 = Convert.ToDouble(A.Text);
            double operand2 = Convert.ToDouble(A_Copy.Text);
            string sign = Convert.ToString(C.Text);           
            if (operand2 == 0 && sign =="/")
            {
                MessageBox.Show("На ноль делить нельзя");
                return;
            }
                switch (sign)
            {
                case "+":
                    l1.Content = (operand1 + operand2);
                    break;
                case "-":
                    l1.Content = (operand1 - operand2);
                    break;
                case "*":
                    l1.Content = (operand1 * operand2);
                    break;
                case "/":
                    l1.Content = Math.Round(operand1 / operand2, 4);
                    break;
                case "^":
                    l1.Content = Math.Pow(operand1, operand2);
                    break;
                default:
                    MessageBox.Show("Неверный формат данных.");
                    break;
            }
        }
    }
}