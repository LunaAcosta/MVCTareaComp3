using Microsoft.EntityFrameworkCore;

namespace MVCTarea.Models
{
    public class LibreriaContext:DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=localhost;Database=ejemplo;Uid=root;Pwd=usbw;SSL Mode=None");
        }
        public DbSet<Escritorio> Escritorios {get;set;}
    
    }
}