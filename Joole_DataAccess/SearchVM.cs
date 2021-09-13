using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joole_DataAccess
{
    public class SearchVM
    {
        public List<Category> c { get; set; }

        public class JoinSubCategorywithCategory
        {
            public Category cat { get; set; }
            public SubCategory sub { get; set; }
        }

        public List<JoinSubCategorywithCategory> catJoinSub {get ; set ; }  


       
        
    }
}
