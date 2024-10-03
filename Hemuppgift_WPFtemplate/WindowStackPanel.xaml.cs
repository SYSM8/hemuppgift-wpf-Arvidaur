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

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for WindowStackPanel.xaml
    /// </summary>
    public partial class WindowStackPanel : Window
    {
        public WindowStackPanel()
        {
            InitializeComponent();
        }

        private void BtnHorizontal_Click(object sender, RoutedEventArgs e)
        {
            StackPanelSquares.Orientation = Orientation.Horizontal;
        }

        private void BtnVertical_Click(object sender, RoutedEventArgs e)
        {
            StackPanelSquares.Orientation = Orientation.Vertical;
        }
    }
}
