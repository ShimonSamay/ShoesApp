using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SneakersShops.Models;

namespace SneakersShops.Controllers
{
    public class SneakersController : Controller
    {
        private List<Sneaker> sneakersList = new List<Sneaker>();

        public ActionResult getSneakerModel()
        {
            FillList();
            return View(sneakersList[0]);
        }

        public ActionResult getSneaker(int id)
        {
            FillList();
            ViewBag.sneaker = sneakersList.Find(shoe => shoe.Id == id);
            return View();
        }

        public ActionResult getSneakers()
        {
            FillList();
            return View(sneakersList);
        }

        public void FillList()
        {
            sneakersList.Add(new Sneaker(1, "nike", "jordan", 4000 , 42));
            sneakersList.Add(new Sneaker(2, "adidas", "x", 3000 , 44));
            sneakersList.Add(new Sneaker(3, "puma", "run", 8000 , 43));
            sneakersList.Add(new Sneaker(4, "reebok", "life", 2000 , 45));

        }


    }
}