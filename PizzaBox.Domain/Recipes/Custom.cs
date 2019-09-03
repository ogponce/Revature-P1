using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Recipes
{

  public class Custom : APizzaMaker
  {
    public decimal TotalPrice {get;set;}

    public Pizza Make(string s, string c, List<string> t)
    {
      Pizza custom = new Pizza();
      custom.Name = "Custom"; 
      custom.Crust= new Crust(){Name = c};
      custom.Size = new Size(){Name = s};
      custom.Toppings = new List<Topping>();

      int i = 0;
      if(t.Count < 2)
      {
        custom.Toppings = new List<Topping>
        {
          new Topping(){Name = "Pepperoni"}, new Topping(){Name = "Cheese"},
        };      
        System.Console.WriteLine("Topping: " + custom.Toppings[0].Name+" has been added!");
        System.Console.WriteLine("Topping: " + custom.Toppings[1].Name+" has been added!");
      }
      else 
      {
        foreach(var v in t){
        if(i<5){
          custom.Toppings.Add(new Topping(){Name = v});
          System.Console.WriteLine("Topping: " + v+" has been added!");
        }
        
        else{
          break;
        }
        i++;
      }
      }
      
      
      if(custom.Size.Name.Length < 5){
        custom.Size = new Size(){Name = "Medium"};  
      }

      if(custom.Crust.Name.Length < 4){
        custom.Crust = new Crust(){Name = "Traditional"};
      }

      

      
      custom.TotalPrice = calculatePrice(custom.Size.Price,custom.Crust.Price,custom.Toppings);
      
      return custom;   
    }

    public decimal calculatePrice(decimal s, decimal c, List<Topping> top)
    {
      return s + c + (top.Count * (0.50M));
    }

    public override Pizza Make()
    {
      throw new System.NotImplementedException();
    }
  }
}