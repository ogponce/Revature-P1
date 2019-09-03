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

      public static List<Location> ListofLocations = new List<Location>();
        static void Main(string[] args)
        {
            // Menu m = new Menu();
            // m.Start();
            // makeLocation();
            // displayLocations();
            // //makeChicago();
            // EatPizza();

            // makeInventory();
            // makeUser();
            takeNewOrder();
        }

        // public static void makeNewYork()
        // {
        //   var ny = new NewYork();
        //   var newyork = ny.Make();
        //   System.Console.WriteLine("Price of New York Pizza is: $" + newyork.TotalPrice);
        // }

        // public static void makeChicago()
        // {
        //   var c = new Custom();
        //   List<string> top = new List<string>{"Sauce","Cheese"};
        //   var custom = c.Make("","", top);
        //   System.Console.WriteLine("Total will be: " + c.TotalPrice);
        // }

        // public static void makeUser()
        // {
        //   Location loc = ListofLocations[0];
          
        //   //readline inputs for u1
        //   //User u1 = new User("Iron","Man","111 A Street", "New York City", "New York");
        //   User u1 = new User("Iron","Man","111 A Street", "New York City", "New York");
        //   loc.Users.Add(u1);
        //   loc.printUsers();
        // }
        
        public static void makeLocation(){
          // ListofLocations = new List<Location>
          // {
          //   new Location("101 Abcde Street", "Arlington", "Texas"),
          //   new Location("749 UTA Street","Arlington","Texas"),
          //   new Location("1000 Alameda Street","Los Angeles","California"),
          //   new Location("1636 Twin Falls Street","Irving","Texas"),
          //   new Location("1234 Airport Fwy Street","Dallas","Texas"),
          //   new Location("5435 Fourth Street","Houston","Texas")
          // };
          // Location create = new Location("","","");
          // create.loc = new List<Location>();
          // create.loc= ListofLocations;
        }

        public static void displayLocations(){
          System.Console.WriteLine("\nHere is a list of our locations: ");
          foreach (var v in ListofLocations)
          {
            System.Console.WriteLine("\t" + v.Street + ", "+ v.City+", " + v.State);
          }
        }

        public static Order takeNewOrder()
        {
          Order o = new Order();
          List<string> t = new List<string>{"Pepperoni"};
          o.Pizzas = new List<Pizza>
          {
            new Custom().Make("Small", "Stuffed",t),
            new NewYork().Make(), new Chicago().Make(),
            new California().Make()
          };
          int j = 0;
          foreach(var pi in o.Pizzas){
            System.Console.WriteLine("You have added a " + pi.Size.Name + " "+ pi.Name+ " pizza with a " + pi.Crust.Name + " crust. \t\t $" + pi.TotalPrice);
            
            for(int i = 0; i< o.Pizzas[j].Toppings.Count;i++){
              System.Console.WriteLine("\tPizza comes with: " + o.Pizzas[j].Toppings[i].Name);
            }
            j++;
            // System.Console.ReadLine("Would you like to add anything else?");
          }

          return o;

        }

        public static void EatPizza()
        {
          var list = ListofLocations[0];
          var order = list.MakeOrder();
          List<string> t = new List<string>{"Pepperoni", "Cheese", "Bacon"};
          var pizza = new Custom().Make("Small","Thin",t);
          
          list.TakeOrder(order,pizza);
          foreach(var v in list.Orders){
            foreach(var i in order.Pizzas){
              System.Console.WriteLine("You have added a " + i.Size.Name + " "+ i.Name+ " pizza with a " + i.Crust.Name + " crust.");
              // System.Console.ReadLine("Would you like to add anything else?");
            }
          }
        }

        // public static void makeInventory()
        // {
        //   ListofLocations[0].Inventory = new Dictionary<string, int>();
        //   ListofLocations[0].Inventory.Add("Small Dough",50);
        //   ListofLocations[0].Inventory.Add("Medium Dough",50);
        //   ListofLocations[0].Inventory.Add("Large Dough",50);
        //   ListofLocations[0].Inventory.Add("Thin Crust",50);
        //   ListofLocations[0].Inventory.Add("Stuffed Crust",50);
        //   ListofLocations[0].Inventory.Add("Traditional Crust",50);
        //   ListofLocations[0].Inventory.Add("Deep Dish Crust",50);
        //   ListofLocations[0].Inventory.Add("Pepperonis",500);
        //   ListofLocations[0].Inventory.Add("Cheese (per Pizza)",50);
        //   ListofLocations[0].Inventory.Add("Bacon",5000);
        //   ListofLocations[0].Inventory.Add("Mushrooms",500);
        //   ListofLocations[0].printInventory();
        // }


    }
}