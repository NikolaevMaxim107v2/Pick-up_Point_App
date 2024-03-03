using Pick_up_Point_App.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pick_up_Point_App.Model
{
    public class Order : PropertyChange
    {
        private int _id;
        private int _customerID;
        private string _orderPassword;
        private float _price;
        private DateTime _orderDate;
        private DateTime _orderGetDate;
        private DateTime _orderGiveDate;
        private bool _isGiven;
        private bool _isReturned;
        

        public Order(int id, int customerID, string orderPassword, float price, DateTime orderDate, DateTime orderGetDate, DateTime orderGiveDate, bool isGiven, bool isReturned)
        {
            Id = id;
            CustomerID = customerID;
            OrderPassword = orderPassword;
            Price = price;
            OrderDate = orderDate;
            OrderGetDate = orderGetDate;
            OrderGiveDate = orderGiveDate;
            IsGiven = isGiven;
            IsReturned = isReturned;
        }

        public int Id { get { return _id; } set { _id = value; OnPropertyChanged(nameof(Id)); } }
        public int CustomerID { get { return _customerID; } set { _customerID = value; OnPropertyChanged(nameof(CustomerID)); } }
        public string OrderPassword { get { return _orderPassword; } set { _orderPassword = value; OnPropertyChanged(nameof(OrderPassword)); } }
        public float Price { get { return _price; } set { _price = value; OnPropertyChanged(nameof(Price)); } }
        public DateTime OrderDate { get { return _orderDate; } set { _orderDate = value; OnPropertyChanged(nameof(OrderDate)); } }
        public DateTime OrderGetDate { get { return _orderGetDate; } set { _orderGetDate = value; OnPropertyChanged(nameof(OrderGetDate)); } }
        private DateTime OrderGiveDate { get { return _orderGiveDate; } set { _orderGiveDate = value; OnPropertyChanged(nameof(OrderGiveDate)); } }
        private bool IsGiven { get { return _isGiven; } set { _isGiven = value; OnPropertyChanged(nameof(IsGiven)); } }
        private bool IsReturned { get { return _isReturned; } set { _isReturned = value; OnPropertyChanged(nameof(IsReturned)); } }

    }
}
