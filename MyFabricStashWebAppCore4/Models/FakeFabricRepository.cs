using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace MyFabricStashWebAppCore4.Models
{
    public class FakeFabricRepository : IFabricRepository
    {
        public IQueryable<Fabric> Fabrics => new List<Fabric>
        {
            new Fabric {
                Name = "Chicago Cubs v1",
                MainCategory = "Sports", SubCategory = "MLB Baseball",
                ImagePath = "Chicago-Cubs-v1-fabric.jpg",
                Type = "Woven",
                Weight = "Medium",
                Content = "100% Cotton",
                Design = "Logo",
                Brand = "Springs Creative Products",
                Width = 0,
                Colors = "blue,red,white",
                BackgroundColor = "Blue",
                Notes = "This is some notes",
                DateAdded = DateTime.UtcNow,
                DateModified = DateTime.UtcNow
            },
            new Fabric {
                Name = "Chicago Bears v1",
                MainCategory = "Sports", SubCategory = "NFL Football",
                ImagePath = "0_chicago_bears_fabric.jpg",
                Type = "Woven",
                Weight = "Medium",
                Content = "100% Cotton",
                Design = "Logo",
                Brand = "Springs Creative Products",
                Width = 0,
                Colors = "dark blue,orange,white",
                BackgroundColor = "Dark Blue",
                Notes = "This is some notes",
                DateAdded = DateTime.UtcNow,
                DateModified = DateTime.UtcNow
            },
            new Fabric {
                Name = "Milwaukee Bucks v1",
                MainCategory = "Sports", SubCategory = "NBA Basketball",
                ImagePath = "D068D5A3-CBA5-4C2A-974F-66F012509296.jpeg",
                Type = "Woven",
                Weight = "Medium",
                Content = "100% Cotton",
                Design = "Logo",
                Brand = "Springs Creative Products",
                Width = 0,
                Colors = "green,tan,white",
                BackgroundColor = "White",
                Notes = "This is some notes",
                DateAdded = DateTime.UtcNow,
                DateModified = DateTime.UtcNow
            }
        }.AsQueryable<Fabric>();
    }
    
}
