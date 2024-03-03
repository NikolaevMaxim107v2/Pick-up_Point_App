using Pick_up_Point_App.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pick_up_Point_App.Stores
{
    public class NavigationStore
    {
        private PropertyChange _currentViedModel;
        public PropertyChange CurrentViedModel
        {
            get => _currentViedModel;
            set
            {
                _currentViedModel = value;
                OnCurrentViewModelChanged();
            }
        }
        public event Action CurrentViewModelChanged;
        private void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }
    }
}
