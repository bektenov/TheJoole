using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Joole_DataAccess;

namespace JooleProject.Models
{



    public class SearchVM
    {

        public string Category_Name { get; set; }

        public int Category_Id { get; set; }


        public string Product_Name { get; set; }

        public int SubCategory_Id { get; set; }







    }
}
