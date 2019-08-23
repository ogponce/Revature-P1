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
      custom.Crust= new Crust(c);
      custom.Size = new Size(s);
      custom.Toppings = new List<Topping>();

      int i = 0;
      foreach(var v in t){
        if(i<5){
          custom.Toppings.Add(new Topping(v));
        }
        else{
          break;
        }
        i++;
      }
      
      if(custom.Size.Name.Length < 5){
        custom.Size = new Size("Medium");
      }

      if(custom.Crust.Name.Length < 4){
        custom.Crust = new Crust("Traditional");
      }

      if(custom.Toppings.Capacity <= 2)
      {
        custom.Toppings = new List<Topping>
        {
          new Topping("Pepperoni"), new Topping("Cheese"),
        };      
      }
      
      TotalPrice = calculatePrice(custom.Size.Price,custom.Crust.Price,custom.Toppings);
      return custom;   
    }

    public decimal calculatePrice(decimal s, decimal c, List<Topping> t)
    {
      return s + c + (t.Count * (0.5M));
    }

    public override Pizza Make()
    {
      throw new System.NotImplementedException();
    }
  }
}