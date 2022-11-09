using Microsoft.AspNetCore.Mvc;
using ProductsMvcDbFirst.Models;
using ProductsMvcDbFirst.Models.Products;

namespace ProductsMvcDbFirst.Controllers
{
    public class ProductController : Controller
    {
        ProductsMvcDbFirstContext _db = new ProductsMvcDbFirstContext(); //only one controller that accesses the database, we did not create a service.

        public IActionResult Index()
        {
            List<ProductListItem> allProducts = _db.Products
                .Select(p => new ProductListItem()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price
                })
                .ToList();

            return View("ProductIndex", allProducts);
        }

        public IActionResult Create()
        {
            return View("ProductCreate");
        }

        public IActionResult AddProductToDb(Product p)
        {
            p.LastUpdated = DateTime.Now;
            _db.Products.Add(p);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Product p = _db.Products.FirstOrDefault(x => x.Id == id); //this product model has all the information
            ProductDetails pd = new ProductDetails()
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                Brand = p.Brand,
                WholesaleCost = p.WholesaleCost,
                LastUpdated = p.LastUpdated
            };
            return View(pd);
        }

    }
}
