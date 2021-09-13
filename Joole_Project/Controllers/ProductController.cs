using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using System.Net;
using System.Net.Configuration;
using Joole_DataAccess;
using Joole_Project;
using Joole_Service;
using TheJooleProject.Models;

namespace Joole_Project.Controllers
{
    public class ProductController : Controller
    {
        private JooleDBEntities1 db = new JooleDBEntities1();
        private IProductService productService = new ProductService();
        //private ProductService productServiceNew = new ProductService();
        // GET: Products
        public ActionResult Index()
        {
            List<ProductDetailsVM> model = new List<ProductDetailsVM>();


            productService.GetProducts().ToList().ForEach(p =>
            {
                ProductDetailsVM vm = feedProductVM(p);
                model.Add(vm);
            });

            return View(model);
        }
        public ActionResult ProductDetails(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product p = productService.GetProduct(id.Value);

            if (p == null)
            {
                return HttpNotFound();
            }
            ProductDetailsVM model = feedProductVM(p);
            return View("ProductDetails", model);
        }
        [HttpGet]
        public ActionResult ProductsCompare(long? id1, long? id2, long? id3)
        {
            long?[] ids = { id1, id2, id3 };
            List<ProductDetailsVM> model = new List<ProductDetailsVM>();
            foreach (long? id in ids)
            {
                if (id != null && id.Value != -1)
                {
                    Product p = productService.GetProduct(id.Value);
                    ProductDetailsVM vm = feedProductVM(p);
                    model.Add(vm);
                }
            }
            ViewBag.Model = model;
            return View();
        }

        private ProductDetailsVM feedProductVM(Product p)
        {
            ProductDetailsVM pd = new ProductDetailsVM
            {
                ProductID = p.Product_Id,
                Series = p.Series,
                Model = p.Model,
                Product_Image = p.Product_Image,
                Model_Year = p.Model_Year,
                UseType = p.UseType,
                Application = p.Application,
                Mount = p.Mount,
                Accessories = p.Accessories,
                AirFlow = p.AirFlow,
                MinPower = p.MinPower,
                MaxPower = p.MaxPower,
                MinVolt = p.MinVolt,
                MaxVolt = p.MaxVolt,
                MinRPM = p.MinRPM,
                MaxRPM = p.MaxRPM,
                Speeds = p.Speeds,
                Sound = p.Sound,
                Sweep = p.Sweep,
                MinHeight = p.MinHeight,
                MaxHeight = p.MaxHeight,
                Weight = p.Weight

            };
            return pd;

        }
    }
}