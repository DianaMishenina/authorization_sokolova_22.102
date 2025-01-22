using authorization_sokolova_22._102.Pages;
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

namespace authorization_sokolova_22._102
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

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            var db = Helper.GetContext();

            string login = tbLogin.Text.Trim();
            string password = tbPassword.Text.Trim();

            var autho = db.Authorizations.Where(x => x.login == login && x.password == password).FirstOrDefault();
            
            

            if (autho != null)
            {
                NavigationService.Navigate(new Enter(autho));
                MessageBox.Show($"Добро пожаловать! Ваша роль: ");
                
            }
            else
            {
                MessageBox.Show("Неверно введены логин или пароль!");
            }
        }
    }
}
