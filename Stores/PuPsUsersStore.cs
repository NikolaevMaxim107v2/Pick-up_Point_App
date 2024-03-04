using Pick_up_Point_App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pick_up_Point_App.Stores
{
    public class PuPsUsersStore
    {
        private List<PuP_User> _pupsUsersList;

        public List<PuP_User> PuPsUsersList { get => _pupsUsersList; set { _pupsUsersList = value; OnPuPsUsersListChanged(); } }

        public PuPsUsersStore()
        {
            PuPsUsersList = new List<PuP_User>()
            {
                new PuP_User (id:1, userID: 1, pupID: 1),
                new PuP_User (id:2, userID: 2, pupID: 1),
                new PuP_User (id:3, userID: 3, pupID: 1),
                new PuP_User (id:4, userID: 4, pupID: 1),
                new PuP_User (id:5, userID: 5, pupID: 0),
            };
        }

        public event Action PuPsUsersListChanged;
        private void OnPuPsUsersListChanged()
        {
            PuPsUsersListChanged?.Invoke();
        }

    }
}
