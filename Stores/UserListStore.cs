using Pick_up_Point_App.Model;
using Pick_up_Point_App.Model.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Pick_up_Point_App.Stores
{
    public class UserListStore : PropertyChange
    {
        private List<User> _usersList;

        public List<User> UsersList { get => _usersList; set { _usersList = value; OnUsersListChanged(); } }

        public UserListStore()
        {
            UsersList = new List<User>()
            {
                new User (id:1,name:"John",secondname:"Smith",sex:true, login:"JohnS", photoPathName:"1JohnSmith", email:"johnsmith@gmail.com",phone:"806-983-8838",password:"JohnSmithPassword1",isAdmin:false),
                new User (id:2,name:"Sandra",secondname:"Timmons",sex:false, login:"SandraT",photoPathName:"2SandraTimmons", email:"sandratimmons@gmail.com",phone:"302-657-1380",password:"SandraTimmonsPassword2",isAdmin:false),
                new User (id:3,name:"Molly",secondname:"Jolly",sex:false,login : "MollyJ", photoPathName:"3MollyJolly", email:"mollyjolly@gmail.com",phone:"440-294-3820",password:"MollyJollyPassword3",isAdmin:false),
                new User (id:4,name:"Garrett",secondname:"Moore",sex:true,login : "GarrettM", photoPathName:"4GarrettMoore", email:"garrettmoore@gmail.com",phone:"253-550-9243",password:"GarrettMoorePassword4",isAdmin:true),
                new User (id:5,name:"admin",secondname:"admin",sex:false,login:"admin",photoPathName:"BlankPhoto", email:"",phone:"",password:"admin",isAdmin:true),
            };
        }
        
        public event Action UsersListChanged;
        private void OnUsersListChanged()
        {
            UsersListChanged?.Invoke();
        }
    
    }
}
