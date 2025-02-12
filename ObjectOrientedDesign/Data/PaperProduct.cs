using ObjectOrientedDesign.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDesign.Data
{
    public abstract class PaperProduct : IProduct
    {
        private double _price = 0;

        public string SKU { get; }
        public string Name { get; }
        public double Price {
            get
            {
                return _price;
            }
            set
            {
                if(value >= 0)
                {
                    _price = value;
                }
                else
                {
                    throw new ArgumentException("Price can't be less than 0");
                }
            }
        }
        public int Inventory { get; set; }

        public string StockCode { get; set; }

        public abstract void Print(string productText);
    }
}
