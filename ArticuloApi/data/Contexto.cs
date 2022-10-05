using ArticuloApi.model;
using Microsoft.EntityFrameworkCore;

namespace ArticuloApi.data
{
    public class Contexto:DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        public DbSet<Articulos> Articulos { get; set; }
    }
}
