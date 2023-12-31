﻿using PatriciasBooks.Models; /*new add pt.2*/
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatriciasBookStore.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; } /*new add pt.2*/
        public DbSet<CoverType> CoverTypes { get; set; } /*new add pt.3*/
        public DbSet<Product> Products { get; set; } /*new add pt.3.2*/
    }
}
