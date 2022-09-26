using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesDeliveryCart.Models;

namespace RazorPagesDeliveryCart.Pages_Stores
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesDeliveryCartContext _context;

        public DetailsModel(RazorPagesDeliveryCartContext context)
        {
            _context = context;
        }

      public Store Store { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Store == null)
            {
                return NotFound();
            }

            var store = await _context.Store.FirstOrDefaultAsync(m => m.ID == id);
            if (store == null)
            {
                return NotFound();
            }
            else 
            {
                Store = store;
            }
            return Page();
        }
    }
}
