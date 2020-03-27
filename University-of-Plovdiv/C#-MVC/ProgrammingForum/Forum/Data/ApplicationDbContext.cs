using System.Data.Entity;
using Forum.Data.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Forum.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            this.Configuration.ProxyCreationEnabled = true;
            this.Configuration.LazyLoadingEnabled = true;
        }
        
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        //public DbSet<ApplicationUser> Users { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            

        }
    }
}