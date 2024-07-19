using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Synergy.Entities;

namespace Synergy;

public partial class SynergyDbContext : DbContext
{
    public SynergyDbContext()
    {
    }

    public SynergyDbContext(DbContextOptions<SynergyDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Server> Servers { get; set; }
    public DbSet<Channel> Channels { get; set; }
    public DbSet<Message> Messages { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<UserRole> UserRoles { get; set; }
    public DbSet<UserServer> UserServers { get; set; }
    public DbSet<Permission> Permissions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Primary keys
        modelBuilder.Entity<User>().HasKey(u => u.UserID);
        modelBuilder.Entity<Server>().HasKey(s => s.ServerID);
        modelBuilder.Entity<Channel>().HasKey(c => c.ChannelID);
        modelBuilder.Entity<Message>().HasKey(m => m.MessageID);
        modelBuilder.Entity<Role>().HasKey(r => r.RoleID);
        modelBuilder.Entity<Permission>().HasKey(p => p.PermissionID);
    }

     
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();
            var connectionString = configuration.GetConnectionString("SynergyDatabase");
            optionsBuilder.UseNpgsql(connectionString);
        }
    }
        

 

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
