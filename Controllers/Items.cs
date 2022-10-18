using LapShop.Bl;
using LapShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace LapShop.Controllers
{
    public class Items : Controller
    {
        public IActionResult ItemDetails(int Id)
        {
            ClsItems oclsitems=new ClsItems();
            var item=oclsitems.GetItemById(Id);
            VmItemDetails vmitemdetails=new VmItemDetails();    
            vmitemdetails.Item=item;
            vmitemdetails.lstRealtedProducts=oclsitems.GetAll().Where(a=>a.CategoryId==item.CategoryId).Take(12).ToList();

            return View(vmitemdetails);
        }
    }
}
