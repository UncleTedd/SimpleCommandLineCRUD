using Microsoft.EntityFrameworkCore;

namespace ConsoleAppCRUD.DB;

public class MyDbContext : DbContext
{
    public DbSet<MovieEntity> Movies { get; set; }
    public DbSet<TheaterEntity> Theaters { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql("server=localhost;port=3306;database=testDB;user=root;password=root;",
            new MariaDbServerVersion("11.1.2"));
    }
}