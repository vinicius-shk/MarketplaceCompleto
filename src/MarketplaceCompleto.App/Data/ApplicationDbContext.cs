using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MarketplaceCompleto.App.ViewModels;

namespace MarketplaceCompleto.App.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<MarketplaceCompleto.App.ViewModels.ProdutoViewModel> ProdutoViewModel { get; set; }
    }
}