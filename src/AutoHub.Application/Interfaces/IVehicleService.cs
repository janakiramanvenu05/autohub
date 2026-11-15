using AutoHub.Application.DTOs;

namespace AutoHub.Application.Interfaces;

/// <summary>
/// Defines application operations for managing vehicles.
/// </summary>
public interface IVehicleService
{
    /// <summary>
    /// Retrieves all vehicles.
    /// </summary>
    /// <returns>A collection of vehicle data transfer objects.</returns>
    Task<IEnumerable<VehicleDto>> GetAllVehiclesAsync();

    /// <summary>
    /// Retrieves a vehicle by its identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the vehicle.</param>
    /// <returns>The vehicle if found; otherwise, <see langword="null" />.</returns>
    Task<VehicleDto?> GetVehicleByIdAsync(int id);

    /// <summary>
    /// Creates a new vehicle.
    /// </summary>
    /// <param name="vehicleDto">The vehicle data to create.</param>
    /// <returns>The created vehicle.</returns>
    Task<VehicleDto> CreateVehicleAsync(VehicleDto vehicleDto);

    /// <summary>
    /// Updates an existing vehicle.
    /// </summary>
    /// <param name="id">The unique identifier of the vehicle to update.</param>
    /// <param name="vehicleDto">The updated vehicle data.</param>
    /// <returns><see langword="true" /> if the vehicle was updated; otherwise, <see langword="false" />.</returns>
    Task<bool> UpdateVehicleAsync(int id, VehicleDto vehicleDto);

    /// <summary>
    /// Deletes a vehicle.
    /// </summary>
    /// <param name="id">The unique identifier of the vehicle to delete.</param>
    /// <returns><see langword="true" /> if the vehicle was deleted; otherwise, <see langword="false" />.</returns>
    Task<bool> DeleteVehicleAsync(int id);
}
