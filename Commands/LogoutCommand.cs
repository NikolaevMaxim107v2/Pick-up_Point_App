using Pick_up_Point_App.Model.Base;
using Pick_up_Point_App.Stores;
using Pick_up_Point_App.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace Pick_up_Point_App.Commands
{
    public class LogoutCommand : CommandBase
    {
        private NavigationStore _navigationStore;
        public ICommand NavigateToStartPageCommand { get; }

        public LogoutCommand(NavigationStore navigationStore, WindowTitleStore windowTitleStore)
        {
            _navigationStore = navigationStore;
            NavigateToStartPageCommand = new NavigationCommand<WelcomePageVM>(navigationStore, () => new WelcomePageVM(navigationStore, windowTitleStore));
        }

        public override void Execute(object parameter)
        {
            MessageBoxResult res = MessageBox.Show("Вы уверены, что хотите выйти?", "Выход", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (res == MessageBoxResult.Yes)
            {
                NavigateToStartPageCommand.Execute(true);
            }
            else
            {
                return;
            }
        }
    }
}
