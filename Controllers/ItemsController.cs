using Microsoft.AspNetCore.Mvc;
using Shop_Bartova.Data.Interfaces;
using Shop_Bartova.Data.ViewModell;

namespace Shop_Bartova.Controllers
{
    public class ItemsController : Controller
    {
        private IItems IAllItems;
        private ICategorys IAllCategorys;
        VMItems VMItems = new VMItems();
        public ItemsController(IItems IAllItems, ICategorys IAllCategorys)
        {
            this.IAllItems = IAllItems;
            this.IAllCategorys = IAllCategorys;
        }
        public ViewResult List(int id=0)
        {
            ViewBag.Title = "Страница с предметами";
            VMItems.Items=IAllItems.AllItems;
            VMItems.Categorys=IAllCategorys.AllCategorys;
            VMItems.SelectCategory = id;
            return View(VMItems);
            //var cars = IAllItems.AllItems;
            //return View(cars);
        }
    }
}
