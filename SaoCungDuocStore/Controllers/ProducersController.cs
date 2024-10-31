using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SaoCungDuocStore.Data;

namespace SaoCungDuocStore.Controllers
{
    public class ProducersController : Controller
    {
        private readonly SaoCungDuocStoreDbContext _context;
        public ProducersController(SaoCungDuocStoreDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allProducers = await _context.Producers.ToListAsync();
            return View(allProducers);
        }
    }
}
