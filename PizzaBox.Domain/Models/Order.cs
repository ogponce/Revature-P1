using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Order 
  {
    public Location l {get;set;}
    public User u {get;set;}
    public List<APizza> Pizzas {get;set;}
    public decimal TotalPrice {get; set;}

    public void calculate(){
      
      
      for(int i = 0; i < Pizzas.Capacity; i++)
      {
        if(Pizzas[i].Name.Length >= 1){
          TotalPrice += Pizzas[i].TotalPrice;
        }

        // TotalPrice += Pizzas[i].Crust.Price;
        // TotalPrice += Pizzas[i].Size.Price;
       // TotalPrice += Pizzas[i].Toppings[i].Price;
      }     
    }

    public void Print(){
      System.Console.WriteLine("Name: " + u.Name + "\nOrdered: ");
      foreach(var v in Pizzas)
      {
        System.Console.WriteLine("\t" + v);
      }
      System.Console.WriteLine(" from " + l + "\n Total Price: $" + TotalPrice);
    }

    public Order(){
        Pizzas = new List<APizza>();
    }


  }
}