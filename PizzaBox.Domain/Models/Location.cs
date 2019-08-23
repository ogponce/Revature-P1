using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Location 
  {
    public Address address {get;set;}
    public int StoreID {get;set;}
    public Dictionary<string, int> Inventory {get;set;}

    public List<Order> Orders {get;set;}
    public List<APizza> PizzasOrdered {get;set;}
    public List<User> Users {get;set;}

    public Dictionary<int, Order> History{get;set;} 

    public Order MakeOrder()
    {
      User u1 = new User("Bat","Man");
      u1.Account.Username = "Batman1";
      u1.Account.Password = "Password12345";
      if (u1.Account.Username.CompareTo("") != 0){
        return new Order
      {
        Pizzas = new List<APizza>()
      };
      }
      else {
        return new Order();
      }
      
    }

    public void TakeOrder(Order o, APizza a)
    {
      o.Pizzas.Add(a);
      Orders.Add(o); 
    }

    public void printUsers()
    {
      System.Console.WriteLine("\nHere is a list of our users for the first location: ");

      foreach(var v in Users){
        System.Console.WriteLine("\t" + v.Name.First + " " + v.Name.Last);
      }
    }
    
    
    public Location(string s,string c,string sp)
    {
      address = new Address();
      address.Street = s;
      address.City = c;
      address.StateProvince = sp;
      Users = new List<User>();
    }

    public void printOrders()
    {
      System.Console.WriteLine("Here is a list of our users for the first location: ");
      foreach(var v in PizzasOrdered){
        System.Console.WriteLine("\tYou ordered a " + v.Name + " Style Pizza");
        System.Console.WriteLine("It is a size " + v.Size.Name + " pizza that has a " + v.Crust.Name + " crust, and it has the following toppings: ");
        for (int i = 0; i < v.Toppings.Capacity; i++)
        {
           System.Console.WriteLine("\n\t" + v.Toppings[i].Name);
        }
      }
    }

    public void printSales()
    {
      //How many pizzas were sold in total per location
    }

    public void printInventory()
    {
      System.Console.WriteLine("Inventory List:");
      foreach(KeyValuePair<string,int> kvp in Inventory)
      {
        System.Console.WriteLine("\tThis location has " + kvp.Value + " " + kvp.Key + "(s)");
      }
    }


  }
}