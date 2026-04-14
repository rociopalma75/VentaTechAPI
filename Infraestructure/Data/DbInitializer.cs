using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Data
{
    public class DbInitializer
    {
        public static async Task SeedAsync(VentaTechContext context)
        {
            await context.Database.MigrateAsync();

            if (!context.Departamentos.Any())
            {
                var scriptPath = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    "Scripts", "seed.sql"
                );

                var sql = await File.ReadAllTextAsync(scriptPath);
                await context.Database.ExecuteSqlRawAsync(sql);
            }
        }
    }
}
