using MyEvernote.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//MyEvernote.Entities içerisinde sadece veritabanı tablolarımız var, burda ise veritabanımının kendisi
namespace MyEvernote.DataAccessLayer.EntityFramework
{
    public class DatabaseContext : DbContext//tüm database classları DbContextten türer, bunu kullanabilmek için DataAccessLayera nugetten entitiyi eklemek gerekiyor
    {
        public DbSet<EvernoteUser> EvernoteUsers { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Liked> Likes { get; set; }

        public DatabaseContext()
        {
            Database.SetInitializer(new MyInitializer());
        }
    }
}
