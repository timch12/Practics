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

namespace Task_4
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Window
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int sum = 0;
            string cont ="";
            int i = Convert.ToInt32(num1.Text);
            int n = Convert.ToInt32(num2.Text);
            for (; i != n+1; i++)
            {
                sum += i;
                if (i % 2 != 0)
                {
                    cont += Convert.ToString(i);
                    cont += " ";
                }
            }
            Ans1.Content = sum;
            Ans2.Content = cont;
        }
    }
}
