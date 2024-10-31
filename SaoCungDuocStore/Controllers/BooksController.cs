using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SaoCungDuocStore.Data;
using SaoCungDuocStore.Models;

namespace SaoCungDuocStore.Controllers
{
    public class BooksController : Controller
    {
        private readonly SaoCungDuocStoreDbContext _context;
        public BooksController(SaoCungDuocStoreDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allBooks = await _context.Books.Include(n=>n.BookBranchs).OrderBy(n => n.Name).ToListAsync();
            return View(allBooks);
        }
    }
}
