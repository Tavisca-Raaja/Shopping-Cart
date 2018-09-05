using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    interface ICartOperation
    {
        void AddItem(string productName,int quantity);
        void RemoveItem(string productName,int quantity);
        void ClearCart();
        Decimal CalculateTotal();
        void DisplayCart();

    }
}
