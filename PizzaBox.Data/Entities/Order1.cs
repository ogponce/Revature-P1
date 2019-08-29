using System;
using System.Collections.Generic;

namespace PizzaBox.Data.Entities
{
    public partial class Order1
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public int LocationId { get; set; }
        public int PizzaId { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }

        public virtual Location Location { get; set; }
        public virtual User1 User { get; set; }
    }
}
