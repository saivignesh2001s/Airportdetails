using Airportdetails.Models;
using Airportdetails.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Dynamic;
using System.Linq.Expressions;

namespace Airportdetails.Controllers
{
    public class AirportController : Controller
    {
        private readonly IMethods context;
        // GET: AirportController
        public AirportController(IMethods context) {
              this.context = context;
        
        }
        public ActionResult Index()
        {
            List<city> fs = context.GetAllCities();
            return View(fs);
        }
       
        
        // GET: AirportController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AirportController/Create
        public ActionResult Create()
        {
            
                Dtoclass m = new Dtoclass();
                var titles = context.GetAllCities();
                List<string> k = new List<string>();
                foreach (var i in titles)
                {
                    k.Add(i.NAME);
                }
                m.cities = k;
               
                return View(m);
          
        }
        
        // GET: AirportController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AirportController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AirportController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AirportController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
