using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Crust //: AIngredient
  {
    [ForeignKey("CrustId")]
    public int CrustId { get; set; }
    [Required]
    public string Name {get;set;}
    public decimal Price {get;set;}
   public Crust(){} //: base(name){
  //    crustPrices();
  //  } 

  //  public decimal crustPrices(){
  //     if (Name.Equals("Deep Dish") || Name.Equals("Stuffed"))
  //     {
  //       return Price = 1;
  //     }
  //     else if(Name.Equals("Thin")||Name.Equals("Traditional"))
  //     {
  //       return Price = 0;
  //     }
  //     else {
  //       System.Console.WriteLine("Traditional it is!");
  //       return Price = 0;
  //     }
  //   }
  }
}