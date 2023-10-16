using Microsoft.AspNetCore.Mvc;
using Productify.Persistence.Context;

namespace Productify.MVC.Controllers
{
    public class WishlistController : Controller
    {
        ProductifyDbContext _context;

        public WishlistController()
        {
            _context = new ProductifyDbContext();
        }

        public IActionResult GetAll()
        {
            return View(_context.WishList.ToList());
        }
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(string productName)
        {
            _context.WishList.Add(new(productName));

            _context.SaveChanges();
            return View();
        }
    }
}
