using System;
using System.Collections.Generic;
using System.Text;
using ArApiProvider.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ArApiProvider.Data
{
    public class ApplicationDbContextSqlite : ApplicationDbContext
    {
        public ApplicationDbContextSqlite(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}
