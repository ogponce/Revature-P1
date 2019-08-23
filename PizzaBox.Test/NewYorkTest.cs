using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Recipes;
using Xunit;

namespace PizzaBox.Tests
{
  public class NewYorkTest
  {

[Fact]
    public void Test_Crust(){
    //Arrange
    NewYork ny = new NewYork();
    var truepizza = ny.Make();    
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
    NewYork ny = new NewYork();
    var truepizza = ny.Make();
    var expected = "Large";
    //Act
    var act = truepizza.Size.Name;
    //System.Console.WriteLine(act + " "+expected );
    //Assert
    
    Assert.True(expected.CompareTo(act) == 0);
    }

    [Fact]
    public void Test_Price(){
    //Arrange
    NewYork ny = new NewYork();
    var truepizza = ny.Make();
    var expected = 7;
    //Act
    var act = truepizza.TotalPrice;
    //System.Console.WriteLine(act + " "+expected );
    //Assert
    
    Assert.True(expected == act);
    }

    [Fact]
    public void Test_Toppings(){
    //Arrange
    NewYork ny = new NewYork();
    var truepizza = ny.Make(); 
    var e1 = "Mushrooms";
    //Act
    var a1 = truepizza.Toppings[3].Name;
    //Assert
    Assert.True(e1.CompareTo(a1) == 0);
    }
  }
}

