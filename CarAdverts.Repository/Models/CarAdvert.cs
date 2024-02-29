using CarAdverts.Repository.Enum;

namespace CarAdverts.Repository.Models;

public class CarAdvert
{
    public int Id { get; set; }
    public string Title { get; set; }
    public FuelType Fuel { get; set; }
    public int Price { get; set; }
    public bool New { get; set; }
    public int? Mileage { get; set; } 
    public DateTime? FirstRegistration { get; set; }
}
