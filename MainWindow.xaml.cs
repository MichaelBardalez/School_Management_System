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
using MaterialDesignThemes.Wpf;

namespace StoreManagementDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Window1 : Window
    {

    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void BtnIcon_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BtnIcon2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnIcon3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnIcon4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GridToolBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

       
    }

}
