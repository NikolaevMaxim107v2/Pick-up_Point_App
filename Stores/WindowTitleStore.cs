using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pick_up_Point_App.Stores
{
    public class WindowTitleStore
    {
        private string _windowTitle;

        public string WindowTitle
        {
            get => _windowTitle;
            set
            {
                _windowTitle = value;
                OnCurrentWinTitleChanged();
            }
        }
        public event Action CurrentWinTitleChanged;
        private void OnCurrentWinTitleChanged()
        {
            CurrentWinTitleChanged?.Invoke();
        }
    }
}
