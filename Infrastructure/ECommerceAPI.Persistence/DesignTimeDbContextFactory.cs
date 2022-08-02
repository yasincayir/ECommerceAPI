using ECommerceAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ECommerceApiDbContext>
    {
        public ECommerceApiDbContext CreateDbContext(string[] args)
        {

            DbContextOptionsBuilder<ECommerceApiDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseNpgsql(Configuration.ConfigurationString);
            return new (dbContextOptionsBuilder.Options);
        }
    }
}
