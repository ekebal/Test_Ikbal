using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test_Ikbal.Database;
using Test_Ikbal.Models;

namespace Test_Ikbal.Controllers
{
    public class NewCategoriController : Controller
    {
        DbNewsCategorie connectDb;
        // GET: NewCategori
        public ActionResult Index()
        {
            return View();
        }
        public void  addCategorie()
        {

        }
        public ActionResult getListCategories()
        {
            connectDb = new DbNewsCategorie();

            var listSousCategories = connectDb.getListCategories();
            String html = "<ul>";
            foreach(NewsCategorie itemCategorie in listSousCategories)
            {
                html += '<li>' + itemCategorie.libelleCategorie + '</li>';
                if(itemCategorie.listSousCategorie.hasChilds() )
                    html += '<ul>' + " " + '</ul>'; //Contenu des enfants
            }
            html += "</ul>";
            Response.Write(html);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}