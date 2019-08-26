using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Recipes
{

  public class California : APizzaMaker
  {
    public override Pizza Make()
    {
      Pizza c = new Pizza();
      c.Name = "California"; 
      c.Crust= new Crust("Stuffed");
      c.Toppings = new List<Topping>
      {
        new Topping("Pepperoni"), new Topping("Double Cheese"),
        new Topping("Bacon")
      };
      
      c.Size = new Size("Large");
      c.TotalPrice =7.00M;


      return c;    }
  }
}