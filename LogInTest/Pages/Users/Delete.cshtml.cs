﻿using System;
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
    public class DeleteModel : PageModel
    {
        private readonly LogInTest.Data.LogInTestContext _context;

        public DeleteModel(LogInTest.Data.LogInTestContext context)
        {
            _context = context;
        }

        [BindProperty]
        public User User { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            User = await _context.User.FirstOrDefaultAsync(m => m.Email == id);

            if (User == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            User = await _context.User.FindAsync(id);

            if (User != null)
            {
                _context.User.Remove(User);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
