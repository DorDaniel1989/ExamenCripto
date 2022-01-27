#define SQL_NO
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CriptoDB.Modelos;

public class CryptoContext : DbContext
{
    public static string connString { get; private set; }
#if SQL //SQLServer
     = $"Server=localhost;Database=CryptoDB;User Id=sa;Password=Pa88word;MultipleActiveResultSets=true";
#else //Windows
     = $"Server=(localdb)\\mssqllocaldb;Database=CrytoDB;Trusted_Connection=True;MultipleActiveResultSets=true";
#endif
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(connString);

    //public CryptoContext(DbContextOptions<CryptoContext> options) : base(options) { }
    //public CryptoContext() : base() { }

    public DbSet<Moneda> Monedas { get; set; }

    public DbSet<Cartera> Carteras { get; set; }

    public DbSet<Contrato> Contratos { get; set; }
    
}
