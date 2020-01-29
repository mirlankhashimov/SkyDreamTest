using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SkyDreamTest.Data;
using SkyDreamTest.Models;

namespace SkyDreamTest
{
    public class IndexModel : PageModel
    {
        private readonly SkyDreamTest.Data.ApplicationDbContext _context;

        public IndexModel(SkyDreamTest.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Post> Post { get;set; }

        public async Task OnGetAsync()
        {
            Post = await _context.Post.ToListAsync();
        }
    }
}
