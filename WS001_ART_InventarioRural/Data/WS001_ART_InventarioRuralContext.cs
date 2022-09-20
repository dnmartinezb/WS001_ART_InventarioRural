using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WS001_ART_InventarioRural.Models;

namespace WS001_ART_InventarioRural.Data
{
    public class WS001_ART_InventarioRuralContext : DbContext
    {
        public WS001_ART_InventarioRuralContext (DbContextOptions<WS001_ART_InventarioRuralContext> options)
            : base(options)
        {
        }

        public DbSet<WS001_ART_InventarioRural.Models.InventarioRural> InventarioRural { get; set; } = default!;
    }
}
