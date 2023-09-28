using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1_Razor_Core_Upsert.Data;
using WebApplication1_Razor_Core_Upsert.Model;

namespace WebApplication1_Razor_Core_Upsert.Pages.BookList
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _Context;

        public CreateModel(ApplicationDbContext context)
        {
            _Context = context;
        }

        public Book Book { get; set; }

        public void OnGet()
        {

        }
       public async Task<IActionResult> Onpost(Book book)
        {
            if (book == null)
                return NotFound();
            if(ModelState.IsValid)
            {
                await _Context.Books.AddAsync(book);
                await _Context.SaveChangesAsync();
                return RedirectToPage("Index");

            }
            return Page();
        }
        
    }
}
