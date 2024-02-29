using CarAdverts.Repository.Interface;
using CarAdverts.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace CarAdverts.Repository;
public class CarAdvertRepository : ICarAdvertRepository
{
    private readonly ApplicationDbContext _context;

    public CarAdvertRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<CarAdvert>> GetAllAsync(string? sortBy)
    {
        IQueryable<CarAdvert> query = _context.CarAdverts;

        switch (sortBy?.ToLower())
        {
            case "title":
                query = query.OrderBy(advert => advert.Title);
                break;
            case "price":
                query = query.OrderBy(advert => advert.Price);
                break;
            default:
                query = query.OrderBy(advert => advert.Id);
                break;
        }

        return await query.ToListAsync();
    }

    public async Task<CarAdvert> GetByIdAsync(int id)
    {
        return await _context.CarAdverts.FindAsync(id);
    }

    public async Task<CarAdvert> AddAsync(CarAdvert carAdvert)
    {
        _context.CarAdverts.Add(carAdvert);
        await _context.SaveChangesAsync();
        return carAdvert;
    }

    public async Task UpdateAsync(CarAdvert carAdvert)
    {
        _context.Entry(carAdvert).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var carAdvert = await _context.CarAdverts.FindAsync(id);
        if (carAdvert != null)
        {
            _context.CarAdverts.Remove(carAdvert);
            await _context.SaveChangesAsync();
        }
    }
}