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
        public string Manufacturer { get; set; }
        public string Series { get; set; }
        public string Model { get; set; }
        public string Product_Image { get; set; }
        //property for TYPE
        public string Model_Year { get; set; }

        public string AirFlow { get; set; }

        public string UseType { get; set; }

        public string Application { get; set; }

        public string Accessories { get; set; }

        public string Speeds { get; set; }
        public string MinRPM { get; set; }
        public string MaxRPM { get; set; }
        public string Mount { get; set; }
        public string MaxSpeed { get; set; }

        public string Sound { get; set; }

        public string Featured { get; set; }

        public string MinPower { get; set; }

        public string MaxPower { get; set; }

        public string MinVolt { get; set; }

        public string MaxVolt { get; set; }


        public string Sweep { get; set; }

        public string MinHeight { get; set; }

        public string MaxHeight { get; set; }

        public string Weight { get; set; }



        public string Speed { get; set; }

        //property for techspec

    }
}