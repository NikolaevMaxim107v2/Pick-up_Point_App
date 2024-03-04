using Pick_up_Point_App.Model;
using Pick_up_Point_App.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pick_up_Point_App.Stores
{
   public class PuPListStore : PropertyChange
   {
        private List<PuP> _pupsList;

        public List<PuP> PuPsList { get => _pupsList; set { _pupsList = value; OnPuPChanged(); } }

        public PuPListStore()
        {
            PuPsList = new List<PuP> 
            { 
                new PuP (id:1,address:"5483 Johns Dam Apt. 984", ordersGet: 12, ordersGive: 7, ordersReturned:2, ordersHave: 3),
                new PuP (id:2,address:"83968 Schimmel Unions Suite 765", ordersGet: 0, ordersGive: 0, ordersReturned:0, ordersHave: 0),
                new PuP (id:3,address:"429 Labadie Mount Apt. 683", ordersGet: 15, ordersGive: 15, ordersReturned:5, ordersHave: 0),
            };
        }

        public event Action PuPChanged;
        public void OnPuPChanged()
        {
           PuPChanged?.Invoke();
        }
   }
}
