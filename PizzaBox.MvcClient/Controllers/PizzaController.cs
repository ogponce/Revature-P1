using Microsoft.AspNetCore.Mvc;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Recipes;
using PizzaBox.Data;
using System.Linq;
using System.Collections.Generic;

namespace MvcWorld.Client.Controllers
{
  public class PizzaController: Controller
  {
    
    private PizzaBoxDbContext _db = new PizzaBoxDbContext();
    public Order Current {get;set;}

    public IActionResult Register()
    {
      return View();
    }
    
    [HttpPost]
    public IActionResult Register(User user)
    {
      
      if(ModelState.IsValid)
      {
        try{
            _db.Users.Add(user);
            _db.SaveChanges();  
        }
        catch
        {
          return RedirectToAction("WrongInput");
        }
        
        return RedirectToAction("Read");
      }
        return View();
    }

    public IActionResult WrongInput()
    {
      return View();
    }
    
    public ViewResult Read()
    {
      return View(_db.Users.ToList());
      //return View(_db.Accounts.ToList());

    }
    
    
    public IActionResult Index()
    {
      return View();
    }
    
    public IActionResult ManagerLogin()
    {
      return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult ManagerLogin(User user)
    {
        
        foreach (var u in _db.Users)
        {
          if(u.Username == user.Username && user.Username.Contains("Manager")){
            if (u.Password == user.Password)
            {
              return RedirectToAction("Create","Menu");
            }
          }
        }
       
        return View();
    }

    
    
    

    public IActionResult ViewMenu()
    {
      Pizza p = new Pizza();
      List<string> t = new List<string>{"Pepperoni","Cheese"};
      p.Pizzas = new List<Pizza>
        {new Chicago().Make(), new NewYork().Make(),
         new California().Make(),new Custom().Make("","",t)
        };
      
      foreach (var item in p.Pizzas)
      {
        _db.Pizzas.AddRange(item);
      }
      //_db.SaveChanges();
      return View(p);
    }

    public IActionResult ViewLocations()
    {
      Location location = new Location();
      location.Locations = new List<Location>
      {
        new Location{Street ="101 Abcde Street",City= "Arlington",State= "Texas"},
        new Location{Street ="121 UTA Street", City = "Arlington", State ="Texas"},
        new Location{Street ="1000 Alameda Street",City = "Los Angeles",State ="California"},
        new Location{Street="1212 Division Street",City="Fort Worth",State="Texas"},
        new Location{Street="5555 Airport Fwy Street",City="Dallas",State="Texas"},
        new Location{Street="123 Fourth Street",City="Houston",State="Texas"}
      }; 
      
// foreach (var item in location.Locations)
//       {
//         _db.Locations.Add(item);
//       }
//       _db.SaveChanges(); 

      return View(location);
    }
  }
}