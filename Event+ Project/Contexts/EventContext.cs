using Event__Project.Domains;
using Microsoft.EntityFrameworkCore;

namespace Event__Project.Contexts
{
    public class EventContext : DbContext
    {
        public EventContext()
        {
        }

        public EventContext(DbContextOptions <EventContext> options): base(options)
        {
        }

        public DbSet<ComentarioEvento> ComentarioEvento { get; set; }
        public DbSet<Evento> Evento { get; set; } 
        public DbSet<Institucoes> Instituicoes { get; set; } 
        public DbSet<PresencaEventos> PresencaEventos { get; set; } 
        public DbSet<TipoEventos> TipoEvento { get; set; } 
        public DbSet<TiposUsuario> TiposUsuario { get; set; } 
        public DbSet<Usuarios> Usuarios { get; set; } 
     
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server= DESKTOP-A2J49GH\\SQLEXPRESS; Database=EventPlus; User Id=sa; Pwd=Senai@134;TrustServerCertificate=true;");
            }
        }
    }
}
