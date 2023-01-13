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

namespace кальк
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
        int gg = 0;
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            switch (fff.SelectedIndex)
            {
                case 0:
                    t3.Text = "";
                    l1.Content = "";
                    try
                    {
                        double a = Convert.ToDouble(t1.Text);
                        double b = Convert.ToDouble(t2.Text);
                        t3.Text = Convert.ToString(a + b);
                    }
                    catch
                    {
                        l1.Content = ("Введено значение неверного формата, значение отсутствует или неверное количество значений!");
                        l1.Foreground = Brushes.Red;
                    }
                    break;
                case 1:
                    t3.Text = "";
                    l1.Content = "";
                    try
                    {
                        double a = Convert.ToDouble(t1.Text);
                        double b = Convert.ToDouble(t2.Text);
                        t3.Text = Convert.ToString(a - b);
                    }
                    catch
                    {
                        l1.Content = ("Введено значение неверного формата, значение отсутствует или неверное количество значений!");
                        l1.Foreground = Brushes.Red;
                    }
                    break;
                case 2:
                    t3.Text = "";
                    try
                    {
                        double a = Convert.ToDouble(t1.Text);
                        double b = Convert.ToDouble(t2.Text);
                        t3.Text = Convert.ToString(Math.Round(a * b,4));
                    }
                    catch
                    {
                        l1.Content = ("Введено значение неверного формата, значение отсутствует или неверное количество значений!");
                        l1.Foreground = Brushes.Red;
                    }
                    break;
                case 3:
                    t3.Text = "";
                    l1.Content = "";
                    try
                    {
                        double a = Convert.ToDouble(t1.Text);
                        double b = Convert.ToDouble(t2.Text);
                        if (b == 0)
                        {
                            l1.Content = "На 0 делить нельзя";
                            l1.Foreground = Brushes.Red;
                        }
                        else
                            t3.Text = Convert.ToString(Math.Round(a / b,4));
                    }
                    catch
                    {
                        l1.Content = ("Введено значение неверного формата, значение отсутствует или неверное количество значений!");
                        l1.Foreground = Brushes.Red;
                    }
                    break;
                case 4:
                    t3.Text = "";
                    l1.Content = "";
                    try
                    {
                        double a = Convert.ToDouble(t1.Text);
                        if (gg % 2 == 0)
                        {
                            l1.Content = "Невозможно работать с двумя числами";
                            l1.Foreground = Brushes.Red;
                        }
                        else
                        {
                            a = Math.Sin(a);
                            t3.Text = Convert.ToString(Math.Round(a, 4));
                        }
                    }
                    catch
                    {
                        l1.Content = ("Введено значение неверного формата, значение отсутствует или неверное количество значений!");
                        l1.Foreground = Brushes.Red;
                    }
                    break;
                case 5:
                    t3.Text = "";
                    l1.Content = "";
                    try
                    {
                        double t = Convert.ToDouble(t1.Text);
                        if (gg % 2 == 0)
                        {
                            l1.Content = "Невозможно работать с двумя числами";
                            l1.Foreground = Brushes.Red;
                        }
                        else
                        {
                            t = Math.Cos(t);
                            t3.Text = Convert.ToString(Math.Round(t, 4));
                            l1.Content = "";
                        }
                    }
                    catch
                    {
                        l1.Content = ("Введено значение неверного формата, значение отсутствует или неверное количество значений!");
                        l1.Foreground = Brushes.Red;
                    }
                    break;
                case 6:
                    t3.Text = "";
                    l1.Content = "";
                    try
                    {
                        double a = Convert.ToDouble(t1.Text);
                        if (gg % 2 == 0)
                        {
                            l1.Content = "Невозможно работать с двумя числами";
                            l1.Foreground = Brushes.Red;
                        }
                        else
                        {
                            a = Math.Tan(a);
                            t3.Text = Convert.ToString(Math.Round(a, 4));
                            l1.Content = "";
                        }
                    }
                    catch
                    {
                        l1.Content = ("Введено значение неверного формата, значение отсутствует или неверное количество значений!");
                        l1.Foreground = Brushes.Red;
                    }
                    break;
                case 7:
                    t3.Text = "";
                    l1.Content = "";
                    try
                    {
                        double a = Convert.ToDouble(t1.Text);
                        if (gg % 2 == 0)
                        {
                            l1.Content = "Невозможно работать с двумя числами";
                            l1.Foreground = Brushes.Red;
                        }
                        else
                        {
                            a = Math.Cos(a) / Math.Sin(a);
                            t3.Text = Convert.ToString(Math.Round(a, 4));
                            l1.Content = "";
                        }
                    }
                    catch
                    {
                        l1.Content = ("Введено значение неверного формата, значение отсутствует или неверное количество значений!");
                        l1.Foreground = Brushes.Red;
                    }
                    break;
            }
            
        }

        private void change_Click(object sender, RoutedEventArgs e)
        {
            if (gg % 2 == 0)
            {
                t2.Visibility = Visibility.Hidden;
                t2.Clear();
                gg += 1;
            }
               
            else
            { 
                t2.Visibility = Visibility.Visible;
                gg += 1;
            }

        }

        private void fff_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
