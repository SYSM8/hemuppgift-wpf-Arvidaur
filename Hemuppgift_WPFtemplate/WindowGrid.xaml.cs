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
    /// Interaction logic for WindowGrid.xaml
    /// </summary>
    public partial class WindowGrid : Window
    {
        public WindowGrid()
        {
            InitializeComponent();
        }

        

        private void BtnApply_Click(object sender, RoutedEventArgs e)
        {
            int column;
            int row;

            if (int.TryParse(TxtBoxColumn.Text, out column) &&
                int.TryParse(TxtBoxRow.Text, out row))
            {
                if (column >= 0 && column <= 3 && row >= 0 && row <= 3) //Kontrollerar att index är mellan 0-3
                {
                    // Skapar en ny knapp
                    Button newButton = new Button();
                    newButton.Content = $"Row {row}, Column {column}";
                    newButton.Background = new SolidColorBrush(Colors.LightGreen);

                    //Anger positionen för den nya knappen
                    System.Windows.Controls.Grid.SetRow(newButton, row + 1);  // +1 för det egentligen är 5 rows men vi använder bara 4
                    System.Windows.Controls.Grid.SetColumn(newButton, column);

                    // Lägger till en event handler
                    newButton.Click += BtnNewButton_Click;

                    // Lägger till den nya knappen
                    MainGrid.Children.Add(newButton);
                }
                else
                {
                    MessageBox.Show("Index måste vara mellan 0-3", "Fel inmatingsformat", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Ange siffror för index. 0-3", "Fel inmatingsformat", MessageBoxButton.OK,  MessageBoxImage.Error);
            }

        }
        private void BtnNewButton_Click(object sender, RoutedEventArgs e)
        {
            //MainGrid.Children.Remove(newButton);
        }
    }
}
