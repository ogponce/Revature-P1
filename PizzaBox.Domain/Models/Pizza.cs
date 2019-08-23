using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Pizza : APizza{

    public decimal calculatePrice()
    {
      return TotalPrice; 
    }


  }

 

} 