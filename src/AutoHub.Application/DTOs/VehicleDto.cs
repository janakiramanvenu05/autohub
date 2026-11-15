namespace AutoHub.Application.DTOs;

/// <summary>
/// Represents vehicle data transferred between the application and its clients.
/// </summary>
public class VehicleDto
{
    /// <summary>
    /// Gets or sets the unique identifier of the vehicle.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the vehicle registration number.
    /// </summary>
    public required string RegistrationNumber { get; set; }

    /// <summary>
    /// Gets or sets the vehicle brand.
    /// </summary>
    public required string Brand { get; set; }

    /// <summary>
    /// Gets or sets the vehicle model.
    /// </summary>
    public required string Model { get; set; }

    /// <summary>
    /// Gets or sets the vehicle manufacturing year.
    /// </summary>
    public int ManufacturingYear { get; set; }

    /// <summary>
    /// Gets or sets the name of the vehicle owner.
    /// </summary>
    public required string OwnerName { get; set; }
}
