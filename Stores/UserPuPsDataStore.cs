using Pick_up_Point_App.Model;
using Pick_up_Point_App.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Pick_up_Point_App.Stores
{
    public class UserPuPsDataStore : PropertyChange
    {
        private List<PuP> _curPuPUsers;
        
        public List<PuP> CurUserPuPs { get => _curPuPUsers; set { _curPuPUsers = value; OnCurUserChanged(); } }

        public UserPuPsDataStore() 
        {
            CurUserPuPs = null;
        }

        public event Action CurUserChanged;
        public void OnCurUserChanged()
        {
            CurUserChanged?.Invoke();
        }
    }
}
