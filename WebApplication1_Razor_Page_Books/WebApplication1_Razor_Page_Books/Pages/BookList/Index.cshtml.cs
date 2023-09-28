using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication1_Razor_Page_Books.Data;
using WebApplication1_Razor_Page_Books.Model;

namespace WebApplication1_Razor_Page_Books.Pages.BookList
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext DbContext;

        public IndexModel(ApplicationDbContext context)
        {
            DbContext = context;
        }
        
        public IEnumerable<Book> Books { get; set; }

        public async Task OnGet()
        {
            Books = await DbContext.Books.ToListAsync();
        }
    }
}
