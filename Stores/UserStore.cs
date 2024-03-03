using Pick_up_Point_App.Model;
using Pick_up_Point_App.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pick_up_Point_App.Stores
{
    public class UserStore : PropertyChange
    {
        private User _curUser;

        public User CurrentUser { get => _curUser; set { _curUser = value; OnUserChanged(); } }

        public UserStore()
        {
            _curUser = null;
        }

        public event Action UserChanged;
        private void OnUserChanged()
        {
            UserChanged?.Invoke();
        }
    }
}
