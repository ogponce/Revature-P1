using PizzaBox.Domain.Models;
using Xunit;

namespace PizzaBox.Tests
{
  public class UserTest
  {
    [Fact]
    public void Test_User()
    {
    //Given
    User u = new User("Gary","Garfield");
    //When
    var e1 = "Gary";
    var e2 = "Garfield";
    
    //Then
    var a1 = u.Name.First;
    var a2 = u.Name.Last;

    Assert.True(e1.CompareTo(a1)==0);
    Assert.True(e2.CompareTo(a2)==0);

    }


  }
}
