
using Microsoft.EntityFrameworkCore;

namespace WebApp.Models;

public partial class WebAppContext :  DbContext
{

    public WebAppContext()
    {
    }

    public WebAppContext(DbContextOptions<WebAppContext> options, IConfiguration configuration)
        : base(options)
    {
        _configuration = configuration;
    }

    public IConfiguration _configuration;



    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(_configuration.GetConnectionString("Default"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    public virtual DbSet<Customer> Customers { get; set; }
    public virtual DbSet<Product> Products { get; set; }
    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<Role> Roles { get; set; }
    //Add-Migration intialMigration
    //Update-DataBase 
}
