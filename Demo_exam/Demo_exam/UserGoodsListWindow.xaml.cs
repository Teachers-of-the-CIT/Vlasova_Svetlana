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

namespace Demo_exam
{
    /// <summary>
    /// Логика взаимодействия для UserGoodsList.xaml
    /// </summary>
    public partial class UserGoodsListWindow : Window
    {
        private int WhoCame;
        public UserGoodsListWindow(int whoCame)
        {
            InitializeComponent();
            WhoCame = whoCame;
            if(WhoCame == 1)
            {
                orderButton.Visibility = Visibility.Visible;
            }
        }

        private void filterComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void searchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            if(WhoCame == 0)
            {
                MainWindow window = new MainWindow();
                window.Show();
                this.Close();
            }
            else if(WhoCame == 1)
            {
                MainWindow window = new MainWindow();
                window.Show();
                this.Close();
            }
        }

        private void orderButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
