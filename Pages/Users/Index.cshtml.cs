using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VentureGG.Data;
using VentureGG.Models;

namespace VentureGG
{
    public class IndexModel : PageModel
    {
        private readonly VentureGG.Data.VentureGGContext _context;

        public IndexModel(VentureGG.Data.VentureGGContext context)
        {
            _context = context;
        }

        public IList<Users> Users { get; set; }

        public async Task OnGetAsync()
        {
            Users = await _context.Users.ToListAsync();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Users.Add(Users);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }

   }
}
