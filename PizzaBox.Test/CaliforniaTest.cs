using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Recipes;
using Xunit;

namespace PizzaBox.Tests
{
  public class CaliforniaTest
  {

[Fact]
    public void Test_Crust(){
    //Arrange
    California c = new California();
    var truepizza = c.Make();    
    var expected = "Stuffed";
    //Act
    var act = truepizza.Crust.Name;
    
    // System.Console.WriteLine(act + " "+expected );
    //Assert
    Assert.True(expected.CompareTo(act) == 0);
    }

    [Fact]
    public void Test_DefaultSize(){
    //Arrange
    California c = new California();
    var truepizza = c.Make();
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
    California c = new California();
    var truepizza = c.Make();
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
    California c = new California();
    var truepizza = c.Make(); 
    var e1 = "Pepperoni";
    //Act
    var a1 = truepizza.Toppings[0].Name;
    //Assert
    Assert.True(e1.CompareTo(a1) == 0);
    }
  }
}

