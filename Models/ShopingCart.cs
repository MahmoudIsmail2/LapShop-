using Microsoft.EntityFrameworkCore.Query.Internal;

namespace LapShop.Models
{
   
    public class ShopingCart
    {
        public ShopingCart()
        {
            Items = new List<ShopingCartItem>();
        }
        public List<ShopingCartItem> Items { get; set; }
        public decimal TotalCart { get; set; }
    }
}
