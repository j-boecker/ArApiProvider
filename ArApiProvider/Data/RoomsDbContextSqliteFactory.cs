using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ArApiProvider.Data
{
    public class RoomsDbContextSqliteFactory : IDesignTimeDbContextFactory<RoomsDbContextSqlite>
    {
        public RoomsDbContextSqlite CreateDbContext(string[] args)
        {
            var options = new DbContextOptionsBuilder<RoomsDbContextSqlite>().UseSqlite("DataSource=rooms2.db").Options;
            return new RoomsDbContextSqlite(options);
        }
    }
}
