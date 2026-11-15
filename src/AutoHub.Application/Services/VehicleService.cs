using AutoHub.Application.DTOs;
using AutoHub.Application.Interfaces;

namespace AutoHub.Application.Services;

/// <summary>
/// Provides in-memory operations for managing vehicles.
/// </summary>
public class VehicleService : IVehicleService
{
    private static readonly List<VehicleDto> Vehicles =
    [
        new VehicleDto
        {
            Id = 1,
            RegistrationNumber = "AB12 CDE",
            Brand = "Toyota",
            Model = "Corolla",
            ManufacturingYear = 2020,
            OwnerName = "John Smith"
        },
        new VehicleDto
        {
            Id = 2,
            RegistrationNumber = "FG34 HIJ",
            Brand = "Honda",
            Model = "Civic",
            ManufacturingYear = 2021,
            OwnerName = "Sarah Johnson"
        },
        new VehicleDto
        {
            Id = 3,
            RegistrationNumber = "KL56 MNO",
            Brand = "Ford",
            Model = "Focus",
            ManufacturingYear = 2019,
            OwnerName = "Michael Brown"
        }
    ];

    /// <inheritdoc />
    public Task<IEnumerable<VehicleDto>> GetAllVehiclesAsync()
    {
        return Task.FromResult<IEnumerable<VehicleDto>>(Vehicles.ToList());
    }

    /// <inheritdoc />
    public Task<VehicleDto?> GetVehicleByIdAsync(int id)
    {
        var vehicle = Vehicles.FirstOrDefault(vehicle => vehicle.Id == id);
        return Task.FromResult(vehicle);
    }

    /// <inheritdoc />
    public Task<VehicleDto> CreateVehicleAsync(VehicleDto vehicleDto)
    {
        var nextId = Vehicles.Count == 0 ? 1 : Vehicles.Max(vehicle => vehicle.Id) + 1;
        vehicleDto.Id = nextId;
        Vehicles.Add(vehicleDto);

        return Task.FromResult(vehicleDto);
    }

    /// <inheritdoc />
    public Task<bool> UpdateVehicleAsync(int id, VehicleDto vehicleDto)
    {
        var existingVehicle = Vehicles.FirstOrDefault(vehicle => vehicle.Id == id);
        if (existingVehicle is null)
        {
            return Task.FromResult(false);
        }

        existingVehicle.RegistrationNumber = vehicleDto.RegistrationNumber;
        existingVehicle.Brand = vehicleDto.Brand;
        existingVehicle.Model = vehicleDto.Model;
        existingVehicle.ManufacturingYear = vehicleDto.ManufacturingYear;
        existingVehicle.OwnerName = vehicleDto.OwnerName;

        return Task.FromResult(true);
    }

    /// <inheritdoc />
    public Task<bool> DeleteVehicleAsync(int id)
    {
        var vehicle = Vehicles.FirstOrDefault(vehicle => vehicle.Id == id);
        if (vehicle is null)
        {
            return Task.FromResult(false);
        }

        Vehicles.Remove(vehicle);
        return Task.FromResult(true);
    }
}
