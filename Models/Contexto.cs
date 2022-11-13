using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace WebCrudMvcSql.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
        : base(options)
        { }

        public DbSet<Usuario> Usuario{ get; set; }
    }
}
