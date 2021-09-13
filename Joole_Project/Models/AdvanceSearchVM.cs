using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Joole_DataAccess;
using System.ComponentModel.DataAnnotations;


namespace Joole_Project.Models
{
    public class AdvanceSearchVM
    {

      
        public List<SearchVM.JoinSubCategorywithCategory> t { get; set; }

        public List<Category> c { get; set; }

        public class JoinSubCategorywithCategory
        {
            public Category cat { get; set; }
            public SubCategory sub { get; set; }
        }

        public List<JoinSubCategorywithCategory> catJoinSub { get; set; }



        [Required]
        public string SubCategory { get; set; }

        [Required]
        public string subCategoryID { get; set; }




        public class SubCategoryJoinProduct
        {
            public Product prod { get; set; }
            public SubCategory sc { get; set; }


        }
        public SubCategoryJoinProduct sjp { get; set; }




    }
}


    