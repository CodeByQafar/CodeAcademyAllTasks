using FitnessTemplate.Models;
using Microsoft.EntityFrameworkCore;

namespace FitnessTemplate.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
         
            }  
        DbSet<Slider> Sliders { get; set; }
            DbSet<SmalSlider> SmallSlider { get; set; }
            DbSet<Trainer> Trainers { get; set; }
            DbSet<Blog> Blogs { get; set; }
            DbSet<Price> Prices { get; set; }

    }
}
