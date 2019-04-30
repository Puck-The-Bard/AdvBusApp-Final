using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Player.Models;

namespace FinalProject.Pages.Characters
{
    public class EditModel : PageModel
    {
        private readonly Context _context;

        public EditModel(Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Character Character { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Character = await _context.Character.FirstOrDefaultAsync(m => m.CharacterID == id);

            if (Character == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Character).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterExists(Character.CharacterID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CharacterExists(int id)
        {
            return _context.Character.Any(e => e.CharacterID == id);
        }
    }
}
