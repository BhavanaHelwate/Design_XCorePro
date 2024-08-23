using Microsoft.EntityFrameworkCore;

namespace Design_XCorePro.Model
{
    public class AddDbContext : DbContext
    {
        public AddDbContext(DbContextOptions dbContextOptions) : base(options: dbContextOptions)
        {

        }
        public DbSet<Student> Students { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=LAPTOP-23SLIS8D\\SQLEXPRESS;Database=Design_XCorePro;Integrated Security=True;");
            }
        }
    }
}

