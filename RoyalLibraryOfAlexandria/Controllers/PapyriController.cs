using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RoyalLibraryOfAlexandria.Models;
using RoyalLibraryOfAlexandria.Repositories;

namespace RoyalLibraryOfAlexandria.Controllers
{
    public class PapyriController : Controller
    {
        private PapyrusRepository papyrusRepository;


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ActuallyCreate(Papyrus papyrus)
        {
            if (!ModelState.IsValid)
            {
                return View("Create");
            }

            papyrusRepository = new PapyrusRepository();
            papyrusRepository.Create(papyrus);
            return RedirectToAction("Index");
        }

        public ActionResult Edit()
        {
            return View();
        }

        public ActionResult Details()
        {
            throw new NotImplementedException();
        }

        public ActionResult Delete()
        {
            throw new NotImplementedException();
        }
    }

}