using Pick_up_Point_App.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pick_up_Point_App.Model
{
    public class PuP : PropertyChange
    {
        private int _id;
        private string _address;
        private int _ordersGet;
        private int _ordersGive;
        private int _ordersReturned;
        private int _ordersHave;
        
        public PuP(int id, string address, int ordersGet, int ordersGive, int ordersReturned, int ordersHave)
        {
            Id = id;
            Address = address;
            OrdersGet = ordersGet;
            OrdersGive = ordersGive;
            OrdersReturned = ordersReturned;
            OrdersHave = ordersHave;
        }

        public int Id { get { return _id;} set { _id = value;OnPropertyChanged(nameof(Id)); } }
        public string Address { get { return _address; } set { _address = value; OnPropertyChanged(nameof(Address)); } }
        public int OrdersGet { get { return _ordersGet; } set { _ordersGet = value; OnPropertyChanged(nameof(OrdersGet)); } }
        public int OrdersGive { get { return _ordersGive; } set { _ordersGive = value; OnPropertyChanged(nameof(OrdersGive)); } }
        public int OrdersReturned { get { return _ordersReturned; } set { _ordersReturned = value; OnPropertyChanged(nameof(OrdersReturned)); } }
        public int OrdersHave { get { return _ordersHave; } set { _ordersHave = value; OnPropertyChanged(nameof(OrdersHave)); } }
    }
}
