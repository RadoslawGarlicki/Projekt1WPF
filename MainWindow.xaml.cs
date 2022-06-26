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

namespace Projekt1WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int clickedtimes;

        public MainWindow()
        {
            InitializeComponent();

            clickedtimes = 0;
        }


        private void MainButton_Click(object sender, RoutedEventArgs e)
        {
            clickedtimes++;
            MainLabel.Content = "klikłeś przycisk " + clickedtimes + " razy.";
        }
    }
}
