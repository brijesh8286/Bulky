using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebRazor_Temp.Data;
using WebRazor_Temp.Models;

namespace WebRazor_Temp.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public List<Category> Categorylist { get; set; }  
        public IndexModel(ApplicationDbContext db)
        {
        _db = db; 
        }
        public void OnGet()
        {
            Categorylist = _db.Categorie.ToList();
        }
        public void OnPost() 
        {
            
        }
    }
}
