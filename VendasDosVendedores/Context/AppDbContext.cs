using Microsoft.EntityFrameworkCore;

namespace VendasDosVendedores.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
}
