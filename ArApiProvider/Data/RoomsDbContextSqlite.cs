using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArApiProvider.Models;
using Microsoft.EntityFrameworkCore;

namespace ArApiProvider.Data
{
    public class RoomsDbContextSqlite: RoomsDbContext
    {
        public RoomsDbContextSqlite(DbContextOptions options) : base(options)
        {
        }
        public RoomsDbContextSqlite(DbContextOptions<RoomsDbContext> options) : base(options)
        {
        }
    }
}
