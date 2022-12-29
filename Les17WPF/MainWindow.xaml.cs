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

namespace Les17WPF
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

        int num = 0;
        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            num++;
            bPlus.Content = $"+({num})";
        }
        int num2 = 0;
        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            num2--;
            Minus.Content = $"-({num2})";
        }
    }
}
