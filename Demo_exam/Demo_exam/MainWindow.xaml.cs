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

namespace Demo_exam
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            string result = LoginMethod(txtLogin.Text, txtPassword.Password);
            if (result == $"Добро пожаловать, {txtLogin.Text}!")
            {
                using (var db = new DemoExamDataBaseEntities())
                {
                    Users user = (from u in db.Users where u.Login == txtLogin.Text select u).FirstOrDefault();
                    if(user.Role == "Менеджер")
                    {
                        ManagerWindow window = new ManagerWindow();
                        window.Show();
                        this.Close();
                    }
                    else if(user.Role == "Админ")
                    {
                        AdminWindow window = new AdminWindow();
                        window.Show();
                        this.Close();
                    }
                    else if(user.Role == "Клиент")
                    {
                        UserGoodsListWindow window = new UserGoodsListWindow(1);
                        window.Show();
                        this.Close();
                    }
                }
            }
            else
            {
                if (result == "Неверный пароль!")
                {
                    MessageBox.Show("Введен неверный пароль");
                    return;
                }
            }
        }

        private void guestBtn_Click(object sender, RoutedEventArgs e)
        {
            UserGoodsListWindow window = new UserGoodsListWindow(0);
            window.Show();
            this.Close();
        }
        private string LoginMethod(string login, string password)
        {
            if (login.Length == 0 || password.Length == 0)
                return "Не все поля заполнены!";
            using (var db = new DemoExamDataBaseEntities())
            {
                Users user = (from u in db.Users where u.Login == login select u).FirstOrDefault();
                if (user == null)
                    return "Пользователя с таким логином не существует!";
                if (user.Password != password)
                    return "Неверный пароль!";
            }
            return $"Добро пожаловать, {login}!";
        }
    }
}
