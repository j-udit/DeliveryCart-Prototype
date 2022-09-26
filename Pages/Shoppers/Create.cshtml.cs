using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesDeliveryCart.Models;

namespace RazorPagesDeliveryCart.Pages_Shoppers
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesDeliveryCartContext _context;

        public CreateModel(RazorPagesDeliveryCartContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Shopper Shopper { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Shopper == null || Shopper == null)
            {
                return Page();
            }

            _context.Shopper.Add(Shopper);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
