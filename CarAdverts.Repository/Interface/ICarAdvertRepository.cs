using CarAdverts.Repository.Models;

namespace CarAdverts.Repository.Interface;
public interface ICarAdvertRepository
{
    Task<IEnumerable<CarAdvert>> GetAllAsync(string sortBy);
    Task<CarAdvert> GetByIdAsync(int id);
    Task<CarAdvert> AddAsync(CarAdvert carAdvert);
    Task UpdateAsync(CarAdvert carAdvert);
    Task DeleteAsync(int id);
}
