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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public static int function2(int[] numbers)
        {
            for (var h = numbers.Length / 2; h > 0; h /= 2)
            {
                for (var i = h; i < numbers.Length; i += 1)
                {
                    var temp = numbers[i];
                    int t;
                    for (t = i; t >= h && numbers[t - h] > temp; t -= h)
                    {
                        numbers[t] = numbers[t - h];
                    }
                    numbers[t] = temp;
                }
            }
            return 0;
        }
    }
}
