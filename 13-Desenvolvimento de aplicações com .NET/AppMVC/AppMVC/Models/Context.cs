using Microsoft.EntityFrameworkCore;
using AppMVC.Models;

namespace AppMVC.Models
{
    public class Context : DbContext
    {
        public virtual DbSet<Categoria> Categorias { get; set; }
        
        public virtual DbSet<AppMVC.Models.Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Cursomvc;Integrated Security=True");
        }

        public virtual void SetModified(object entity) { 
            Entry(entity).State = EntityState.Modified;
        }       
    }
}