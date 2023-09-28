using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication1_Razor_Core_Upsert.Data;
using WebApplication1_Razor_Core_Upsert.Model;

namespace WebApplication1_Razor_Core_Upsert.Pages.BookList
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _Context;

        public IndexModel(ApplicationDbContext context)
        {
            _Context = context;
        }

        public IEnumerable<Book> Books { get; set; }

        public async Task OnGet()
        {
            Books = await _Context.Books.ToListAsync();
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var bookfromdb = await _Context.Books.FindAsync(id);
            if (bookfromdb == null)
                return NotFound();

            _Context.Books.Remove(bookfromdb);
            await _Context.SaveChangesAsync();
            return RedirectToPage("Index");

        }
        
    }
}
