using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace StockInventoryServer.Models
{
    public partial class StocksDBContext : DbContext
    {

        public StocksDBContext(DbContextOptions<StocksDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Product { get; set; }

    }
}
