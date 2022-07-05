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

namespace Pawnshop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            loginTextBox.Text = String.Empty;
            passwordTextBox.Password = String.Empty;
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            Helpers.Validator validator = new Helpers.Validator();
            if (loginTextBox.Text != String.Empty || passwordTextBox.Password != String.Empty)
            {
             if (validator.CharacterCheck(loginTextBox.Text) && validator.CharacterCheck(passwordTextBox.Password))
                {
                    Helpers.Authorization authorization = new Helpers.Authorization();
                    if (authorization.Login(loginTextBox.Text, passwordTextBox.Password))
                    {
                        Models.Employess employes = Helpers.Singleton.GetCurrentEmployee();
                        MessageBox.Show($"Вы авторизировались как: {employes.Surname} {employes.Name} {employes.Patronymic}");

                    }
                    else
                    {
                        MessageBox.Show("Такого пользователя не сущетсвует");
                    }
                }
             else
                {
                    MessageBox.Show("Пароль состоит только из латинских символов или цифр");
                }
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!");
            }
        }
    }
}
