using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
//using db = PizzaBox.Entities;

namespace PizzaBox.Domain.Models
{
  public class Order 
  {
    public int OrderId {get;set;}
    public Location OrderLocation {get;set;}
    public User user {get;set;}
    public List<Pizza> Pizzas {get;set;}
    public decimal TotalPrice {get; set;}

    public void calculate(){
      
      
      for(int i = 0; i < Pizzas.Capacity; i++)
      {
        if(Pizzas[i].Name.Length >= 1){
          TotalPrice += Pizzas[i].TotalPrice;
        }
      }     
    }

    // public void Print(){
    //   System.Console.WriteLine("Name: " + user.FirstName + "\nOrdered: ");
    //   foreach(var v in Pizzas)
    //   {
    //     System.Console.WriteLine("\t" + v);
    //   }
    //   System.Console.WriteLine(" from " + OrderLocation.LocationId + "\n Total Price: $" + TotalPrice);
    // }

    public Order(){
        Pizzas = new List<Pizza>();
    }


  }
}