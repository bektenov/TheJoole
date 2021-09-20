using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Joole_Service;
using Joole_DataAccess;
using Joole_Repository;
using JooleProject.Models;
using JooleDBEntities1 = Joole_Repository.JooleDBEntities1;

namespace Joole_Project.Controllers
{
    public class SearchController : Controller

    {
        private readonly ISearchService ss;
        //private JooleDBEntities1 db = new JooleDBEntities1();
     /*   private IRepository<Category> CategoryRepo;


        private IRepository<SubCategory> SubCategoryRepo;

        private IRepository<Product> ProductRepo;
*/




        // GET: Search
        public ActionResult Search()
        {

            // var help = new SearchService(db);


            //List<Category> temp = new List<Category>();



            using (Joole_DataAccess.JooleDBEntities1 db = new Joole_DataAccess.JooleDBEntities1())
            {

                var sus = new SearchService( db);

                //whatever is in last get's displayed in selectlist on view 
                ViewBag.Category_Name = new SelectList(sus.GetAllCategories(), "Category_Id", "Category_Name");
                ViewBag.Product_Name = new SelectList(sus.GetAllProducts(), "Product_Id", "Product_Name");




                return View();
            }

        }

    

        [HttpPost]
        public ActionResult AdvanceSearch(SearchVM item)

        {
            using (Joole_DataAccess.JooleDBEntities1 db = new Joole_DataAccess.JooleDBEntities1())


            {
                var sus = new SearchService( db);
                /*         var s = from Category in sus.GetAllCategories()
                                 from Product in sus.GetAllProducts()
                                 from SubCategory in sus.GetAllSubCategory()
                                 join cat in sus.GetAllCategories() on SubCategory.Category_Id equals cat.Category_Id
                                 where item.Product_Name == Product.Product_Name && item.Category_Id == cat.Category_Id
                                 select Product;
                         s = s.ToList();*/

                //I have this commented bc our product model is broken and this gives me error 
                //we pass this to productDetails and display our product 

              //  return View("ProductSummary", s);


                return View("ProductSummary");

            

            }

        }
    }
}










