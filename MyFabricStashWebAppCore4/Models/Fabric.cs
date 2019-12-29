using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFabricStashWebAppCore4.Models
{
    public class Fabric
    {
        public int FabricId { get; set; }
        public string ItemCode{ get; set; }
        public string Name { get; set; }
        public string MainCategory { get; set; }
        public string SubCategory { get; set; }
        public string ImagePath { get; set; }
        public string Type { get; set; } //Knit, Woven, Voile, Interfacing, Denim, Suiting, etc.
        public string Weight { get; set; } //Lightweight, Medium, Heavy
        public string Content { get; set; } //Cotton, Polyester, Nylon, etc.
        public string Design { get; set; } //Marvel Comics, Amy Butler, etc.
        public string Brand { get; set; } //Springs Creative Products, Free Spirit, Robert Kaufman, etc.
        public int Width { get; set; } // in inches, ie. 44", 54", etc.
        public string Colors { get; set; }
        public string BackgroundColor { get; set; }
        public string Notes { get; set; }
        

    }
}
