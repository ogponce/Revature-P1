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
      c.Crust= new Crust(){Name = "Stuffed"};
      c.Toppings = new List<Topping>
      {
        new Topping(){Name = "Pepperoni"}, new Topping(){Name = "Cheese"},
        new Topping(){Name = "Bacon"}
      };
      
      c.Size = new Size(){Name = "Large"};  
      c.TotalPrice =7.00M;


      return c;    }
  }
}