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
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Window
    {
        public Page4()
        {
            InitializeComponent();
        }

        string password = "password";

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }

        private void pas_Click(object sender, RoutedEventArgs e)
        {
            string a = Convert.ToString(p.Text);
            if (a == password)
            {
                l1.Text = "Секретное сообщение: Ты отгадал пароль!";
            }
            else
                l1.Text = "Неправильный пароль!";

        }
    }
}
