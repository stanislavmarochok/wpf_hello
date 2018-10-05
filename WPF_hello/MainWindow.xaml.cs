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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_hello
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int index = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonOpen_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e) {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;

            Storyboard sb = this.FindResource("OpenMenu") as Storyboard;
            sb.Begin();
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e){
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;

            Storyboard sb = this.FindResource("CloseMenu") as Storyboard;
            sb.Begin();
        }

        private void Button_Click(object sender, RoutedEventArgs e) { }
        private void ButtonClose_Click(object sender, RoutedEventArgs e) { }
    }
}
