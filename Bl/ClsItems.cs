using LapShop.Areas.Admin.Controllers;
using LapShop.Models;

namespace LapShop.Bl
{
    public class ClsItems
    {
        public List<VwItem> GetAll()
        {
            try
            {
                LapShopContext lapShopContext = new LapShopContext();
                var Item=lapShopContext.VwItems.ToList();
                return Item;
            }
            catch
            {
                return new List<VwItem> { };

            }

        }
        public List<VwItem> GetAllItems(int? itid)
        {
            LapShopContext lapShopContext = new LapShopContext();
            try
            {
                var i = lapShopContext.VwItems.Where(a => a.ItemId == itid || itid == null || itid == 0)
                    .ToList();
                return i;
            }
            catch
            {
                return new List<VwItem>();
            }

        }
        public TbItem GetById(int id)
        {
            try
            {
                LapShopContext context = new LapShopContext();
                var it = context.TbItems.FirstOrDefault(a => a.ItemId == id);
                return it;
            }
            catch
            {
                return new TbItem();

            }

        }
        public VwItem GetItemById(int id)
        {
            try
            {
                LapShopContext context = new LapShopContext();
                var it = context.VwItems.FirstOrDefault(a => a.ItemId == id);
                return it;
            }
            catch
            {
                return new VwItem();

            }

        }
        public bool Delete(int id)
        {
            try
            {
                var item = GetById(id);
                LapShopContext ctx = new LapShopContext();
                ctx.TbItems.Remove(item);
                ctx.SaveChanges();
                return true;
            }
            catch
            {
                return false;

            }

        }
        public bool Save(TbItem it)
        {
            try
            {
                LapShopContext lapShopContext = new LapShopContext();
                if (it.ItemId == 0)
                {

                    lapShopContext.Add(it);
                    lapShopContext.SaveChanges();

                }
                else
                {
                    lapShopContext.Entry(it).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    lapShopContext.SaveChanges();
                }
                
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

