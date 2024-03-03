using Pick_up_Point_App.Commands;
using Pick_up_Point_App.Model.Base;
using Pick_up_Point_App.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Pick_up_Point_App.ViewModel
{
    public class MainPageAdminVM : PropertyChange
    {
        public ICommand LogoutCommand { get; }
        public ICommand ToUserDataCommand { get; }
        public ICommand ToAddPageCommand { get; }
        public ICommand ToGivePageCommand { get; }
        public string CurrentUserText { get; set; }
        public MainPageAdminVM(NavigationStore navigationStore, WindowTitleStore windowTitleStore, UserStore userStore)
        {
            CurrentUserText = CurrentUserText + "Пользователь: " + userStore.CurrentUser.Name + " " + userStore.CurrentUser.Secondname;
            windowTitleStore.WindowTitle = "Pick-up Point application: Admin Rights";
            LogoutCommand = new LogoutCommand(navigationStore, windowTitleStore);
            ToUserDataCommand = new ToUserDataCommand(navigationStore, windowTitleStore, userStore);
            ToAddPageCommand = new ToAddPageCommand(navigationStore, windowTitleStore, userStore);
            ToGivePageCommand = new ToGivePageCommand(navigationStore, windowTitleStore, userStore);
        }
    }
}
