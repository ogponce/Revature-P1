using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Recipes
{

  public class California : APizzaMaker
  {
    public const decimal TotalPrice = 7;

    public override APizza Make()
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
      c.TotalPrice =7;


      return c;    }
  }
}