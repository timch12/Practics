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

        private void Button_click(object sender, RoutedEventArgs e)
        {
            l.Content = "";
            try
            {
                string a = Convert.ToString(tran.Text);
                if (a == "дождь")
                    res.Text = "rain";
                else if (a == "ветер")
                    res.Text = "wind";
                else if (a == "снег")
                    res.Text = "snow";
                else if (a == "тепло")
                    res.Text = "warm";
                else if (a == "ходод")
                    res.Text = "cold";
                else if (a == "радуга")
                    res.Text = "rainbow";
                else if (a == "ураган")
                    res.Text = "hurricane";
                else if (a == "солнечно")
                    res.Text = "sunny";
                else if (a == "пасмурно")
                    res.Text = "cloudy";
                else if (a == "прогноз")
                    res.Text = "forecast";
                else
                {
                    l.Content = "Невозможно перевести слово";
                    l.Foreground = Brushes.Red;
                    res.Text = "";
                }

            }
            catch
            { }
        }
    }
}
