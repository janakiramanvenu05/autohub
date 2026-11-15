namespace AutoHub.Domain.Entities;

/// <summary>
/// Represents a vehicle registered in AutoHub.
/// </summary>
public class Vehicle
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

    /// <summary>
    /// Gets or sets the date and time when the vehicle was created.
    /// </summary>
    public DateTime CreatedDate { get; set; }

    /// <summary>
    /// Gets or sets the date and time when the vehicle was last updated.
    /// </summary>
    public DateTime UpdatedDate { get; set; }
}
