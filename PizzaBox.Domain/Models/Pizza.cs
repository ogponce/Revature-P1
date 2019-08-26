using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Pizza 
  {

    public string Name {get;set;}
    public Crust Crust { get; set; }
    public Size Size { get; set; }
    public List<Topping> Toppings { get; set; }

    public decimal TotalPrice {get;set;}
    // public decimal calculatePrice()
    // {
    //   return TotalPrice; 
    // }


  }

 

} 