using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LogInTest.Data;
using LogInTest.Models;

namespace LogInTest.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly LogInTest.Data.LogInTestContext _context;

        public IndexModel(LogInTest.Data.LogInTestContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; }

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
