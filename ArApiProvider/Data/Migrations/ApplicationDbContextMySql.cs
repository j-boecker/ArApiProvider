using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ArApiProvider.Data.Migrations
{
    public class ApplicationDbContextMySql: ApplicationDbContext
    {
        public ApplicationDbContextMySql(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}
