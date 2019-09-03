
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaBox.Domain.Models
{
  [NotMapped]
    public class CurrentUser
    {
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
      public List<Order> UserOrderHistory{get;set;}

      public override string ToString()
      {
        return $"{FirstName}, {LastName}, \n{Street}, {City}, {State}";
      }
    }
}