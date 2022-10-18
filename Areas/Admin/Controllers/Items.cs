using Microsoft.AspNetCore.Mvc;
using LapShop.Bl;
using LapShop.Models;

namespace LapShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class Items : Controller
    { 
        ClsItems clsItems =new ClsItems();  
        ClsCategories clsCategories =new ClsCategories();  
        ClsItemType clsItemType =new ClsItemType();
        ClsOs clsOs =new ClsOs();
        public IActionResult List()
        {
            ViewBag.Category = clsCategories.GetAll();
            var it=  clsItems.GetAllItems(null);
            return View(it);
        }
        public IActionResult Search(int id)
        {
            ViewBag.Category = clsCategories.GetAll();
            var it = clsItems.GetAllItems(id);
            return View("List",it);
        }
        public IActionResult Edit(int id)
        {
            if(id != 0)
            {
                ClsItems clsItems=new ClsItems();
                ViewBag.Category = clsCategories.GetAll();
                ViewBag.ItemType = clsItemType.GetAll();
                ViewBag.Os = clsOs.GetAll();
                var i= clsItems.GetById(id);
                return View(i);
            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public  IActionResult Save(TbItem item ,List<IFormFile> Files)
        {
            if (ModelState.IsValid)
            {
                item.CreatedDate=DateTime.Now;
                ClsItems clsItems = new ClsItems();                
                clsItems.Save(item);
                return RedirectToAction("List",item);
            }
            else
            {
                return View("Edit", item);
            }
        }
    }
}
