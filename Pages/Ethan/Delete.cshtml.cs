using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPages_MasterDetailApp.Data;
using RazorPages_MasterDetailApp.Models;

namespace RazorPages_MasterDetailApp.Pages.Ethan
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPages_MasterDetailApp.Data.RazorPages_MasterDetailAppContext _context;

        public DeleteModel(RazorPages_MasterDetailApp.Data.RazorPages_MasterDetailAppContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.GameCollection == null)
            {
                return NotFound();
            }
            var gamecollection = await _context.GameCollection.FindAsync(id);

            if (gamecollection != null)
            {
                GameCollection = gamecollection;
                _context.GameCollection.Remove(GameCollection);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
