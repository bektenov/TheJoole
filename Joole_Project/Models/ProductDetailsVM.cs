using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Joole_DataAccess;

namespace TheJooleProject.Models
{
    public class ProductDetailsVM
    {
        //property for Description 
        [Key]
        public int ProductID { get; set; }
        public string ManufactureName { get; set; }
        public string Series { get; set; }
        public string Model { get; set; }
        public string Product_image { get; set; }
        //property for TYPE
        public Nullable<System.DateTime> Model_Year { get; set; }

        //property for techspec

    }
}