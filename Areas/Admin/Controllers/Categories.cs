using Microsoft.AspNetCore.Mvc;
using LapShop.Models;
using LapShop.Bl;

namespace LapShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoriesController : Controller
    {
      
        public IActionResult List()
        {
            ClsCategories clsCategories=new ClsCategories();        
            return View(clsCategories.GetAll());
        }
        public IActionResult Edit(int categoryId)

        {
            TbCategory category = new TbCategory();
            if (categoryId != null)
            {
                ClsCategories clsCategories = new ClsCategories();
                var c= clsCategories.GetById(categoryId);
                return View(c);
            }
            return View(category);
        }
                   
        [HttpPost]
        [ValidateAntiForgeryToken]
        public  IActionResult Save(TbCategory category,List<IFormFile> Files)
        {
            ModelState.Remove("CreatedDate");
            ModelState.Remove("CategoryId");
            if (ModelState.IsValid)
            {
                
                ClsCategories clsCategories = new ClsCategories();
                clsCategories.Save(category);
                return RedirectToAction("List");   
            }
           else
           {
                return View("Edit",category);
           }
        }
        public IActionResult Delete(int categoryId)
        {

            ClsCategories clsCategories = new ClsCategories();
            clsCategories.Delete(categoryId);   
            return RedirectToAction("List");
        }
    }
}
