using Microsoft.AspNetCore.Mvc;
using OnlineBookShoop.Data;
using OnlineBookShoop.Models;

namespace OnlineBookShoop.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> CategoryList = _db.Categories.ToList();
            return View(CategoryList);
        }
    }
}
