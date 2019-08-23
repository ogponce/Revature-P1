namespace PizzaBox.Domain.Abstracts
{
  public abstract class AIngredient
  {
    public string Name { get; set; }

    public decimal Price { get; set;}

    public AIngredient(string name){
      Name = name;
    }
  }
}