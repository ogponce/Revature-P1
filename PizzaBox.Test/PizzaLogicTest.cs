// using Xunit;
// using PizzaBox.Domain.Models;

// namespace PizzaBox.Test
// {
//   public class PizzaLogicTest
//   {
//     [Fact]
//     public void Test_DefaultToppings(){
//         //arrange
//         var pizza = new Pizza();
//         string[] expected = {"Pepperoni", "Cheese"};
//         //act
//         var actual1 = pizza.Toppings[0];
//         var actual2 = pizza.Toppings[1];

//         System.Console.WriteLine("actual1");
//         System.Console.WriteLine(expected[0]);
        
//         int s = string.Compare(actual1, expected[0]);

//         //assert
//         Assert.True(s < 0);
//     }
     
//     // [Fact]
//     // public void Test_AddToppings(){
//     //     var pizza = new Pizza() {Toppings = {"Ham", "Sausage", "Cheese"}};
//     //     string[] expected = {"Ham", "Sausage", "Cheese"};
//     //     //act
//     //     var actual = pizza.Toppings;
//     //     //assert
//     //     Assert.True(actual == expected);
//     // }
//     [Fact]
//     public void Test_DefaultCrust(){
//         //arrange
//         var pizza = new Pizza();
//         var expected = "Traditional";
//         //act
//         var actual = pizza.Crust;
//         //assert
//         Assert.True(actual == expected);
//      }
//     [Fact] 
//     public void Test_Crust(){
//        //arrange
//         var pizza = new Pizza() {Crust = "Thin"};
//         var expected = "Thin";
//         //act
//         var actual = pizza.Crust;
//         //assert
//         Assert.True(actual == expected);
//      }
//     [Fact]
//     public void Test_DefaultSize(){
//        //arrange
//         var pizza = new Pizza(1,null,1,1);
//         var expected = "Small";
//         //act
//         var actual = pizza.pizzaSize.SizeName;
//         //assert
        
//         Assert.True(string.Compare(actual,expected) == 0);
//     }
//     [Fact]
//     public void Test_Size(){
//        //arrange
//         var pizza = new Pizza() {Size = "Large"};
//         var expected = "Large";
//         //act
//         var actual = pizza.Size;
//         //assert
//         Assert.True(actual == expected);
//      }
//     [Fact]
//     public void Test_TotalCost(){
//         //arrange
//         var pizza = new Pizza() {Size = "Large"};
//         double expected = 10;
//         //act
//         var actual = pizza.Cost();
//         //assert
//         Assert.True(actual == expected);        
//     }
//   }
// }