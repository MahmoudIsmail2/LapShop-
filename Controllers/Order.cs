using LapShop.Bl;
using LapShop.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace LapShop.Controllers
{
    public class Order : Controller
    {
        public decimal Qty { get; private set; }

        public IActionResult Cart()
        {
            var Session = string.Empty;
            if (Session != null)
                Session = HttpContext.Session.GetString("Cart");
            var cart= JsonConvert.DeserializeObject<ShopingCart>(Session);                   
            return View(cart);
        }
        public IActionResult AddToCart(int Id)
        {
            ShopingCart oshopingcart ;
            if (HttpContext.Session.GetString("Cart")!=null)
            {
                oshopingcart = JsonConvert.DeserializeObject<ShopingCart>(HttpContext.Session.GetString("Cart"));
            }
            else
            {
             oshopingcart= new ShopingCart();
            }
            ClsItems oclsItems=new ClsItems();  
            var item=oclsItems.GetById(Id);
            var iteminlist = oshopingcart.Items.Where(a => a.ItemId ==item.ItemId).FirstOrDefault();
            if (iteminlist != null)
            {
                iteminlist.Qty++;
                iteminlist.Total=iteminlist.Qty *iteminlist.SalesPrice;
            }
             
            else
            {
                oshopingcart.Items.Add(new ShopingCartItem
                {
                    ItemId = (int)item.ItemId,
                    ItemName = item.ItemName,
                    SalesPrice = item.SalesPrice,
                    Qty = 1,
                    Total=item.SalesPrice
                   

                });
            }
            
            oshopingcart.TotalCart = oshopingcart.Items.Sum(a => a.Total);
            
            HttpContext.Session.SetString("Cart",JsonConvert.SerializeObject(oshopingcart)); 
           
            return RedirectToAction("Cart");
        }
    }
}