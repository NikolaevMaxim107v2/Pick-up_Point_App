using Pick_up_Point_App.Model.Base;
using Pick_up_Point_App.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pick_up_Point_App.Commands
{
    public class NavigationCommand<TViewModel> : CommandBase
        where TViewModel : PropertyChange
    {
        private readonly NavigationStore _navigationStore;
        private readonly Func<TViewModel> _changeVM;

        public NavigationCommand(NavigationStore navigationStore, Func<TViewModel> changeVM)
        {
            _navigationStore = navigationStore;
            _changeVM = changeVM;
        }

        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViedModel = _changeVM();
        }
    }
}
