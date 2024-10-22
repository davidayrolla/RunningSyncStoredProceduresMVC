using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using RunningSyncStoredProceduresMVC.Models;

namespace RunningSyncStoredProceduresMVC.Context;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Process> Processes { get; set; }

    // Method to execute a stored procedure
    public async Task<int> ExecuteStoredProcedureAsync(string taskName)
    {
        return await Database.ExecuteSqlRawAsync($"EXEC RunningProcedureMVC @taskName",
            new SqlParameter("@taskName", taskName));
    }

}