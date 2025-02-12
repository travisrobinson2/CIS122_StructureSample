using ObjectOrientedDesign.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDesign.ShoppingCart
{
    public class Cart
    {
        private List<IProduct> _products = new List<IProduct>();

        public List<IProduct> Products { get {  return _products; } }



    }
}
