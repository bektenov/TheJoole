using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Joole_DataAccess;

namespace Joole_Service
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();
        Product GetProduct(long id);
        void InsertProduct(Product product);
        void UpdateProduct(Product product);

        void DeleteProduct(long id);
    }
}
