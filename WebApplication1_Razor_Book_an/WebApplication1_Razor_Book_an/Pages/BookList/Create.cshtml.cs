using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1_Razor_Book_an.Data;
using WebApplication1_Razor_Book_an.Model;

namespace WebApplication1_Razor_Book_an.Pages.BookList
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public Book Book { get; set; }
        public void OnGet()
        {
        }

        public async Task <IActionResult> OnPost(Book Book)
        {
            if (Book == null)
                return NotFound();
            if(ModelState.IsValid)
            {
                await _context.Books.AddAsync(Book);
                await _context.SaveChangesAsync();
                return RedirectToPage("Index");

            }
            return Page();
        }
    }
}
