using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArApiProvider.Models;
using Microsoft.EntityFrameworkCore;

namespace ArApiProvider.Data
{
    public class RoomsDbContext: DbContext
    {
        public DbSet<RoomPlan> RoomPlans { get; set; }
        public RoomsDbContext(DbContextOptions<RoomsDbContext> options) : base(options)
        {

        }
    }
}
