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
    /// Логика взаимодействия для Page5.xaml
    /// </summary>
    public partial class Page5 : Window
    {
        public Page5()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int i = Convert.ToInt32(num.Text);
            if (i <= 5)
            {
                ans.Content = Convert.ToString(10);
                ans.Content += "%";
            }
            else if (i < 10)
            {
                ans.Content = Convert.ToString(15);
                ans.Content += "%";
            }
            else if (i < 15)
            {
                ans.Content = Convert.ToString(25);
                ans.Content += "%";
            }
            else if (i < 20)
            {
                ans.Content = Convert.ToString(35);
                ans.Content += "%";
            }
            else if (i < 25)
            {
                ans.Content = Convert.ToString(45);
                ans.Content += "%";
            }
            else if (i >= 25)
            {
                ans.Content = Convert.ToString(50);
                ans.Content += "%";
            }
        }
    }
}
