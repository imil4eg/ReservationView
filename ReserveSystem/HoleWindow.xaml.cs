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

namespace ReserveSystem
{
    /// <summary>
    /// Interaction logic for HoleWindow.xaml
    /// </summary>
    public partial class HoleWindow : Window
    {
        public HoleWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ReserveWindow rw = new ReserveWindow();
            rw.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Orders ow = new Orders();
            ow.Show();
        }
    }
}
