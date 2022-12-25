using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using APPCINE.Data;
using APPCINE.Models;

namespace APPCINE.Pages.Salas
{
    public class DetailsModel : PageModel
    {
        private readonly APPCINE.Data.Context _context;

        public DetailsModel(APPCINE.Data.Context context)
        {
            _context = context;
        }

        public Sala Sala { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Sala = await _context.Sala.FirstOrDefaultAsync(m => m.Id == id);

            if (Sala == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
