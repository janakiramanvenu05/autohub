using AutoHub.Application.DTOs;
using AutoHub.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AutoHub.Api.Controllers;

/// <summary>
/// Provides HTTP endpoints for managing vehicles.
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class VehicleController : ControllerBase
{
    private readonly IVehicleService _vehicleService;

    /// <summary>
    /// Initializes a new instance of the <see cref="VehicleController" /> class.
    /// </summary>
    /// <param name="vehicleService">The vehicle service.</param>
    public VehicleController(IVehicleService vehicleService)
    {
        _vehicleService = vehicleService;
    }

    /// <summary>
    /// Gets all vehicles.
    /// </summary>
    /// <returns>A response containing all vehicles.</returns>
    [HttpGet]
    public async Task<IActionResult> GetAllVehiclesAsync()
    {
        var vehicles = await _vehicleService.GetAllVehiclesAsync();
        return Ok(vehicles);
    }

    /// <summary>
    /// Gets a vehicle by its identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the vehicle.</param>
    /// <returns>The vehicle if found; otherwise, a not found response.</returns>
    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetVehicleByIdAsync(int id)
    {
        var vehicle = await _vehicleService.GetVehicleByIdAsync(id);
        return vehicle is null ? NotFound() : Ok(vehicle);
    }

    /// <summary>
    /// Creates a new vehicle.
    /// </summary>
    /// <param name="vehicleDto">The vehicle data to create.</param>
    /// <returns>The created vehicle and its location.</returns>
    [HttpPost]
    public async Task<IActionResult> CreateVehicleAsync(VehicleDto vehicleDto)
    {
        var createdVehicle = await _vehicleService.CreateVehicleAsync(vehicleDto);

        return CreatedAtAction(
            nameof(GetVehicleByIdAsync),
            new { id = createdVehicle.Id },
            createdVehicle);
    }

    /// <summary>
    /// Updates an existing vehicle.
    /// </summary>
    /// <param name="id">The unique identifier of the vehicle to update.</param>
    /// <param name="vehicleDto">The updated vehicle data.</param>
    /// <returns>No content if updated; otherwise, a not found response.</returns>
    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateVehicleAsync(int id, VehicleDto vehicleDto)
    {
        var updated = await _vehicleService.UpdateVehicleAsync(id, vehicleDto);
        return updated ? NoContent() : NotFound();
    }

    /// <summary>
    /// Deletes a vehicle.
    /// </summary>
    /// <param name="id">The unique identifier of the vehicle to delete.</param>
    /// <returns>No content if deleted; otherwise, a not found response.</returns>
    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteVehicleAsync(int id)
    {
        var deleted = await _vehicleService.DeleteVehicleAsync(id);
        return deleted ? NoContent() : NotFound();
    }
}
