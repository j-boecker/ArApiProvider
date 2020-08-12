using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ArApiProvider.Data
{
    public class RoomsDbContextMySql : RoomsDbContext
    {
        public RoomsDbContextMySql(DbContextOptions<RoomsDbContext> options) : base(options)
        {
        }
    }
}
