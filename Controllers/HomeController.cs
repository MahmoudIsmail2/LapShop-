using Microsoft.AspNetCore.Mvc;
using LapShop.Models;
using LapShop.Bl;
namespace LapShop.Controllers
{
  
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ClsItems cls=new ClsItems();
            ClsCategories cat=new ClsCategories();  
            VmHomePage vmHomePage = new VmHomePage();

            vmHomePage.lsttopitems=cls.GetAll().Where(a=>a.SalesPrice>10000).ToList();
            vmHomePage.lstallitems=cls.GetAll().Take(20).ToList();
            vmHomePage.lstInstegram = cls.GetAll().Skip(30).Take(7).ToList();
            vmHomePage.lstcategories= cat.GetAll().ToList();
                  
            return View(vmHomePage);
        }

      
    }
}
