using ParameterScanner.View;
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

namespace ParameterScanner.View
{
    /// <summary>
    /// 
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool IsOpen = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!IsOpen)
            {
                SearchControl search = new SearchControl();
                searchControlHost.Content = search;
                searchControlHost.Visibility = Visibility.Visible;
            }
            else
            {
                searchControlHost.Visibility = Visibility.Hidden;
            }

            IsOpen = !IsOpen;
        }

        private void RibbonButton_Click(object sender, RoutedEventArgs e)
        {
            if (!IsOpen)
            {
                SearchControl search = new SearchControl();
                searchControlHost.Content = search;
                searchControlHost.Visibility = Visibility.Visible;
            }
            else
            {
                searchControlHost.Visibility = Visibility.Hidden;
            }

            IsOpen = !IsOpen;
        }
    }
}
