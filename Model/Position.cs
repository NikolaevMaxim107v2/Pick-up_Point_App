using Pick_up_Point_App.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Pick_up_Point_App.Model
{
    public class Position : PropertyChange
    {
        private int _id;
        private string _name;

        public Position(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get { return _id; } set { _id = value; OnPropertyChanged(nameof(Id)); } }
        public string Name { get { return _name; } set { _name = value; OnPropertyChanged(nameof(Name)); } }
        
    }
}
