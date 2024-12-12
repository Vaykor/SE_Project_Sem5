using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPlaner.Model.Classes.Database
{
    public class TripMemory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Photo { get; set; } // can be null
        public string? Note { get; set; } // can be null
        public string? SongURL { get; set;} // can be null

        //byte[] imageArray = System.IO.File.ReadAllBytes(@"image file path"); -> transforming image into byte array
        //string base64ImageRepresentation = Convert.ToBase64String(imageArray); -> converting byte array into string
        //var img = Image.FromStream(new MemoryStream(Convert.FromBase64String(base64String))); -> converting string back to image

    }
}
