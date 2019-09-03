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
      c.Crust= new Crust(){Name = "Thin"};
      c.Toppings = new List<Topping>
      {
        new Topping(){Name = "Pepperoni"}, new Topping(){Name = "Cheese"},
        new Topping(){Name = "Bacon"}, new Topping(){Name = "Mushrooms"}, 
        new Topping(){Name = "Olives"}
      };
      
      c.Size = new Size(){Name = "Large"};  
      c.TotalPrice =7.00M;


      return c;    }
  }
}