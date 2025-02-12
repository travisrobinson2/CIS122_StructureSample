using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDesign.Data.Products
{
    public class PhotoAlbum : PaperProduct
    {
        public override void Print(string productText)
        {
            Console.WriteLine($"print the image located at {productText}");
        }
    }
}
