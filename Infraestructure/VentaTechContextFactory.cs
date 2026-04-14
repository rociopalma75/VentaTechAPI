using Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure
{
    public class VentaTechContextFactory : IDesignTimeDbContextFactory<VentaTechContext>
    {
        public VentaTechContext CreateDbContext(string[] args)
        {
            // Apunta al appsettings.json del proyecto API
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../API"))
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<VentaTechContext>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("VentaTechContext"));

            return new VentaTechContext(optionsBuilder.Options);
        }
    }
}
