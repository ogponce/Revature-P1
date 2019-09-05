using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Location 
  {
    public int LocationId {get;set;}
    [Required]
    public string Street {get;set;}
    [Required]
    public string City {get;set;}
    [Required]
    public string State {get;set;}

    public List<Location> Locations {get;set;}
    public List<Order> Orders {get;set;}
    public List<Pizza> PizzasOrdered {get;set;}

    public override string ToString()
        {
          return $"{Street}, {City}, {State}";
        }
  }
}