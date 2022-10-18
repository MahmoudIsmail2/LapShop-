using LapShop.Models;

namespace LapShop.Bl
{
    public class ClsCategories
    {
        public List<TbCategory> GetAll()
        {
            try
            {
                LapShopContext context = new LapShopContext();
                var lstcategories = context.TbCategories.ToList();
                return lstcategories;
            }
            catch
            {
                 return new List<TbCategory>(); 
            }
            
        }
        public TbCategory GetById(int id )
        {
            try
            {
                LapShopContext context = new LapShopContext();
                var category = context.TbCategories.FirstOrDefault(a => a.CategoryId == id);
                return category;
            }
            catch
            {
                return new TbCategory();
                   
            }
           
        }
        public bool Delete(int id)
        {
            try
            {
                 var cat=  GetById(id);
                 LapShopContext ctx = new LapShopContext(); 
                 ctx.TbCategories.Remove(cat);
                 ctx.SaveChanges();
                return true;
            }
            catch
            {
                return false;

            }

        }
        public bool Save(TbCategory category)
        {
            try
            {
                LapShopContext lapShopContext = new LapShopContext();
                if (category.CategoryId == 0)
                {
                   
                    lapShopContext.Add(category);
                   
                }
                else
                {
                    category.CreatedBy = "1";
                    category.UpdatedBy = "1";
                    category.UpdatedBy = "";
                    category.ImageName = "";
                    category.ShowInHomePage=true;
                    category.CurrentState = 1;
                    category.CreatedDate=DateTime.Now;
                    lapShopContext.Entry(category).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                }
                lapShopContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
