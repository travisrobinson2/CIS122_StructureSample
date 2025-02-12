using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDesign.Contracts
{
    public interface IProduct
    {
        public string SKU { get; }
        public string Name { get; }
        public double Price { get; set; }

        public int Inventory { get; set; }
    }
}
