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
    public class IndexModel : PageModel
    {
        private readonly RazorPagesDeliveryCartContext _context;

        public IndexModel(RazorPagesDeliveryCartContext context)
        {
            _context = context;
        }

        public IList<Store> Store { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Store != null)
            {
                Store = await _context.Store.ToListAsync();
            }
        }
    }
}
