using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaBox.Domain.Models
{
  public class User
  {
    //public Name Name{get;set;}
    [NotMapped]
    public User Current {get;set;}

    [Required]
    public string FirstName { get; set; }
    public string LastName {get;set;}
    public string Street {get;set;}
    public string City {get;set;}
    public string State {get;set;}

    public int UserId {get;set;}
    [Required]
    public string Username {get;set;}
    public string Password {get;set;}
    
    [NotMapped]
    public Account Account {get;set;}
    //public Address Address {get;set;}
    public List<Order> UserOrderHistory{get;set;}
    // public List<Location> Loc {get;set;}

    // public void favoriteLocation()
    // {
    //   int i = Orders.LastIndexOf(new Order());
    //   Latest = Orders[i].l; 
    // }

    // public void selectLocation()
    // {
    //   System.Console.WriteLine("You may choose from the following locations: ");
    //   foreach(var v in Loc){
    //     System.Console.WriteLine(v);
    //   }

    //   //user somehow selects location

    //   if(Latest.address.City.CompareTo(checklocation.address.City) != 0)
    //   {
    //     checklocation.MakeOrder();
    //   }
    // }

    public override string ToString()
    {
      return $"{FirstName}, {LastName}, \n{Street}, {City}, {State}";
    }

    // public void viewHistory()
    // {
    //   int j = 1;
    //   foreach(var v in Orders)
    //   {
    //     System.Console.WriteLine(j + ". " + Orders[j]);
    //     j++;
    //   }
    // }

    // public User(string f, string l, string st, string c, string state)
    // {
    //   Name = new Name();
    //   Name.First = f;
    //   Name.Last = l;
    //   Address = new Address();
    //   Address.Street = st;
    //   Address.City = c;
    //   Address.StateProvince = state;
    // }

    public User(){
      Account Account = new Account();
      Account.Username = Username;
      Account.Password = Password;
      Account.AccountId= UserId;
    }

    

  }
}