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
    public class UpsertModel : PageModel
    {
        public readonly ApplicationDbContext dbContext;
        public UpsertModel(ApplicationDbContext context)
        {
            dbContext = context;
        }

        public Book book { get; set; }

        //public async Task<IActionResult> OnGet(int? id)
        //{
        //    book = new Book();
        //    if (id == null)
        //        return Page();
        //}
    }
}
