using AutoHub.Application.Interfaces;
using AutoHub.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AutoHub.Infrastructure.Persistence;

/// <summary>
/// Provides Entity Framework Core persistence operations for vehicles.
/// </summary>
public class VehicleRepository : IVehicleRepository
{
    private readonly VehicleDbContext _dbContext;

    /// <summary>
    /// Initializes a new instance of the <see cref="VehicleRepository" /> class.
    /// </summary>
    /// <param name="dbContext">The vehicle database context.</param>
    public VehicleRepository(VehicleDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    /// <inheritdoc />
    public async Task<IEnumerable<Vehicle>> GetAllAsync()
    {
        return await _dbContext.Vehicles.ToListAsync();
    }

    /// <inheritdoc />
    public async Task<Vehicle?> GetByIdAsync(int id)
    {
        return await _dbContext.Vehicles.FindAsync(id);
    }

    /// <inheritdoc />
    public async Task<Vehicle> AddAsync(Vehicle vehicle)
    {
        await _dbContext.Vehicles.AddAsync(vehicle);
        await _dbContext.SaveChangesAsync();

        return vehicle;
    }

    /// <inheritdoc />
    public async Task UpdateAsync(Vehicle vehicle)
    {
        _dbContext.Vehicles.Update(vehicle);
        await _dbContext.SaveChangesAsync();
    }

    /// <inheritdoc />
    public async Task DeleteAsync(Vehicle vehicle)
    {
        _dbContext.Vehicles.Remove(vehicle);
        await _dbContext.SaveChangesAsync();
    }
}