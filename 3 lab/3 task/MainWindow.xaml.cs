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

namespace _3_task
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Page1_Click(object sender, RoutedEventArgs e)
        {
            Page1 mainWindow = new Page1();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }

        private void Page2_Click(object sender, RoutedEventArgs e)
        {
            Page2 mainWindow = new Page2();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }

        private void Page3_Click(object sender, RoutedEventArgs e)
        {

            Page3 mainWindow = new Page3();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }    

        private void Page4_Click(object sender, RoutedEventArgs e)
        {
            Page4 mainWindow = new Page4();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }
    }
}
