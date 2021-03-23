using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using OnlineSalesProducts.Models;

namespace OnlineSalesProducts.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<OnlineSalesProducts.Models.Product> Product { get; set; }
        public DbSet<OnlineSalesProducts.Models.Category> Category { get; set; }
    }
}
