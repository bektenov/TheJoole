using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Joole_DataAccess;

namespace Joole_Repository
{
    public class ProductRepo : Repository<Product>
    {
        public ProductRepo()
        {
            entities = db.Set<Product>();
        }
      
    }
}
