﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ETicaretAPI.Persistence.Contexts
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ETicaretAPIDbContext>
    {
        public ETicaretAPIDbContext CreateDbContext(string[] args)
        {
;
            DbContextOptionsBuilder<ETicaretAPIDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseNpgsql(Configuration.ConnectionString);
            return new (dbContextOptionsBuilder.Options);
        }
    }
}
