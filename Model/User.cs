using Pick_up_Point_App.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pick_up_Point_App.Model
{
    public class User : PropertyChange
    {
        private int _id;
        private string _name;
        private string _secondname;
        private bool _sex; //false - женский, true - мужской
        private string _login;
        private string _photoPathName;
        private int _posID;
        private string _email;
        private string _phone;
        private string _password;
        private bool _isAdmin; //false - простой пользователь, true - администратор

        public User(int id, string name, string secondname, bool sex, string login, string photoPathName, int posID,string email, string phone,string password, bool isAdmin)
        {
            Id = id;
            Name = name;
            Secondname = secondname;
            Sex = sex;
            Login = login;
            PhotoPathName = photoPathName;
            PosId = posID;
            Email = email;
            Phone = phone;
            Password = password;
            IsAdmin = isAdmin;
        }

        public int Id { get { return _id; } set { _id = value; OnPropertyChanged(nameof(Id)); } }
        public string Name { get { return _name; } set { _name = value; OnPropertyChanged(nameof(Name)); } }
        public string Secondname { get { return _secondname; } set { _secondname = value; OnPropertyChanged(nameof(Secondname)); } }
        public bool Sex { get { return _sex; } set { _sex = value; OnPropertyChanged(nameof(Sex)); } }
        public string Login { get { return _login; } set { _login = value; OnPropertyChanged(nameof(Login)); } }
        public string PhotoPathName { get { return _photoPathName; } set { _photoPathName = value; OnPropertyChanged(nameof(PhotoPathName)); } }
        public int PosId { get { return _posID; } set { _posID = value; OnPropertyChanged(nameof(PosId)); } }
        public string Email { get { return _email; } set { _email = value; OnPropertyChanged(nameof(Email)); } }
        public string Phone { get { return _phone; } set { _phone = value; OnPropertyChanged(nameof(Phone)); } }
        public string Password { get { return _password; } set { _password = value; OnPropertyChanged(nameof(Password)); } }
        public bool IsAdmin { get { return _isAdmin; } set { _isAdmin = value; OnPropertyChanged(nameof(IsAdmin)); } }

    }
}
