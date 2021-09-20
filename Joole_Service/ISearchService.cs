using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Joole_DataAccess;

namespace Joole_Service
{
    public interface ISearchService
    {
        IEnumerable<Category> GetAllCategories();
        Category GetCategory(long id);

        IEnumerable<Product> GetAllProducts();

        IEnumerable<SubCategory> GetAllSubCategory();






    }
}