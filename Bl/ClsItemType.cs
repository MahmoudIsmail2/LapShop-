using LapShop.Models;

namespace LapShop.Bl
{
    public class ClsItemType
    {
        public List<TbItemType> GetAll()
        {
            try
            {
                LapShopContext context = new LapShopContext();
                var lstItemType = context.TbItemTypes.ToList();
                return lstItemType;
            }
            catch
            {
                 return new List<TbItemType>(); 
            }
            
        }
        public TbItemType GetById(int id )
        {
            try
            {
                LapShopContext context = new LapShopContext();
                var item = context.TbItemTypes.FirstOrDefault(a => a.ItemTypeId == id);
                return item;
            }
            catch
            {
                return new TbItemType();
                   
            }
           
        }
        public bool Delete(int id)
        {
            try
            {
                 var cat=  GetById(id);
                 LapShopContext ctx = new LapShopContext(); 
                 ctx.TbItemTypes.Remove(cat);
                 ctx.SaveChanges();
                return true;
            }
            catch
            {
                return false;

            }

        }
        public bool Save(TbItemType it)
        {
            try
            {
                LapShopContext lapShopContext = new LapShopContext();
                if (it.ItemTypeId== 0)
                {
                   
                    lapShopContext.Add(it);
                   
                }
                
                   
                else
                { 
                    lapShopContext.Entry(it).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
