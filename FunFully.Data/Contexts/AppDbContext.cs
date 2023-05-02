﻿using FunFully.Domain.Entities.Moneys;
using FunFully.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace FunFully.Data.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Money> Moneys { get; set; }
    }
}
