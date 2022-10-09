using Microsoft.EntityFrameworkCore;
using ExoApi.Models;

namespace ExoApi.Contexts
{
    public class dbExoAPIContext: DbContext
    {
        public dbExoAPIContext() { }

        // estancia de um objeto 'option' e retornar direto pro 'DbContext' (base que faz isso)
        public dbExoAPIContext(DbContextOptions<dbExoAPIContext> options) : base(options) { }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = MYMAX\\SQLEXPRESS; initial catalog = dbExoApi; Integrated Security = true"); //User Id = aluno; Password = aluno1234" //Integrated Security = true
            }

        }
        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
