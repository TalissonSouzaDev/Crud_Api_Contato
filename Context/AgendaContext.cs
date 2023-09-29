using ApiAula.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiAula.Context
{
    public class AgendaContext : DbContext
    {

        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {
            
        }
        

        public DbSet<Contato> Contatos {get; set;}
    }
}