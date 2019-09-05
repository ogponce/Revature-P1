using Microsoft.AspNetCore.Mvc;
using PizzaBox.Domain.Models;
using PizzaBox.Data;
using System.Linq;
using System.Collections.Generic;

namespace PizzaBox.MvcClient.Controllers
{
    
    public class MenuController: Controller
    {
      private PizzaBoxDbContext _db = new PizzaBoxDbContext();
      public static Order Current {get;set;}

      public IActionResult Create()
      {
        return View();
      }

      public IActionResult CreateIngredient()
      {
        return View();
      }

      public IActionResult CreateSize()
      {
        return View();
      }

      [HttpPost]
      public IActionResult CreateSize(Size s)
      {
        if(ModelState.IsValid)
        {
        try{
          _db.Sizes.Add(s);
          _db.SaveChanges();  
        }
        catch
        {
          return RedirectToAction("WrongInput","Pizza");
        }
        
        return RedirectToAction("Index", "Pizza");
      }
        return View();
      }

      public IActionResult CreateCrust()
      {
        return View();
      }
      [HttpPost]

      public IActionResult CreateCrust(Crust c)
      {
        if(ModelState.IsValid)
        {
          try{
              _db.Crusts.Add(c);
              _db.SaveChanges();  
          }
          catch
          {
            return RedirectToAction("WrongInput","Pizza");
          }
          
          return RedirectToAction("Index","Pizza");
        }
          return View();      
      }
      public IActionResult CreateTopping()
      {
        return View();
      }
      [HttpPost]
      public IActionResult CreateTopping(Topping t)
      {
        if(ModelState.IsValid)
        {
          try{
              _db.ToppingsTable.Add(t);
              _db.SaveChanges();  
          }
          catch
          {
            return RedirectToAction("WrongInput","Pizza");
          }
          
          return RedirectToAction("Index","Pizza");
        }
          return View();      
      }
      
      public IActionResult CreateLocation()
      {
        return View();
      }

      [HttpPost]
      public IActionResult CreateLocation(Location lo)
      {
        if(ModelState.IsValid)
        {
          try{
              _db.Locations.Add(lo);
              _db.SaveChanges();  
          }
          catch
          {
            return RedirectToAction("WrongInput","Pizza");
          }
          
          return RedirectToAction("Index","Pizza");
        }
          return View();      
      }
      
      public IActionResult OrderMenu()
      {        
        Pizza p = new Pizza();
        return View(p);
      }

      [HttpPost]
      public IActionResult OrderMenu(Pizza p)
      {
        if(p.Name == "Custom"){return RedirectToAction("ChooseToppings");}

        else {return RedirectToAction("AddMore","Menu",Current);}
      }

      public IActionResult ChooseLocation(Order o)
      {
        List<Location> nearby = new List<Location>();
        foreach (var l in _db.Locations)
        {
          if(Current.user.City == l.City && Current.user.State == l.State){
            nearby.Add(l);
          }
        }
        return View(nearby);
      }

      [HttpPost]
      public IActionResult ChooseLocation(Location lo)
      {
        Current.OrderLocation = lo;
        return RedirectToAction("OrderMenu");
      }

      public IActionResult Login()
    {
      return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Login(User cur)
    {
        Current = new Order();
        Current.user = new User();
        foreach (var u in _db.Users)
        {
          if(u.Username == cur.Username){
             if(u.Password == cur.Password){
              Current.user.Username = cur.Username;
              Current.user.FirstName = u.FirstName;
              Current.user.LastName = u.LastName;
              Current.user.Street = u.Street;
              Current.user.City = u.City;
              Current.user.State = u.State;
              Current.user.UserId = u.UserId;


              return RedirectToAction("ChooseLocation","Menu", Current);
             }
          }
        }
        
        return View();
    }

    public IActionResult ChooseToppings()
    {
      return View();
    }
    [HttpPost]
    public IActionResult ChooseToppings(List<Topping> t)
    {
      return View();
    }

    public IActionResult DisplayOrder()
    {
      return View(Current);
    }

    public IActionResult AddMore()
    {
      return View(Current);
    }
    public IActionResult ConfirmOrder()
    {
      return View();
    }


    }

    
}