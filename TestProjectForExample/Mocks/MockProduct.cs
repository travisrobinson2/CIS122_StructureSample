using ObjectOrientedDesign.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectForExample.Mocks
{
    public class MockProduct : IProduct
    {
        public string SKU { 
            get 
            {
                return "Test SKU";
            }
        }

        public string Name => throw new NotImplementedException();

        public double Price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Inventory { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
