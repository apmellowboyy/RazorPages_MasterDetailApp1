using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPages_MasterDetailApp.Data;
using RazorPages_MasterDetailApp.Models;

namespace RazorPages_MasterDetailApp.Pages.Sarah
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPages_MasterDetailApp.Data.RazorPages_MasterDetailAppContext _context;

        public DetailsModel(RazorPages_MasterDetailApp.Data.RazorPages_MasterDetailAppContext context)
        {
            _context = context;
        }

      public GameCollection GameCollection { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.GameCollection == null)
            {
                return NotFound();
            }

            var gamecollection = await _context.GameCollection.FirstOrDefaultAsync(m => m.Id == id);
            if (gamecollection == null)
            {
                return NotFound();
            }
            else 
            {
                GameCollection = gamecollection;
            }
            return Page();
        }
    }
}
