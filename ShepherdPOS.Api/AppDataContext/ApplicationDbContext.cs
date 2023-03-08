using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ShepherdPOS.Api.Entities;

namespace ShepherdPOS.Api.AppDataContext
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<AppLogger>
    {
        public ApplicationDbContext( DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Sale> Sales { get; set; }

        public DbSet<ProductCategory> ProductCategories { get; set; }

        public DbSet<PosCartTransaction> PosCartTransactions { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<SaleProduct> SaleProducts { get; set; }

        public DbSet<Stock> Stocks { get; set; }
        
        
        
    }
}