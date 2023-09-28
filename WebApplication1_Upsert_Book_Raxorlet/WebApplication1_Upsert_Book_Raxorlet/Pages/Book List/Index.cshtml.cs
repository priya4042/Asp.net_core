using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication1_Upsert_Book_Raxorlet.Data;
using WebApplication1_Upsert_Book_Raxorlet.Model;

namespace WebApplication1_Upsert_Book_Raxorlet.Pages.Book_List
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

       
        
    }
}
