using Microsoft.AspNetCore.Mvc;
using SaoCungDuocStore.Data;

namespace SaoCungDuocStore.Controllers
{
    public class AuthorsController : Controller
    {
        private readonly SaoCungDuocStoreDbContext _context;
        public AuthorsController(SaoCungDuocStoreDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Author.ToList();
            return View(data);
        }
    }
}
