using Microsoft.Win32;
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
using static System.Net.Mime.MediaTypeNames;

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for WindowDockPanel.xaml
    /// </summary>
    public partial class WindowDockPanel : Window
    {
        public WindowDockPanel()
        {
            InitializeComponent();
        }

        private void BtnCenter_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri("pack://application:,,,/Images/TrophyImage.jpg");
            bitmap.EndInit();

            ImgTrophy.Source = bitmap;

            BtnCenter.Visibility = Visibility.Collapsed;
        }
    }
}
