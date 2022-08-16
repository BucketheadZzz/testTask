using Microsoft.AspNetCore.Mvc;
using testTaskAppB.BusinessLogic.Services.Interfaces;

namespace testTaskAppB.Controllers
{
    public class ShopItemController : Controller
    {
        private readonly IShopItemService _shopItemService;

        public ShopItemController(IShopItemService shopItemService)
        {
            _shopItemService = shopItemService;
        }

        public async Task<IActionResult> Index(long id)
        {
            var shopItems = await _shopItemService.GetShopItemsByShopIdAsync(id);
            return View(shopItems);
        }
    }
}
