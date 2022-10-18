namespace LapShop.Models
{
    public class VmItemDetails
    {
        public VmItemDetails()
        {
            lstRealtedProducts=new List<VwItem>();
            Item=new VwItem();
        }
        public List<VwItem> lstRealtedProducts { get; set; }
        public VwItem Item { get; set; }
    }
}
