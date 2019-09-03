using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Size //: AIngredient
  {
    [ForeignKey("SizeId")]
    public int SizeId {get;set;}
    [Required]
    public string Name {get;set;}
    [Required]
    public decimal Price {get;set;}
    
    public Size()
    {
      //sizePrices();
    }


    // public decimal sizePrices(){
    //   if (Name.CompareTo("Small")==0)
    //   {
    //     return Price = 4;
    //   }
    //   else if (Name.CompareTo("Medium") ==0)
    //   {
    //     return Price = 5;
    //   }
    //   else if (Name.CompareTo("Large") == 0)
    //   {
    //     return Price = 6;
    //   }
    //   else
    //   {
    //     System.Console.WriteLine("Medium it is!");
    //     return Price = 4;
    //   }
    //}

  }
}