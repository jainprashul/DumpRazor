#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DumpRazorWeb.Data;
using DumpRazorWeb.Model;

namespace DumpRazorWeb.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly DumpRazorWeb.Data.AppDBContext _context;

        public IndexModel(DumpRazorWeb.Data.AppDBContext context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; }

        public async Task OnGetAsync()
        {
            Category = await _context.Categories.ToListAsync();
        }
    }
}
