using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Joole_DataAccess;

namespace Joole_Service
{
    public class SearchService
    {
        JooleDBEntities1 db = new JooleDBEntities1();
        public SearchService(JooleDBEntities1 db)
        {
            this.db = db; 
        }

       
        public IEnumerable<Category> getCategory
        {
            get
            {
              
                List<Category> cag = db.Categories.ToList();
                return cag;
            }

         
        }
     
    }
}


