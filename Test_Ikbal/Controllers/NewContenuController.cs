using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test_Ikbal.Controllers
{
    public class NewContenuController : Controller
    {
        // GET: NewContenu
        public ActionResult Index()
        {
            return View();
            //Recuperation des  donnée du modele NEWScontenu et les envoyé a la vue pour  faire laffichage 
        }
        //
        // POST: /Home/Create

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                //Faire l'appel  a la base  de donner  pour  ajouter un nouveau elemet newsContenu 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Home/Edit/5

        public ActionResult Edit(int id)
        {
            // recuperer un contenu  oar son id et l'envoyé au formulair  a la vue Edit 
            return View();
        }

        //
        // POST: /Home/Edit/5

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Edit(int id, FormCollection collection)
        {
            //
            // mise  a jour 
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
    }
}