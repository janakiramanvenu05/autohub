using AutoHub.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AutoHub.Infrastructure.Persistence;

/// <summary>
/// Provides access to the AutoHub vehicle database.
/// </summary>
public class VehicleDbContext : DbContext
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VehicleDbContext" /> class.
    /// </summary>
    /// <param name="options">The options used to configure the context.</param>
    public VehicleDbContext(DbContextOptions<VehicleDbContext> options)
        : base(options)
    {
    }

    /// <summary>
    /// Gets the vehicles stored in the database.
    /// </summary>
    public DbSet<Vehicle> Vehicles => Set<Vehicle>();
}
