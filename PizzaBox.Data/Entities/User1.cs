using System;
using System.Collections.Generic;

namespace PizzaBox.Data.Entities
{
    public partial class User1
    {
        public User1()
        {
            Order1 = new HashSet<Order1>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Order1> Order1 { get; set; }
    }
}
