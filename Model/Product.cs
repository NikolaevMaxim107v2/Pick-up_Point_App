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
        private string _productDesc;
        private float _price;
        //private int _relOrderID;


        public Product(int id, string name, int productTypeId, string productDesc, float price)
        {
            Id = id;
            Name = name;
            ProductTypeId = productTypeId;
            ProductDesc = productDesc;
            Price = price;
            //RelOrderId = relOrderID;
        }

        public int Id { get { return _id; } set { _id = value; OnPropertyChanged(nameof(Id)); } }
        public string Name { get { return _name; } set { _name = value; OnPropertyChanged(nameof(Name)); } }
        public int ProductTypeId { get { return _productTypeId; } set { _productTypeId = value; OnPropertyChanged(nameof(ProductTypeId)); } }
        public string ProductDesc { get { return _productDesc; } set { _productDesc = value; OnPropertyChanged(nameof(ProductDesc)); } }
        public float Price { get { return _price; } set { _price = value; OnPropertyChanged(nameof(Price)); } }
        //public int RelOrderId { get { return _relOrderID; } set { _relOrderID = value; OnPropertyChanged(nameof(RelOrderId)); } }
    }
}
