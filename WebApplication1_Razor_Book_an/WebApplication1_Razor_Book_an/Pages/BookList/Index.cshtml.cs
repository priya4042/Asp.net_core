using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication1_Razor_Book_an.Data;
using WebApplication1_Razor_Book_an.Model;

namespace WebApplication1_Razor_Book_an.Pages.BookList
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
    }
}
