using AutoHub.Domain.Entities;

namespace AutoHub.Application.Interfaces;

/// <summary>
/// Defines persistence operations for vehicles.
/// </summary>
public interface IVehicleRepository
{
    /// <summary>
    /// Retrieves all vehicles.
    /// </summary>
    /// <returns>A collection of vehicles.</returns>
    Task<IEnumerable<Vehicle>> GetAllAsync();

    /// <summary>
    /// Retrieves a vehicle by its identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the vehicle.</param>
    /// <returns>The vehicle if found; otherwise, <see langword="null" />.</returns>
    Task<Vehicle?> GetByIdAsync(int id);

    /// <summary>
    /// Adds a vehicle to the persistence store.
    /// </summary>
    /// <param name="vehicle">The vehicle to add.</param>
    /// <returns>The added vehicle.</returns>
    Task<Vehicle> AddAsync(Vehicle vehicle);

    /// <summary>
    /// Updates a vehicle in the persistence store.
    /// </summary>
    /// <param name="vehicle">The vehicle to update.</param>
    Task UpdateAsync(Vehicle vehicle);

    /// <summary>
    /// Deletes a vehicle from the persistence store.
    /// </summary>
    /// <param name="vehicle">The vehicle to delete.</param>
    Task DeleteAsync(Vehicle vehicle);
}
