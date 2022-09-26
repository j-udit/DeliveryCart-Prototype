using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesDeliveryCart.Models;

    public class RazorPagesDeliveryCartContext : DbContext
    {
        public RazorPagesDeliveryCartContext (DbContextOptions<RazorPagesDeliveryCartContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesDeliveryCart.Models.Shopper> Shopper { get; set; } = default!;

        public DbSet<RazorPagesDeliveryCart.Models.Store>? Store { get; set; }
    }
