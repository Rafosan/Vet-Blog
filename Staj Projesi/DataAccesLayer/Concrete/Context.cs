using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataAccesLayer.Concrete
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)//Sql bağlantısı
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-DVVLUGC\\SQLEXPRESS;Database=DbStajVetBlog;Integrated Security=True;");
        }
    public DbSet<About> Abouts { get; set; }
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Category> Categorys { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Writer> Writers { get; set; }
    public DbSet<NewsLetter> NewsLetters { get; set; }
    public DbSet<BlogRating> BlogRatings { get; set; }
    }
}
