using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemoS9.Models;
namespace MVCDemoS9.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            List<PersonModel> models = new List<PersonModel>();
            models.Add(new PersonModel { Id=1, Name ="Profe", Description = "ABc", FirstName = "Autor" });
            return View(models);
        }

        // GET: People/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: People/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: People/Create
        [HttpPost]
        public ActionResult Create(PersonModel model)
        {
            try
            {
                // TODO: Add insert logic here El modelo es como los paquetes de entrega, la crretera sonlos metodos HTTP
                // CLiente se comunica por Post 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: People/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: People/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: People/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: People/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
