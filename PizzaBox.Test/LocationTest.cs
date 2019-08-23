using PizzaBox.Domain.Models;
using Xunit;

namespace PizzaBox.Tests
{
  public class LocationTest
  {
    [Fact]
    public void Test_Location()
    {
    //Given
    Location l = new Location("101 Abc st", "Arl", "Texas");
    //When
    var e1 = "101 Abc st";
    var e2 = "Arl";
    var e3 = "Texas";
    
    //Then
    var a1 = l.address.Street;
    var a2 = l.address.City;
    var a3 = l.address.StateProvince;

    Assert.True(e1.CompareTo(a1)==0);
    Assert.True(e2.CompareTo(a2)==0);
    Assert.True(e3.CompareTo(a3)==0);

    }


  }
}
