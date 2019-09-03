
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Recipes
{
  public class Chicago : APizzaMaker
  {
    public override Pizza Make()
    {
      Pizza c = new Pizza();
      c.Name = "Chicago"; 
      c.Crust= new Crust(){Name = "Deep Dish"};
      c.Toppings = new List<Topping>
      {
        new Topping(){Name = "Pepperoni"}, new Topping(){Name = "Cheese"},
        new Topping(){Name = "Bacon"}, new Topping(){Name = "Sausage"}
      };
      
      c.Size = new Size(){Name = "Large"};  
      c.TotalPrice =7.00M;

      
      return c;
    }

  }
}