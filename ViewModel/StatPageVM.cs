using Pick_up_Point_App.Commands;
using Pick_up_Point_App.Model.Base;
using Pick_up_Point_App.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Pick_up_Point_App.ViewModel
{

    public class StatPageVM : PropertyChange
    {
        public ICommand BackToMain { get; }
        public StatPageVM(NavigationStore navigationStore, WindowTitleStore windowTitleStore, UserDataStore userDataStore) 
        {
            windowTitleStore.WindowTitle = "Pick-up poin application: Statistics";
            if (userDataStore.CurrentUser.IsAdmin)
            {
                BackToMain = new ToMainPageAdminCommand(navigationStore, windowTitleStore, userDataStore);
            }
            else
            {
                BackToMain = new ToMainPageCommand(navigationStore, windowTitleStore, userDataStore);
            }
        }
    }
}
