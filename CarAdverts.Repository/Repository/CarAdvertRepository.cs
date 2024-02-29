using CarAdverts.Repository.Interface;
using CarAdverts.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace CarAdverts.Repository;
public class CarAdvertRepository : ICarAdvertRepository
{
    private readonly ApplicationDbContext _context;

    public CarAdvertRepository()
    {
    }

    public async Task<IEnumerable<CarAdvert>> GetAllAsync()
    {
        throw new NotImplementedException();
    }
}