using System;
using System.Collections.Generic;
using System.Text;
using ArApiProvider.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ArApiProvider.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<RoomPlan> RoomPlans { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
