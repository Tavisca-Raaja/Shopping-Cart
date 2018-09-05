using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    class Inventary
    {
        List<Product> newProduct = new List<Product>()
        {
            new Product(){ProductId=101,ProductName="Biscuit",ProductPrice=110,ProductQuantity=10},
            new Product(){ProductId=102,ProductName="Chips",ProductPrice=20,ProductQuantity=5},
            new Product(){ProductId=103,ProductName="Pencil",ProductPrice=20,ProductQuantity=6},
            new Product(){ProductId=104,ProductName="Mobile",ProductPrice=20000,ProductQuantity=10},
            new Product(){ProductId=105,ProductName="Headset",ProductPrice=2000,ProductQuantity=3}
        };

        public List<Product> GetList()
        {
            return newProduct;
        }
    }
}
