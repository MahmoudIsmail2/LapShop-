using LapShop.Bl;

namespace LapShop.Models
{
    public class VmHomePage
    {
        public VmHomePage()
        {
            lstallitems = new List<VwItem>();
            lstcategories = new List<TbCategory>();
            lstInstegram= new List<VwItem>();   
            lsttopitems = new List<VwItem>();   
        }
        public List<VwItem> lstallitems { get; set; }
        public List<TbCategory> lstcategories { get; set; }
        public List<VwItem> lstInstegram { get; set; }
        public List<VwItem> lsttopitems { get; set; }

    }
}
      
    

