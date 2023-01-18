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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для task5.xaml
    /// </summary>
    public partial class task5 : Window
    {
        public task5()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }

        private void Main_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(num.Text);
            ans.Content = Convert.ToInt32(Factorial(a));
        }
        private static int Factorial(int a)
        {

            if (a == 0)
                return 1;
            return a * Factorial(a - 1);
        }
    }
}
