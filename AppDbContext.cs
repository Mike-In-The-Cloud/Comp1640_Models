using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Models
{
    public class AppDbContext : IdentityUserContext<mUser, int>
    {
        /// <summary>
        ///     Properties to access the database tables.
        ///     Here the name of the attribute will be the 
        ///     name of the table in db.
        /// </summary>
        /// 

        public DbSet<Categories> Categories { get; set; }
        public DbSet<CategoriesToDepartmets> CategoriesToDepartmets { get; set; }
        public DbSet<CategoriesToIdeas> CategoriesToIdeas { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Departments> Departments { get; set; }
        public DbSet<Documents> Documents { get; set; }
                        
        public DbSet<Ideas> Ideas { get; set; }

        public DbSet<Reports> Reports { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
          : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            /// Construct the database model
            base.OnModelCreating(builder);

            /// Customize the user model
            builder.Entity<mUser>().ToTable("mUser");// Change Table Name
            // Remove Table columns
            builder.Entity<mUser>().Ignore(u => u.UserName);
            builder.Entity<mUser>().Ignore(u => u.NormalizedUserName);
            builder.Entity<mUser>().Ignore(u => u.PhoneNumberConfirmed);
            builder.Entity<mUser>().Ignore(u => u.TwoFactorEnabled);
            builder.Entity<mUser>().Property(u => u.Id);


            builder.Entity<Categories>(entity => 
            { 
                
            });


            // departments db context
            builder.Entity<CategoriesToDepartmets>(entity =>
            {
                // fluent API for department model
                entity.HasOne(d => d.Departments)
                      .WithMany(cd => cd.CategoriesToDepartmets)
                      .HasForeignKey(d => d.Departments.DeparmentId)
                      .OnDelete(DeleteBehavior.SetNull)
                      .HasConstraintName("FK_Departments");

                // fluent API for categories
                entity.HasOne(c => c.Categories)
                    .WithMany(cd => cd.CategoriesToDepartmets)
                    .HasForeignKey(c => c.Categories.CategoriesId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Categories");
            });

            // department application db context

        }
    }
}
