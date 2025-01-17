﻿using Microsoft.EntityFrameworkCore;
using PersonelApp.WebAPI.Models;

namespace PersonelApp.WebAPI.Context;

public sealed class ApplicationDbContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // optionsBuilder.UseInMemoryDatabase("MyDb");
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-K1PO1MB\\SQLEXPRESS;Initial Catalog=ePersonelDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }

    public DbSet<Personel> Personels { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<AuthToken> AuthTokens { get; set; }

   
}
