using CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD.DataAccess.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>  options) : base(options) 
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(new Category { Id = 1, Name = "Web Development", DisplayOrder = 1 });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 2, Name = "Mobile Development", DisplayOrder = 2 });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 3, Name = "Game Development", DisplayOrder = 3 });
        }




    }
}
