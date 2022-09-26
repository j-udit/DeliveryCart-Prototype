using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesDeliveryCart.Models;

namespace RazorPagesDeliveryCart.Pages_Shoppers
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesDeliveryCartContext _context;

        public IndexModel(RazorPagesDeliveryCartContext context)
        {
            _context = context;
        }

        public IList<Shopper> Shopper { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Shopper != null)
            {
                Shopper = await _context.Shopper.ToListAsync();
            }
        }
    }
}
