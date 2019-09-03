using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Topping//: AIngredient
  {
    [ForeignKey("ToppingId")]
    public int ToppingId {get;set;}
    [Required]
    public string Name {get;set;}
    public decimal Price {get;set;}
    public Topping(){    }
    
  }
}