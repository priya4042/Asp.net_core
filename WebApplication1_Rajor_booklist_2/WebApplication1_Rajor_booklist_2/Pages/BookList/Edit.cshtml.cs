using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1_Rajor_booklist_2.Data;
using WebApplication1_Rajor_booklist_2.Model;

namespace WebApplication1_Rajor_booklist_2.Pages.BookList
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _dbContext;
        public EditModel(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Book Book { get; set; }

        public async Task OnGet(int id)
        {
            Book = await _dbContext.Books.FindAsync(id);
        }

        public async Task<IActionResult> OnPost(Book Book)
        {
            if (Book == null)
                return NotFound();
            if (ModelState.IsValid)
            {
                _dbContext.Update(Book);
                await _dbContext.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
