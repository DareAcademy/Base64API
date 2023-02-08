using Microsoft.EntityFrameworkCore;
namespace PoC_UploadImage.data
{
    public class PocContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=localhost;initial catalog=PocUpload;integrated security=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
