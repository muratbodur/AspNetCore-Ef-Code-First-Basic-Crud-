using BasicProje.Entity;
using Microsoft.EntityFrameworkCore;

namespace BasicProje.ProjeContext
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MURATBODUR;Database=DbNewOOPCore;User Id=sa;Password=2697;Trusted_Connection=True;MultipleActiveResultSets=true;Integrated Security=true;");
        }

       
        public DbSet<Product> products { get; set; }    
        public DbSet<Customer> customers { get; set; }  
        public DbSet<Category> categories { get; set; } 




    }
}
