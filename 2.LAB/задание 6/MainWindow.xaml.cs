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

namespace задание_6
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

        private void Button_Click(object sender, RoutedEventArgs e)

        {
            try
            {
                string a = Convert.ToString(name.Text);
                string b = Convert.ToString(zadiac.Text);
                int c = Convert.ToInt32(age.Text);
                if (c < 0)
                {
                    MessageBox.Show("Возраст не может быть отрицательным");
                }
                else
                    an.Content = "Вас зовут "  +  a  + " вам " + c + " знак задиака -" + b;
                }
            catch
            {
                MessageBox.Show("Некорректные данные");
            }
            } 
        }
    }
        
        
        
        
    


    

