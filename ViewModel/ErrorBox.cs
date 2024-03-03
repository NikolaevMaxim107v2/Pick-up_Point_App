using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Pick_up_Point_App.ViewModel
{
    public abstract class ErrorBox
    {

        public static void LoginError()
        {
            MessageBox.Show("Логин введён неверно, перепроверьте вводимые данные!", "Ошибка авторизации", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        public static void EmptyLoginError()
        {
            MessageBox.Show("Логин не введён, перепроверьте вводимые данные!", "Ошибка авторизации", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public static void LoginPasswordError()
        {
            MessageBox.Show("Логин или пароль введены неверно, перепроверьте вводимые данные!", "Ошибка авторизации", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public static void PasswordError()
        {
            MessageBox.Show("Пароль введён неверно, перепроверьте вводимые данные!", "Ошибка авторизации", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public static void EmptyPasswordError()
        {
            MessageBox.Show("Пароль не введён, перепроверьте вводимые данные!", "Ошибка авторизации", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public static void DeniedSymbolsError()
        {
            MessageBox.Show("Вы использовали запрещённые символы ?#<>%@/, пожалуйста, проверяйте вводимые данные!", "Запрещённые символы", MessageBoxButton.OK, MessageBoxImage.Error);
        }

    }
}
