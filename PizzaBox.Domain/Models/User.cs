using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
  public class User
  {
    public Name Name{get;set;}

    public Account Account {get;set;}
    public List<Order> Orders{get;set;}
    public Location Latest {get;set;}
    public List<Location> Loc {get;set;}
    public Location checklocation {get;set;}

    public void favoriteLocation()
    {
      // int i = Orders.LastIndexOf(new Order());
      // Latest = Orders[i].l; 
    }

    public void selectLocation()
    {
      System.Console.WriteLine("You may choose from the following locations: ");
      foreach(var v in Loc){
        System.Console.WriteLine(v);
      }

      //user somehow selects location

      if(Latest.address.City.CompareTo(checklocation.address.City) != 0)
      {
        checklocation.MakeOrder();
      }
    }

    public void viewHistory()
    {
      int j = 1;
      foreach(var v in Orders)
      {
        System.Console.WriteLine(j + ". " + Orders[j]);
        j++;
      }
    }

    public User(string f, string l)
    {
      Name = new Name();
      Name.First = f;
      Name.Last = l;
    }

  }
}