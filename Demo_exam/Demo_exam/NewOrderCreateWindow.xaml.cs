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
    /// Логика взаимодействия для NewOrderCreateWindow.xaml
    /// </summary>
    public partial class NewOrderCreateWindow : Window
    {
        private Orders _currentOrder = new Orders();
        private static DemoExamDataBaseEntities _context;
        public NewOrderCreateWindow(Orders selectedOrder)
        {
            InitializeComponent();
            if (selectedOrder != null)
                _currentOrder = selectedOrder;
            DataContext = _currentOrder;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            AdminWindow adminWindow = new AdminWindow();
            adminWindow.Show();
            Close();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder(); ///Создание нового объекта класса StringBuilder для сохранения ошибки ввода
            if (_currentOrder.Number == null)
                errors.AppendLine("Введите номер");
            if (_currentOrder.Compound == null)
                errors.AppendLine("Выберите должность сотрудника");
            if (_currentOrder.DateOfOrder == null)
                errors.AppendLine("Введите дату заказа");
            if (_currentOrder.DateOfDelievery == null)
                errors.AppendLine("Выберите дату доставки");
            if (_currentOrder.PointOfIssue == null)
                errors.AppendLine("Введите пункт доставки");
            if (_currentOrder.ClientSNP == null)
                errors.AppendLine("Выберите ФИО клиента");
            if (_currentOrder.Status == null)
                errors.AppendLine("Введите статус");

            if (errors.Length > 0) ///Если errors не пуст, исполнить отправку сообщения с содержимым errors, полученным в условиях выше
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_currentOrder.Number != null && _currentOrder.Compound != null && _currentOrder.DateOfOrder != null && _currentOrder.DateOfDelievery != null && _currentOrder.PointOfIssue != null && _currentOrder.ClientSNP != null && _currentOrder.Status != null)
                DemoExamDataBaseEntities.GetContext().Orders.Add(_currentOrder);
            try
            {
                DemoExamDataBaseEntities.GetContext().SaveChanges();
                MessageBox.Show("Данные успешно добавлены!");
                AdminWindow adminWindow = new AdminWindow();
                adminWindow.Show();
                Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
