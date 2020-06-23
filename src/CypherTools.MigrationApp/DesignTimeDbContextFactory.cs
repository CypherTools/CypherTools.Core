using CypherTools.Core.DataAccess.Repos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace CypherTools.MigrationApp
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<CypherContext>
    {
        public CypherContext CreateDbContext(string[] args)
        {

            var builder = new DbContextOptionsBuilder<CypherContext>();
            var connectionString = Environment.GetEnvironmentVariable("postgresIdentityConnectionString");
            builder.UseNpgsql(connectionString);
            return new CypherContext(builder.Options);
        }
    }
}
