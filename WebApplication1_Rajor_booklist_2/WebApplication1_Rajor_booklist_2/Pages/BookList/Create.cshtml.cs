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
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _dBContext;

        public CreateModel(ApplicationDbContext context)
        {
            _dBContext = context;
        }

        public Book Book { get; set; }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost(Book book)
        {
            if (book == null)
                return NotFound();
         if(ModelState.IsValid)
            {
                await _dBContext.Books.AddAsync(book);
                await _dBContext.SaveChangesAsync();
                return RedirectToPage("Index");

            }
            return Page();

        }



    }
}
