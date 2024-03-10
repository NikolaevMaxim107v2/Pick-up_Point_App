using Pick_up_Point_App.Commands;
using Pick_up_Point_App.Model;
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
    public class GivePageVM : PropertyChange
    {
        private int productCode;
        private int orderCode;

        public int ProductCode { get { return productCode; } set { productCode = value; OnPropertyChanged(nameof(ProductCode)); } }
        public int OrderCode { get { return orderCode; } set { orderCode = value; OnPropertyChanged(nameof(OrderCode)); } }

        public ICommand BackToMain { get; }

        public GivePageVM(NavigationStore navigationStore, WindowTitleStore windowTitleStore, UserDataStore userStore)
        {
            windowTitleStore.WindowTitle = "Pick-up Point application: Give";
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
