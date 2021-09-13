using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Joole_DataAccess;
using static Joole_DataAccess.SearchVM;

namespace Joole_Service
{
    public class SearchService
    {
        JooleDBEntities1 db = new JooleDBEntities1();
        public SearchService(JooleDBEntities1 db)
        {
            this.db = db; 
        }

       
        public List<Category> getCategory
        {
            get
            {
              
                List<Category> cag = db.Categories.ToList();
                return cag;
            }

         
        }

        public List<SubCategory> getSubCategories(int categoryID)
        {
            return db.SubCategories.Where(sub => sub.Category_Id == categoryID).ToList();
        }



        public List<JoinSubCategorywithCategory> getAllSubCategoriesByCategoryID
        {
            get
            {
                var sus =  db.Categories.Join(db.SubCategories, c => c.Category_Id, sc => sc.Category_Id, (c, sc) => new SearchVM.JoinSubCategorywithCategory { cat = c, sub = sc }).ToList();
                return sus; 
            }



        }

     

        public void LoadSearch(ref SearchVM s)
        {

            s.catJoinSub = getAllSubCategoriesByCategoryID;
            s.c = getCategory; 
           

        }









    }
}


