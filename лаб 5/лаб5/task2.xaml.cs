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
    /// Логика взаимодействия для task2.xaml
    /// </summary>
    public partial class task2 : Window
    {
        public task2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }

        private void convertBut_Click(object sender, RoutedEventArgs e)
        {

            if (summaBox.Text == "" || kursBox.Text == "")
            {
                MessageBox.Show("Заполните все значения", "Конвертер валюты", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            double sum = double.Parse(summaBox.Text);
            double kurs = double.Parse(kursBox.Text);

            double result = Convert(sum, kurs);
            MessageBox.Show("Сумма в валюте №2:" + result);

        }
        private double Convert(double sum, double kurs)
        {
            double result = sum * kurs;
            return result;
        }

    }
}
