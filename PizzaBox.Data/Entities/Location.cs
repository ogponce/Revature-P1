using System;
using System.Collections.Generic;

namespace PizzaBox.Data.Entities
{
    public partial class Location
    {
        public Location()
        {
            Order1 = new HashSet<Order1>();
        }

        public int LocationId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }

        public virtual ICollection<Order1> Order1 { get; set; }
    }
}
