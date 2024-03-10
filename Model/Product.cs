using Pick_up_Point_App.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pick_up_Point_App.Model
{
    public class Product : PropertyChange
    {
        private int _id;
        private string _name;
        private int _productTypeId;
        private float _price;


        public Product(int id, string name, int productTypeId, float price)
        {
            Id = id;
            Name = name;
            ProductTypeId = productTypeId;
            Price = price;
        }

        public int Id { get { return _id; } set { _id = value; OnPropertyChanged(nameof(Id)); } }
        public string Name { get { return _name; } set { _name = value; OnPropertyChanged(nameof(Name)); } }
        public int ProductTypeId { get { return _productTypeId; } set { _productTypeId = value; OnPropertyChanged(nameof(ProductTypeId)); } }
        public float Price { get { return _price; } set { _price = value; OnPropertyChanged(nameof(Price)); } }

        //private int _relOrderID;
        //RelOrderId = relOrderID;
        //public int RelOrderId { get { return _relOrderID; } set { _relOrderID = value; OnPropertyChanged(nameof(RelOrderId)); } }
    }
}
