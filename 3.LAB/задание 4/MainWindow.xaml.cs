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

namespace задание_4
{
    /// <summary>
    /// Логика взаимодействия для Задание_4.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        double gold = 0;
        int crystal = 0;
        

        private void Gold_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                gold = Convert.ToDouble(Kolv.Text);
                Gold.Content = "Обновить количество золота";
                Z.Content = gold;
                Buy.IsEnabled = true;
                CR.IsEnabled = true;
            }
            catch
            {
                MessageBox.Show("Неверный формат данных");
            }
        }

        private void B_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int crystalbuy = Convert.ToInt32(CR.Text);
                gold -= crystalbuy * 20;
                crystal += crystalbuy;
                if (gold < 0)
                {
                    crystal -= crystalbuy;
                    gold += crystalbuy * 20;
                    MessageBox.Show("Не хватает золота");
                }
                else
                {
                    K.Content = crystal;
                    Z.Content = gold;
                }
            }
            catch
            {
                MessageBox.Show("Неверный формат данных");
            }
        }
    }
}
