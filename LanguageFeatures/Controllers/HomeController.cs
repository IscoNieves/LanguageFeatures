using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ViewResult> Index()
        {
            long? length = await MyAsyncMethods.GetPageLength();

            return View(new string[] { $"Length: {length}" });
        }

        //public ViewResult Index()
        //{
        //    var products = new[] {
        //        new { Name = "Kayak", Price = 275m },
        //        new { Name = "Lifejacket", Price = 48.95m },
        //        new { Name = "Soccer ball", Price = 19.50m },
        //        new { Name = "Corner flag", Price = 34.95m }
        //    };

        //    return View(products.Select(p => p.Name));
        //}

        //public ViewResult Index() => View(Product.GetProducts().Select(p => p?.Name));

        //public ViewResult Index()
        //{
        //ShoppingCart cart = new ShoppingCart
        //{
        //    Products = Product.GetProducts()
        //};

        //Product[] productArray = {
        //    new Product{ Name = "Kayak", Price = 275m},
        //    new Product{ Name = "Lifejacket", Price = 48.95m},
        //    new Product{ Name = "Soccer ball", Price = 19.50m},
        //    new Product{ Name = "Corner flag", Price = 34.95m}
        //};

        //decimal priceFilterTotal = productArray.Filter(p => (p?.Price ?? 0) >= 20).TotalPrices();
        //decimal nameFilterTotal = productArray.Filter(p => p?.Name?[0] == 's').TotalPrices();

        //decimal cartTotal = cart.TotalPrices();
        //decimal arrayTotal = productArray.FilterByPrice(20).TotalPrices();

        //return View("Index", new string[] { $"Total: {cartTotal:C2}", $"ArrayTotal: {arrayTotal:C2}" });

        //List<string> results = new List<string>();

        //foreach (Product p in Product.GetProducts())
        //{
        //    string name = p?.Name ?? "<No Name>";
        //    decimal? price = p?.Price ?? 0;
        //    string relatedName = p?.Related?.Name ?? "<None>";
        //    results.Add($"Name: {name}, Price: {price:C2}, Related: {relatedName}");
        //}

        //return View(results);
        //}
    }
}
