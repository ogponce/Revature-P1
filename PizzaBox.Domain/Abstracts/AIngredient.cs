using System.ComponentModel.DataAnnotations;

namespace PizzaBox.Domain.Abstracts
{
  public abstract class AIngredient
  {
    [Required]
    public string Name { get; set; }
    [Required]
    public decimal Price { get; set;}

    public AIngredient(string name){
      Name = name;
    }
  }
}