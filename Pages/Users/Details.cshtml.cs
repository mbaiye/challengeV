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
    public class DetailsModel : PageModel
    {
        private readonly VentureGG.Data.VentureGGContext _context;

        public DetailsModel(VentureGG.Data.VentureGGContext context)
        {
            _context = context;
        }

        public Users Users { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Users = await _context.Users.FirstOrDefaultAsync(m => m.Id == id);

            if (Users == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
