using Joole_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Joole_Repository;
using JooleDBEntities1 = Joole_DataAccess.JooleDBEntities1;

namespace Joole_Service


{
    public class SearchService : ISearchService
    {


        private IRepository<Category> CategoryRepo;

        private ProductRepo productRepository = new ProductRepo();

        private IRepository<SubCategory> SubCategoryRepo;

        private IRepository<Product> ProductRepo;
        private JooleDBEntities1 db = new JooleDBEntities1();

        public SearchService( JooleDBEntities1 db)
        {
          /*  this.CategoryRepo = c;
            this.SubCategoryRepo = sub;
            this.ProductRepo = p;*/
            this.db = db; 

        }


        public IEnumerable<Category> GetAllCategories()
        {
           // return this.CategoryRepo.GetAll();
            return db.Categories.ToList();
        }

      

        public IEnumerable<SubCategory> GetAllSubCategory()
        {
            return db.SubCategories.ToList();
        }

        public Category GetCategory(long id)
        {
            return CategoryRepo.Get(id);


        }

        public IEnumerable<Product> GetAllProducts()
        {
            return productRepository.GetAll();

        }
    }
}


