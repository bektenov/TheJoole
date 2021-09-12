using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Joole_DataAccess;
using Joole_Service;

namespace Joole_Project.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        public ActionResult Search()

        {
            JooleDBEntities1 db = new JooleDBEntities1();
            var ss = new SearchService(db);

            List<Category> c = ss.getCategory.ToList();

            ViewBag.data = c; 

            return View();
        }
    }
}




/*WorkerBusinessLayer workerBusinessLayer = new WorkerBusinessLayer();
List<Worker> workers = workerBusinessLayer.Workers.ToList();


return View(workers);*/




/* JooleDBEntities1 db = new JooleDBEntities1();
           List<Category> cag = db.Categories.ToList();
           ViewBag.message = cag;
           return View();*/