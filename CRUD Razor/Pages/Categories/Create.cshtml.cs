using CRUD_Razor.Data;
using CRUD_Razor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUD_Razor.Pages.Categories
{
    [BindProperties ]

    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public Category Category { get; set; }

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
         
                 _db.Categories.AddAsync(Category);
                 _db.SaveChangesAsync();
            TempData["success"] = "Category created successfully";

            return RedirectToPage("Index");
            
        
        }
    }
}
