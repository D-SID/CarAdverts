using CarAdverts.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace CarAdverts.Core.Models;

public record CarAdvertDto
{
    public int Id { get; init; }

    [Required]
    public string Title { get; init; } = string.Empty;

    [Required]
    public FuelType Fuel { get; init; }

    [Required]
    [Range(1, int.MaxValue)]
    public int Price { get; init; }

    [Required]
    public bool New { get; init; }

    [Range(0, int.MaxValue)]
    public int? Mileage { get; init; }

    public DateTime? FirstRegistration { get; init; }
}
