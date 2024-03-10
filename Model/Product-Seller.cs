using Pick_up_Point_App.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pick_up_Point_App.Model
{
    public class Product_Seller : PropertyChange
    {
        private int _id;
        private int _userID;
        private int _productID;

        public Product_Seller(int id, int userID, int productID)
        {
            Id = id;
            UserId = userID;
            ProductId = productID;
        }

        public int Id { get { return _id; } set { _id = value; OnPropertyChanged(nameof(Id)); } }
        public int UserId { get { return _userID; } set { _userID = value; OnPropertyChanged(nameof(UserId)); } }
        public int ProductId { get { return _productID; } set { _productID = value; OnPropertyChanged(nameof(ProductId)); } }

    }
}
