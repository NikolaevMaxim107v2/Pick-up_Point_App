using Pick_up_Point_App.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pick_up_Point_App.Model
{
    public class PuP_User : PropertyChange
    {
        private int _id;
        private int _userID;
        private int _pupID;

        public PuP_User(int id, int userID, int pupID) 
        {
            Id = id;
            UserId = userID;
            PuPId = pupID;
        }

        public int Id { get { return _id; } set { _id = value; OnPropertyChanged(nameof(Id)); } }
        public int UserId { get { return _userID; } set { _userID = value; OnPropertyChanged(nameof(UserId)); } }
        public int PuPId { get { return _pupID; } set { _pupID = value; OnPropertyChanged(nameof(PuPId)); } }

    }
}
