using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Crust : AIngredient
  {
   public Crust(string name) : base(name){} 

   public decimal crustPrices(){
      if (Name.Equals("Thin") || Name.Equals("Deep Dish") || Name.Equals("Stuffed"))
      {
        return Price = 1;
      }
      else
      {
        System.Console.WriteLine("Traditional it is!");
        return Price = 0;
      }
    }
  }
}