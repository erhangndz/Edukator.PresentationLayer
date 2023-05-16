using Edukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.DataAccessLayer.Concrete
{
    public class Context: IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ERHAN\\SQLEXPRESS;initial catalog=DbEdukator;integrated security=true;");
        }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Category> Categories  { get; set; }

        public DbSet<ContactInfo> ContactInfos { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Service> Services { get; set; }

        public DbSet<Map> Maps { get; set; }

        public DbSet<Reference> References { get; set; }

        public DbSet<Subscriber> Subscribers { get; set; }

        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<CourseRegister> CourseRegisters { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        
    }
}
