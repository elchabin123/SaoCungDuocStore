using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SaoCungDuocStore.DataAccess.Repository.IRepository;
using SaoCungDuocStore.Models;
using System.Diagnostics;
using System.Security.Claims;
using SaoCungDuocStore.Utility;
using Microsoft.AspNetCore.Http;

namespace SaoCungDuocStore.Areas.Customer.Controllers
{
    [Area("Customer")]

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }
        [Route("san-pham-mang-ma+{productId}.html")]
        public IActionResult Details(int productId)
        {

            ShoppingCart cart = new ShoppingCart()
            {
                Product = _unitOfWork.Product.Get(u => u.Id == productId, includeProperties: "Category,ProductImages"),
                Count = 1,
                ProductId = productId
            };
            
            return View(cart);
        }
        [HttpPost]
        [Authorize]
        public IActionResult Details(ShoppingCart shoppingCart)
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;
            shoppingCart.ApplicationUserId = userId;

            ShoppingCart cartFromDb = _unitOfWork.ShoppingCart.Get(u => u.ApplicationUserId == userId &&
            u.ProductId == shoppingCart.ProductId);

            if (cartFromDb != null)
            {
                //shopping cart exists
                cartFromDb.Count += shoppingCart.Count;
                _unitOfWork.ShoppingCart.Update(cartFromDb);
                _unitOfWork.Save();
            }
            else
            {
                //add cart record
                _unitOfWork.ShoppingCart.Add(shoppingCart);
                _unitOfWork.Save();
                HttpContext.Session.SetInt32(SD.SessionCart,
                _unitOfWork.ShoppingCart.GetAll(u => u.ApplicationUserId == userId).Count());
                
            }
            TempData["success"] = "Cập Nhật Giỏ Hàng Thành Công";
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Index(int? categoryId)
        {

            IEnumerable<Product> productList = _unitOfWork.Product.GetAll(includeProperties: "Category,ProductImages");

            return View(productList);
        }
        [Route("the-loai-+{categoryId}")]
        public IActionResult Category(int? categoryId)
        {
            IEnumerable<Product> productList = _unitOfWork.Product.GetAll(includeProperties: "Category,ProductImages");
            if (categoryId.HasValue)
            {
                // Lọc sản phẩm theo CategoryId
                productList = _unitOfWork.Product.GetAll(p => p.CategoryID == categoryId, includeProperties: "Category");
            }
            else
            {
                // Nếu không có categoryId, lấy tất cả sản phẩm
                productList = _unitOfWork.Product.GetAll(includeProperties: "Category");
            }
            return View(productList);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
