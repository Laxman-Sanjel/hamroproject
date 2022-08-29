using Bca_New.Data;
using Bca_New.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Net;

namespace Bca_New.Controllers
{
    public class HomeController : Controller
    {
       
        private ApplicationDbContext? Context { get; set; }
        public HomeController(ApplicationDbContext context)
        {
            this.Context = context;
           
        }
        [HttpPost]
        public IActionResult Form1(Players p)
        {
            Context.Player.Add(p);
            Context.SaveChanges();
            return RedirectToAction("Index");
            return View(p);
        }
        [HttpPost]
       
        public IActionResult Edit(int id){
         var p=Context.Player.Find(id);
           return View(p);
        }

        [HttpGet]
     
        public IActionResult Updated(Players p)
        {
           Context.Player.Update(p);
            Context.SaveChanges();
           return RedirectToAction("Index");
            return View();
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(Context.Player.ToList());
        }
        public IActionResult Delete(int id)
        {
            var ToDelete = Context.Player.Find(id);
            Context.Player.Remove(ToDelete);
            Context.SaveChanges();
            return RedirectToAction("Index");
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}