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
    public class IndexModel : PageModel
    {
        private readonly APPCINE.Data.Context _context;

        public IndexModel(APPCINE.Data.Context context)
        {
            _context = context;
        }

        public IList<Sala> Sala { get;set; }

        public async Task OnGetAsync()
        {
            Sala = await _context.Sala.ToListAsync();
        }
    }
}
