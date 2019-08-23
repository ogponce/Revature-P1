using System;
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Recipes;

namespace PizzaBox.Client
{
    public class PizzaMain
    {
      public static List<User> u = new List<User>();

      public static List<Location> l = new List<Location>();
        static void Main(string[] args)
        {
            makeLocation();
            displayLocations();
            makeUser();
            makeNewYork();
            makeInventory();
            //EatPizza();
        }

        public static void makeNewYork()
        {
          var ny = new NewYork();
          var newyork = ny.Make();
          newyork.Size.Name = "Small";
          System.Console.WriteLine("Price of New York Pizza is: $" + newyork.TotalPrice);
        }

        public void makeChicago()
        {
          var chi = new NewYork();
          var chicago = chi.Make();
          chicago.Size.Name = "Small";
          System.Console.WriteLine(chicago.TotalPrice);
        }

        public static void makeUser()
        {
          Location loc = l[0];
          User u1 = new User("Iron","Man");
          User u2 = new User("Spider", "Man");
          loc.Users.Add(u1);
          loc.Users.Add(u2);
          loc.printUsers();
        }
        
        public static void makeLocation(){
          l = new List<Location>
          {
            new Location("101 Abcde Street", "Arlington", "Texas"),
            new Location("UTA Street","Arlington","Texas"),
            new Location("Alameda Street","Los Angeles","California"),
            new Location("Twin Falls Street","Irving","Texas"),
            new Location("Airport Fwy Street","Dallas","Texas"),
            new Location("Fourth Street","Houston","Texas")
          };
        }

        public static void displayLocations(){
          System.Console.WriteLine("\nHere is a list of our locations: ");
          foreach (var v in l)
          {
            System.Console.WriteLine("\t" + v.address.Street + ", "+ v.address.City+", " + v.address.StateProvince);
          }
        }

        public void makeOrder()
        {
          Order o = new Order();
          List<string> t = new List<string>{"Pepperoni", "Cheese", "Bacon"};
          o.Pizzas = new List<APizza>
          {
            new Custom().Make("Small", "Stuffed",t),
            // new NewYork(), new Chicago(),
            // new California()
          };

        }

        public static void EatPizza()
        {
          var l1 = new Location("111 A St", "Arl", "TX");
          var o = l1.MakeOrder();
          List<string> t = new List<string>{"Pepperoni", "Cheese", "Bacon"};
          //o.Pizzas.Add();
          var p = new Custom().Make("Small","Thin",t);
          

          l1.TakeOrder(o,p);
          foreach(var ol in l1.Orders){
            foreach(var pi in l1.Orders){
              System.Console.WriteLine(pi);
            }
          }
        }

        public static void makeInventory()
        {
          l[0].Inventory = new Dictionary<string, int>();
          l[0].Inventory.Add("Small Dough",50);
          l[0].Inventory.Add("Medium Dough",50);
          l[0].Inventory.Add("Large Dough",50);
          l[0].Inventory.Add("Thin Crust",50);
          l[0].Inventory.Add("Stuffed Crust",50);
          l[0].Inventory.Add("Traditional Crust",50);
          l[0].Inventory.Add("Deep Dish Crust",50);
          l[0].Inventory.Add("Pepperonis",500);
          l[0].Inventory.Add("Cheese (per Pizza)",50);
          l[0].Inventory.Add("Bacon",5000);
          l[0].Inventory.Add("Mushrooms",500);
          l[0].printInventory();

        }


    }
}
