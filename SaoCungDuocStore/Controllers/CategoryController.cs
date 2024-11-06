using Microsoft.AspNetCore.Mvc;
using SaoCungDuocStore.Data;
using SaoCungDuocStore.Models;

namespace SaoCungDuocStore.Controllers
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
            List<Category> CategoriesList = _db.Categories.ToList();
            return View(CategoriesList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category obj)
        {
            if(obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "Thứ tự và thể loại không thể giống nhau");
            }
            if (ModelState.IsValid) { 
            _db.Categories.Add(obj);
            _db.SaveChanges();
                TempData["success"] = "Thêm mới thể loại thành công";
                return RedirectToAction("Index");
            }
            return View();
        }



        //EDIT
        public IActionResult Edit(int? categoryId)
        {
            if (categoryId == null || categoryId == 0)
            {
                return NotFound();
            }
            Category? categoryFormDb = _db.Categories.Find(categoryId);
           /* Category? categoryFormDb1 = _db.Categories.FirstOrDefault(u=>u.CategoryId == id);
            Category? categoryFormDb2 = _db.Categories.Where(u=>u.CategoryId == id).FirstOrDefault();*/

            if (categoryFormDb == null) {
                return NotFound();
            }
            return View(categoryFormDb);
        }
        [HttpPost]
        public IActionResult Edit(Category obj)
        {
            
            if (ModelState.IsValid)
            {
                _db.Categories.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Cập nhật thể loại thành công";

                return RedirectToAction("Index");
            }
            return View();
        }


        // DELETE
        public IActionResult Delete(int? categoryId)
        {
            if (categoryId == null || categoryId == 0)
            {
                return NotFound();
            }
            Category? categoryFormDb = _db.Categories.Find(categoryId);
            /* Category? categoryFormDb1 = _db.Categories.FirstOrDefault(u=>u.CategoryId == id);
             Category? categoryFormDb2 = _db.Categories.Where(u=>u.CategoryId == id).FirstOrDefault();*/

            if (categoryFormDb == null)
            {
                return NotFound();
            }
            return View(categoryFormDb);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? categoryId)
        {
            Category obj = _db.Categories.Find(categoryId);
            if (obj == null) {
                return NotFound();
            }
            _db.Categories.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Xoá thể loại thành công";

            return RedirectToAction("Index");
            
        }
    }
}
