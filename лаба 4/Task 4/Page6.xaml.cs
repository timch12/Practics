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
    /// Логика взаимодействия для Page6.xaml
    /// </summary>
    public partial class Page6 : Window
    {
        public Page6()
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
            try
            {
                int a = Convert.ToInt32(TBA.Text);
                int b = 1;
                int c = 0;
            A1:
                if (c < a)
                {
                    goto A2;
                }
                else
                {
                    goto A3;
                }
            A2:
                c++;
                b *= c;
                goto A1;
            A3:
                TBB.Text = "" + b;
            }
            catch
            {
                TBB.Text = "введите число";
            }
        }
    }
}
