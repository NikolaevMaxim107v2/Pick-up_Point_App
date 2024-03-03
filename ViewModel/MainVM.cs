using Pick_up_Point_App.Model.Base;
using Pick_up_Point_App.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pick_up_Point_App.ViewModel
{
    public class MainVM : PropertyChange
    {
        private readonly NavigationStore _navigationStore;
        private readonly WindowTitleStore _windowTitleStore;

        public PropertyChange CurrentViewModel => _navigationStore.CurrentViedModel;
        public string WindowTitle => _windowTitleStore.WindowTitle;

        public MainVM(NavigationStore navigationStore, WindowTitleStore windowTitleStore) 
        {
            _navigationStore = navigationStore;
            _windowTitleStore = windowTitleStore;
            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
            _windowTitleStore.CurrentWinTitleChanged += OnCurrentWinTitleChanged;
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
        private void OnCurrentWinTitleChanged()
        {
            OnPropertyChanged(nameof(WindowTitle));
        }

    }
}
