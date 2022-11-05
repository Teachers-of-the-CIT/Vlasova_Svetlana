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
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NewOrderCreateWindow window = new NewOrderCreateWindow(null);
            this.Close();
            window.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DemoExamDataBaseEntities.GetContext().SaveChanges();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var eventsForDeleting = OrdersDataGrid.SelectedItems.Cast<Orders>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {eventsForDeleting.Count} элементов?", "Внимание!",
            MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    DemoExamDataBaseEntities.GetContext().Orders.RemoveRange(eventsForDeleting);
                    DemoExamDataBaseEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!", "Окно оповещений");
                    OrdersDataGrid.ItemsSource = DemoExamDataBaseEntities.GetContext().Orders.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}
