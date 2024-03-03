﻿using Pick_up_Point_App.Commands;
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
    public class AddPageVM : PropertyChange
    {
        public ICommand BackToMain { get; }
        public AddPageVM(NavigationStore navigationStore, WindowTitleStore windowTitleStore, UserStore userStore)
        {
            windowTitleStore.WindowTitle = "Pick-up Point application: Add";
            if (userStore.CurrentUser.IsAdmin)
            {
                BackToMain = new ToMainPageAdminCommand(navigationStore, windowTitleStore, userStore);
            }
            else
            {
                BackToMain = new ToMainPageCommand(navigationStore, windowTitleStore, userStore);
            }
        }
    }
}
