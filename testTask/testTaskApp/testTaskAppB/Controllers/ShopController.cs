using Microsoft.AspNetCore.Mvc;
using testTaskAppB.BusinessLogic.Services.Interfaces;

namespace testTaskAppB.Controllers
{
    public class ShopController : Controller
    {
        private readonly IShopService _shopService;

        public ShopController(IShopService shopService)
        {
            _shopService = shopService;
        }

        public async Task<IActionResult> Index()
        {
            var shops = await _shopService.GetAllShopsAsync();
            return View(shops);
        }
    }
}