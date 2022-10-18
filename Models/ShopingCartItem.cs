namespace LapShop.Models
{
    public class ShopingCartItem
    {
        public int ItemId { get; set; }
        public string ImageName { get; set; }
        public string ItemName { get; set; }
        public decimal SalesPrice { get; set; }
        public decimal Qty { get; set; }
        public decimal Total { get; set; }


    }
}
