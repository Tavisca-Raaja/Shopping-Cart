using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    class CartOperation:ICartOperation
    {
    
        List<Product> PurchasedItems = new List<Product>();
        Inventary AllItems = new Inventary();
        List<Product> TotalList => AllItems.GetList();
        public void AddItem(string productName,int quantity)
        {
            var item = TotalList.Find(check => check.ProductName.Equals(productName));
            if (!PurchasedItems.Any(check => check.ProductName.Equals(productName)))
            {
                if (item.ProductQuantity >= quantity)
                {
                    List<Product> newItem = new List<Product>()
                    {
                        new Product(){ProductId=item.ProductId,ProductName=item.ProductName,ProductPrice=item.ProductPrice*quantity,ProductQuantity=quantity}
                    };
                    PurchasedItems.Add(newItem.First());
                    PurchasedItems.Find(check => check.ProductName.Equals(productName)).ProductQuantity = quantity;
                    PurchasedItems.Find(check => check.ProductName.Equals(productName)).ProductPrice = (quantity * item.ProductPrice);
                    item.ProductQuantity -= quantity;
                }
                else
                {
                    if (item.ProductQuantity == 0)
                        Console.WriteLine("Out of stock");
                    else
                        Console.WriteLine("only {0} items left,you cannot order {1} items", item.ProductQuantity, quantity);
                }
            }
            else
            {
                 PurchasedItems.Find(check => check.ProductName.Equals(productName)).ProductQuantity += quantity;
                 PurchasedItems.Find(check => check.ProductName.Equals(productName)).ProductPrice+=(quantity * item.ProductPrice);
                item.ProductQuantity -= quantity;
            }

        }
        public void RemoveItem(string productName,int quantity)
        {
            try
            {
                var item = PurchasedItems.Find(check => check.ProductName.Equals(productName));
                var ProductList = TotalList.Find(check => check.ProductName.Equals(productName));
                if (item.ProductQuantity >= quantity)
                {
                    if (item.ProductQuantity == quantity)
                    {
                        PurchasedItems.Remove(item);
                        
                    }
                    else
                    {
                        item.ProductQuantity -= quantity;
                        item.ProductPrice = (item.ProductQuantity * ProductList.ProductPrice);
                    }
                    ProductList.ProductQuantity += quantity;
                }
                else
                    Console.WriteLine("you have only {0} items in cart",item.ProductQuantity);               
            }
           catch(Exception error)
            {
                Console.WriteLine("Enter a valid ItemName");
            }
        }
        public void ClearCart()
        {
            if (PurchasedItems.Count == 0)
                Console.WriteLine("Cart has no items");
            else
                PurchasedItems.Clear();
        }
        public Decimal CalculateTotal()
        {
            var totalAmount = 0m;
            foreach(var list in PurchasedItems)
                totalAmount += (list.ProductPrice);
            return totalAmount;
        }
        public void DisplayCart()
        {
            foreach(var list in PurchasedItems)
            {
                Console.WriteLine("ProductID:"+list.ProductId);
                Console.WriteLine("ProductName:" + list.ProductName);
                Console.WriteLine("ProductQuantity:" + list.ProductQuantity);
                Console.WriteLine("ProductPrice:" + list.ProductPrice);
                Console.WriteLine("<--------------------------->");
              
            }
            Console.WriteLine("TotalAmount:" + CalculateTotal());

        }
    }
}
