using Microsoft.EntityFrameworkCore;
using SistemaDeTarefas.Data.Map;
using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Data
{
    public class SistemaDeTarefasDBContext : DbContext
    {
        public SistemaDeTarefasDBContext(DbContextOptions<SistemaDeTarefasDBContext> options)
            : base(options) 
        {

        }

        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<TarefaModel> Tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbilder) 
        {
            modelbilder.ApplyConfiguration(new UsuarioMap());
            modelbilder.ApplyConfiguration(new TarefaMap());

            base.OnModelCreating(modelbilder);

        }

    }
}
