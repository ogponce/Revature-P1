using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Recipes;
using Xunit;

namespace PizzaBox.Tests
{
  public class OrderTest
  {
    [Fact]
    public void Test_Calculate()
    {
    //Given
    List<Order> o = new List<Order>{new Order()};
    Order or = new Order();
    List<string> t = new List<string>{"Pepperoni", "Cheese", "Sausage"};
    List<Pizza> p = new List<Pizza>{new Chicago().Make(), new NewYork().Make()};
    or.Pizzas = p;
    //When
    decimal e1 = 14M;
    //Then
    decimal a1 = 0M;
    foreach(var v in or.Pizzas){
      a1 += v.TotalPrice;
    }
    System.Console.WriteLine(a1 + " " + e1);
    Assert.True(e1.CompareTo(a1)==0);
    }

    [Fact]
    public void Test_ListofOrders()
    {
    //Given
    List<Order> o = new List<Order>{new Order()};
    Order or = new Order();
    List<string> t = new List<string>{"Pepperoni", "Cheese", "Sausage"};
    List<Pizza> p = new List<Pizza>{new Chicago().Make(), new NewYork().Make()};
    or.Pizzas = p;
    //When
    var e1 = "Chicago";
    var e2 = "New York";
    //Then
    var a1 = or.Pizzas[0].Name;
    var a2 = or.Pizzas[1].Name;
    

    System.Console.WriteLine(e1+" "+a1);
    Assert.True(e1.CompareTo(a1)==0);
    Assert.True(e2.CompareTo(a2)==0);
    }

  }
}
