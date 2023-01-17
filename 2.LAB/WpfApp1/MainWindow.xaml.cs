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

namespace WpfApp1
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
            bool a = true; //хранит значение true или false.
            byte b = 10 ; //хранит целое число от 0 до 255 и занимает 1 байт.
            sbyte d = -100; //хранит целое число от -128 до 127 и занимает 1 байт.
            short c = -20000 ; //хранит целое число от -32768 до 32767 и занимает 2 байта.
            ushort h = 200  ; //хранит целое число от 0 до 65535 и занимает 2 байта.
            uint f = 234523; //хранит целое число от -2147483648 до 2147483647 и занимает 4 байта.
            long g = 1901234; //хранит целое число от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 и занимает 8 байт.
            ulong k = 5 ; //хранит целое число от 0 до 18 446 744 073 709 551 615 и занимает 8 байт.
            float j = 10; //хранит число с плавающей точкой от -3.4*1038 до 3.4*1038 и занимает 4 байта.
            double l = 10.2; // хранит число с плавающей точкой от ±5.0 * 10 - 324 до ±1.7 * 10308 и занимает 8 байта. 
        }
    }
}
