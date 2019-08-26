using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Size : AIngredient
  {
    public Size(string name) : base(name)
    {
      sizePrices();
    }

    public decimal sizePrices(){
      if (Name.CompareTo("Small")==0)
      {
        return Price = 3;
      }
      else if (Name.CompareTo("Medium") ==0)
      {
        return Price = 4;
      }
      else if (Name.CompareTo("Large") == 0)
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