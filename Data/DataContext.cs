using Microsoft.EntityFrameworkCore;
using JoloLoverServices.Models;

namespace JoloLoverServices.Data;

public class DataContext : DbContext
{
    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Wallet> Wallets { get; set; }
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }
}