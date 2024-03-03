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
    public class UserDataPageVM : PropertyChange
    {
        public string Name { get; set; }
        public string Secondname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Sex { get; set; }
        public string PhotoPath { get; set; }
        public ICommand BackToMain { get; }
        public UserDataPageVM(NavigationStore navigationStore, WindowTitleStore windowTitleStore, UserStore userStore)
        {
            PhotoPath = "/Resources/Images/" + userStore.CurrentUser.PhotoPathName + ".png";
            Name = userStore.CurrentUser.Name;
            Secondname = userStore.CurrentUser.Secondname;
            Phone = userStore.CurrentUser.Phone;
            Email = userStore.CurrentUser.Email;
            if (userStore.CurrentUser.Sex == false)
                Sex = "Женский";
            else
                Sex = "Мужской";
            windowTitleStore.WindowTitle = "Pick-up Point application: User Data";
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
