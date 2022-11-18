using Microsoft.EntityFrameworkCore;
using SistemaDeTarefas.Data;

namespace SistemaDeTarefas.Services
{
    public static class InitialMigration
    {
        //utilizado para executar as migrations automaticamente
        public static void RestoreMigration(this IApplicationBuilder app)
        {
            using (var escopo = app.ApplicationServices.CreateScope())
            {
                var ServiceDb = escopo.ServiceProvider.GetService<SistemaDeTarefasDBContext>();
                ServiceDb.Database.Migrate();
            }
        }
    }
}
