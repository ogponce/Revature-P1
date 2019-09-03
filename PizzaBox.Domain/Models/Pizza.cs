using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using System.ComponentModel.DataAnnotations.Schema;


namespace PizzaBox.Domain.Models
{
  public class Pizza 
  {
    public int PizzaId {get;set;}
    public string Name {get;set;}
    public Crust Crust { get; set; }
    public Size Size { get; set; }
    public List<Topping> Toppings { get; set; }
    public decimal TotalPrice {get;set;}
    [NotMapped]
    public List<Pizza> Pizzas {get;set;}

    public override string ToString()
    {
      return $"{Name} Pizza has a {Crust.Name} crust, and it is a size {Size.Name}";
    }
  }
} 