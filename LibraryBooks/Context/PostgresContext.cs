using Microsoft.EntityFrameworkCore;

namespace LibraryBooks.Context;

public class PostgresContext : DbContext
{
    public PostgresContext(DbContextOptions<PostgresContext> options) : base(options)
    {
    }
    
    
}