using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebRazor_Temp.Data;
using WebRazor_Temp.Models;

namespace WebRazor_Temp.Pages.Categories
{
    public class DeleteModel : PageModel
    {

        private readonly ApplicationDbContext _db;    
    
        [BindProperty]

        public Category Category { get; set; }

        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet(int? id)
        {
            if (id != null && id != 0)
            {
                Category = _db.Categorie.Find(id);
            }
        }

        public IActionResult OnPost()
        {
            //if (ModelState.IsValid)
            //{
            //    _db.Categorie.Update(Category);
            //    _db.SaveChanges();
            //    return RedirectToPage("Index");
            //}
            //_db.Categorie.Add(Category);
            //_db.SaveChanges();
            //return RedirectToPage("Index");

            Category? obj = _db.Categorie.Find(Category.Id);
            if (obj == null)
            {
                 return NotFound();
            }
            _db.Categorie.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Category Deleted Successfully";
            return RedirectToPage("Index");

        }
    }
}
