

//=====================================================================================================================================================
//This part of the code was using DbSet. From Entity Framework Core of C#==============================================================================
//The DbSet class makes available methods that provide the capability to carry out CRUD operations on entities.========================================
//=====================================================================================================================================================
//=Try this link for more detailshttps://www.learnentityframeworkcore.com/dbset========================================================================
//=====================================================================================================================================================


using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ShepherdPOS.Api.Entities;

namespace ShepherdPOS.Api.AppDataContext
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<AppLogger>
    {
        public ApplicationDbContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
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