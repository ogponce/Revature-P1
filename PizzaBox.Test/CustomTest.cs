using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Recipes;
using Xunit;

namespace PizzaBox.Tests
{
  public class CustomTest
  {

[Fact]
    public void Test_Crust(){
    //Arrange
    List<string> t = new List<string>{"", ""};
    Custom c = new Custom();
    var truepizza = c.Make("Small","Deep Dish",t);    
    var expected = "Deep Dish";
    //Act
    var act = truepizza.Crust.Name;
    
    System.Console.WriteLine(act + " "+expected );
    //Assert
    Assert.True(expected.CompareTo(act) == 0);
    }

    [Fact]
    public void Test_DefaultSize(){
    //Arrange
    List<string> t = new List<string>{"", ""};
    Custom c = new Custom();
    var truepizza = c.Make("","Deep Dish",t); 
    var expected = "Medium";
    //Act
    var act = truepizza.Size.Name;
    System.Console.WriteLine(act + " "+expected );
    //Assert
    
    Assert.True(expected.CompareTo(act) == 0);
    }

    [Fact]
    public void Test_Price(){
    //Arrange
    Custom c = new Custom();
    List<string> t = new List<string>{"Pepperoni", "Cheese"};
    var truepizza = c.Make("Small","Thin",t);
    var expected = 5;
    //Act
    //truepizza.calculatePrice();
    var act = c.TotalPrice;
    System.Console.WriteLine(act + " "+expected );
    //Assert
    Assert.True(expected == act);
    }

    [Fact]
    public void Test_Toppings(){
    //Arrange
    List<string> t = new List<string>{"Pepperoni", "Cheese"};
    Custom c = new Custom();
    var truepizza = c.Make("","Deep Dish",t); 
    var e1 = "Pepperoni";
    var e2 = "Cheese";
    //Act
    var a1 = truepizza.Toppings[0].Name;
    var a2 = truepizza.Toppings[1].Name;
    System.Console.WriteLine(a1 + " "+e1 );
    //Assert
    Assert.True(e1.CompareTo(a1) == 0);
    Assert.True(e2.CompareTo(a2) == 0);

    }
  }
}

