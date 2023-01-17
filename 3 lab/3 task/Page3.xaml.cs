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
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Window
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }
        private void res_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(l.Text);
                if (a >= 0 & a <= 14)
                    MessageBox.Show("Вы попали в промежуток: [0 - 14]");
                else if (a >= 15 & a <= 35)
                    MessageBox.Show("Вы попали в промежуток: [15 - 35]");
                else if (a >= 36 & a <= 50)
                    MessageBox.Show("Вы попали в промежуток: [36 - 55]");
                else if (a >= 51 & a <= 100)
                    MessageBox.Show("Вы попали в промежуток: [51 - 100]");
                else
                    MessageBox.Show("Вы не попали в промежутки");
            }
            catch
            {
                MessageBox.Show("Неверный формат данных");
            }
        }
    }
}
