using System.Windows;

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //HEJ
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnGrid_Click(object sender, RoutedEventArgs e)
        {
            WindowGrid newWindow = new WindowGrid();
            newWindow.Show();
        }

        private void BtnStackPanel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnWrapPanel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDockPanel_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}