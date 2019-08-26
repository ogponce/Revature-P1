using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Recipes
{

  public class NewYork : APizzaMaker
  {

    public override Pizza Make()
    {
      Pizza c = new Pizza();
      c.Name = "New York"; 
      c.Crust= new Crust( "Thin");
      c.Toppings = new List<Topping>
      {
        new Topping("Pepperoni"), new Topping("Cheese"),
        new Topping("Bacon"), new Topping("Mushrooms"), 
        new Topping("Olives")
      };
      
      c.Size = new Size("Large");
      c.TotalPrice =7.00M;


      return c;    }
  }
}