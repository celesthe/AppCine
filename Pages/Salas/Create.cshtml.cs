using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using APPCINE.Data;
using APPCINE.Models;

namespace APPCINE.Pages.Salas
{
    public class CreateModel : PageModel
    {
        private readonly APPCINE.Data.Context _context;

        public CreateModel(APPCINE.Data.Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Sala Sala { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            var Total = from s in _context.Sala
                        select s;

            if (!ModelState.IsValid)
            {
                return Page();
            }

            if(Total.Count() <= 10)
            {
                _context.Sala.Add(Sala);
                await _context.SaveChangesAsync();

            }
           
           

            return RedirectToPage("./Index");
        }
    }
}
