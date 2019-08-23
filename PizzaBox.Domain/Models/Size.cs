using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Size : AIngredient
  {
    public Size(string name) : base(name){}

    public decimal sizePrices(){
      if (Name.Equals("Small"))
      {
        return Price = 3;
      }
      else if (Name.Equals("Medium"))
      {
        return Price = 4;
      }
      else if (Name.Equals("Large"))
      {
        return Price = 5;
      }
      else
      {
        System.Console.WriteLine("Medium it is!");
        return Price = 4;
      }


      
    }

  }
}