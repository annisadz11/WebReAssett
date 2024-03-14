using Microsoft.EntityFrameworkCore;
using WebReAsset.Models;

namespace WebReAsset.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<NewAsset> NewAssets { get; set; }

        public DbSet<Scrap> Scraps { get; set; }

        public DbSet<NewHire> NewHires { get; set; }

        public DbSet<AssetRequest> AssetRequests { get; set; }
    }
}