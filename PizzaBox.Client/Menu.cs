using System;
using System.Collections.Generic;
using PizzaBox.Data.Entities;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Recipes;

namespace PizzaBox.Client
{
  public class Menu
  {
    private static PizzaWorldDBContext _db = new PizzaWorldDBContext();


    public void Start()
    {
      System.Console.WriteLine("\n\n\nChoose from the following options: ");
      System.Console.WriteLine("\t1. Log in");
      System.Console.WriteLine("\t2. Register");
      System.Console.WriteLine("\t3. View Menu");
      System.Console.WriteLine("\t4. View Locations Near You");
      System.Console.WriteLine("\t5. Exit\n");
      StartCases();
    }

    public void StartCases()
    {
      string input = Console.ReadLine();
      int i = 0;
      try
      {
        i = Int32.Parse(input);
         switch(i)
      {
        case 1: 
          Login();
          break;
        case 2:
          Register();
          break;
        case 3: 
          ViewFoodMenu();
          break;
        case 4: 
          ViewLocations();
          break;
        case 5:
          Environment.ExitCode = 0;
          break;
        default:
          System.Console.WriteLine("Wrong Input");
          StartCases();
          break;
      }
      }
      catch
      {
        System.Console.WriteLine("Wrong Input! Try Again :)");
        Start();
      }
      
    }

    public void Login()
    {
      System.Console.WriteLine("Enter Username: ");
      string un = Console.ReadLine();
      System.Console.WriteLine("Enter Password: ");
      string pass = Console.ReadLine();

      //User u = new User();
      //check if user is in the database 
      //if(){}else{}


    }

    public void Logout()
    {
      //Log user out
    }

    public void Register()
    {
      System.Console.WriteLine("Enter User's First Name: ");
      string first = Console.ReadLine();
      System.Console.WriteLine("Enter User's Last Name: ");
      string last = Console.ReadLine();
      System.Console.WriteLine("Enter User's Street Address: ");
      string street = Console.ReadLine();
      System.Console.WriteLine("Enter User's City Name: ");
      string city = Console.ReadLine();System.Console.WriteLine("Enter User's First Name: ");
      System.Console.WriteLine("Enter User's State/Province Name: ");
      string state = Console.ReadLine();

      User u = new User(first,last,street,city,state);
      
      //Add to list of users
      System.Console.WriteLine("Congrats you're in! Here are the locations closest to you");
      ViewNearbyLocations(city,state);      
    }

    public void ViewFoodMenu()
    {
      System.Console.WriteLine("Here is our current menu: ");
      Custom cust = new Custom();
      NewYork ny = new NewYork();
      var n = ny.Make();
      California cali = new California();
      var ca = cali.Make();
      Chicago chi = new Chicago();
      var ch = chi.Make();
      System.Console.WriteLine("\nCalifornia Pizza");
      System.Console.WriteLine("Preset comes as a " + ca.Size.Name + " Pizza with " + ca.Crust.Name + " crust and the following toppings: ");
      PrintToppings(ca.Toppings);
      System.Console.WriteLine("\nChicago Pizza");
      System.Console.WriteLine("Preset comes as a " + ch.Size.Name + " Pizza with " + ch.Crust.Name + " crust and the following toppings: ");
      PrintToppings(ch.Toppings);

      System.Console.WriteLine("\nCustom Pizza");
      System.Console.WriteLine("Comes in any of the following sizes: \n\t[Small], [Medium], [Large]");
      System.Console.WriteLine("Any of the following crusts: \n\t[Thin], [Traditional], [Deep Dish], [Stuffed (+$2.00)]");
      System.Console.WriteLine("And any of the following toppings: \n\t[Pepperoni], [Cheese], [Sauce], [Mushrooms], [Pineapple], \n\t[Sausage], [Bacon], [Ham], [Olives]");

      System.Console.WriteLine("\nNew York Pizza");
      System.Console.WriteLine("Preset comes as a " + n.Size.Name + " Pizza with " + n.Crust.Name + " crust and the following toppings: ");
      PrintToppings(n.Toppings);
      
      ViewFoodMenuCases();
    }

    public void PrintToppings(List<Topping> t)
    {
      foreach(var v in t)
      {
        System.Console.WriteLine("\t" + v.Name);
      }
    }

    public void ViewFoodMenuCases()
    {
      System.Console.WriteLine("Would you like to:");
      System.Console.WriteLine("1. Log in");
      System.Console.WriteLine("2. Register");
      System.Console.WriteLine("3. Exit");
      string input = Console.ReadLine();
      int i = 0;
      try
      {
        i = Int32.Parse(input);
         switch(i)
      {
        case 1: 
          Login();
          break;
        case 2:
          Register();
          break;
        case 3: 
          Environment.ExitCode = 0;
          break;
        default:
          System.Console.WriteLine("Wrong Input");
          ViewFoodMenuCases();
          break;
      }
      }
      catch
      {
        System.Console.WriteLine("Wrong Input! Try Again :)");
        Start();
      }
      

    }

    public void ViewNearbyLocations(string c, string s)
    {
      List<Location> nearby = new List<Location>();
      Location l = new Location();
      System.Console.WriteLine("Here are our two locations that are closest to you: ");
      foreach(var v in l.loc)
      {
        if(v.address.City.CompareTo(c)==0 && v.address.StateProvince.CompareTo(s)==0){
          nearby.Add(v);
          System.Console.WriteLine(v.address.Street + ", " + v.address.City + ", " + v.address.StateProvince);
        }
      }

      ChooseNearby(nearby);

    }

    public void ChooseNearby(List<Location> l)
    {
      System.Console.WriteLine("Which of these locations do you want to order from?");
      string input = Console.ReadLine();
      int i = 0;
      bool b = true;
      try
      {
        i = Int32.Parse(input);
      while(b)
      {
        if(i < l.Count && i>=0)
        {
          //Add location to order
          b = false;
          break;
        }
        b = false;
      }
      }
      catch
      {
        System.Console.WriteLine("Wrong Input! Try Again :)");
        Start();
      }
      
    }

    public void ViewLocations()
    {

    }

    public void NewOrder()
    {

    }

    public void ViewStoreHistory()
    {
      //Look through database for order history
    }

    public void ViewUserOrderHistory()
    {
      //Look throught database for user order history
    }

    public void ViewStoreSales()
    {
      //Look through database to see how many pizzas have been sold per store
    }


  }
}