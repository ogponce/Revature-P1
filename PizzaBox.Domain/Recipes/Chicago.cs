
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Recipes
{
  public class Chicago : APizzaMaker
  {
    public override APizza Make()
    {
      Pizza c = new Pizza();
      c.Name = "Chicago"; 
      c.Crust= new Crust( "Deep Dish");
      c.Toppings = new List<Topping>
      {
        new Topping("Pepperoni"), new Topping("Cheese"),
        new Topping("Bacon"), new Topping("Sausage")
      };
      
      c.Size = new Size("Large");
      c.TotalPrice =7;

      
      return c;
    }

  }
}