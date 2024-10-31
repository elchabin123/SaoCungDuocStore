using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SaoCungDuocStore.Data;

namespace SaoCungDuocStore.Controllers
{
    public class BookBranchsController : Controller
    {
        private readonly SaoCungDuocStoreDbContext _context;
        public BookBranchsController(SaoCungDuocStoreDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allBookBranches = await _context.BookBranches.ToListAsync();
            return View(allBookBranches);
        }
    }
}
