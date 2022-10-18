using LapShop.Models;

namespace LapShop.Bl
{
    public class ClsOs
    {
        
        public List<TbO> GetAll()
        {
            try
            {
                LapShopContext context = new LapShopContext();
                var lstos = context.TbOs.ToList();
                return lstos;
            }
            catch
            {
                 return new List<TbO>(); 
            }
            
        }
        public TbO GetById(int? id )
        {
            try
            {
                LapShopContext context = new LapShopContext();
                var Os = context.TbOs.FirstOrDefault(a => a.OsId == id);
                return Os;
            }
            catch
            {
                return new TbO();
                   
            }
           
        }
        public bool Delete(int id)
        {
            try
            {
                 var os=  GetById(id);
                 LapShopContext ctx = new LapShopContext(); 
                 ctx.TbOs.Remove(os);
                 ctx.SaveChanges();
                return true;
            }
            catch
            {
                return false;

            }

        }
        public bool Save(TbO oss)
        {
            try
            {
                LapShopContext lapShopContext = new LapShopContext();
                if (oss.OsId == 0)
                {
                   
                    lapShopContext.Add(oss);
                   
                }
                else
                {
                    lapShopContext.Entry(oss).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
