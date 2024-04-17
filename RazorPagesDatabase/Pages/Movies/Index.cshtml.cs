using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesDatabase.Data;
using RazorPagesDatabase.Models;

namespace RazorPagesDatabase.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesDatabase.Data.RazorPagesDatabaseContext _context;

        public IndexModel(RazorPagesDatabase.Data.RazorPagesDatabaseContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if(_context.Movie != null)
            {
                Movie = await _context.Movie.ToListAsync();
            }
        }
    }
}
