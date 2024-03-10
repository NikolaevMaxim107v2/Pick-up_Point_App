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
        private int _sellerID;
        private int _pupID;
        private string _orderPassword;
        private DateTime _orderDate;
        private DateTime _orderGetDate;
        private DateTime _orderGiveDate;
        private DateTime _orderReturnDate;
        private bool _isGiven;
        private bool _isReturned;
        public Order(int id, int customerID, int sellerID, int pupID, string orderPassword, DateTime orderDate, DateTime orderGetDate, DateTime orderGiveDate,
            DateTime orderReturnDate, bool isGiven, bool isReturned)
        {
            Id = id;
            CustomerID = customerID;
            SellerID = sellerID;
            PuPID = pupID;
            OrderPassword = orderPassword;
            OrderDate = orderDate;
            OrderGetDate = orderGetDate;
            OrderGiveDate = orderGiveDate;
            OrderReturnDate = orderReturnDate;
            IsGiven = isGiven;
            IsReturned = isReturned;
            _orderReturnDate = orderReturnDate;
        }

        public int Id { get { return _id; } set { _id = value; OnPropertyChanged(nameof(Id)); } }
        public int CustomerID { get { return _customerID; } set { _customerID = value; OnPropertyChanged(nameof(CustomerID)); } }
        public int SellerID { get { return _sellerID; } set { _sellerID = value; OnPropertyChanged(nameof(SellerID)); } }
        public int PuPID { get { return _pupID; } set { _pupID = value; OnPropertyChanged(nameof(PuPID)); } }
        public string OrderPassword { get { return _orderPassword; } set { _orderPassword = value; OnPropertyChanged(nameof(OrderPassword)); } }
        public DateTime OrderDate { get { return _orderDate; } set { _orderDate = value; OnPropertyChanged(nameof(OrderDate)); } }
        public DateTime OrderGetDate { get { return _orderGetDate; } set { _orderGetDate = value; OnPropertyChanged(nameof(OrderGetDate)); } }
        public DateTime OrderGiveDate { get { return _orderGiveDate; } set { _orderGiveDate = value; OnPropertyChanged(nameof(OrderGiveDate)); } }
        public DateTime OrderReturnDate { get { return _orderReturnDate; } set { _orderReturnDate = value; OnPropertyChanged(nameof(OrderReturnDate)); } }
        public bool IsGiven { get { return _isGiven; } set { _isGiven = value; OnPropertyChanged(nameof(IsGiven)); } }
        public bool IsReturned { get { return _isReturned; } set { _isReturned = value; OnPropertyChanged(nameof(IsReturned)); } }

    }
}
