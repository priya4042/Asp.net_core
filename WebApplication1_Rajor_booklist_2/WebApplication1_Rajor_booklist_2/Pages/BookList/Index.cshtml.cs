using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication1_Rajor_booklist_2.Data;
using WebApplication1_Rajor_booklist_2.Model;

namespace WebApplication1_Rajor_booklist_2.Pages.BookList
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Book> Books { get; set; }
        public async Task OnGet()
        {
            Books = await _context.Books.ToListAsync();
        }

        public async Task<IActionResult>OnPostDelete(int id)
        {
            var bookfromdb = await _context.Books.FindAsync(id);
                if (bookfromdb == null)
                return NotFound();

            _context.Books.Remove(bookfromdb);
            await _context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
