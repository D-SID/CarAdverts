using CarAdverts.Repository.Models;

namespace CarAdverts.Repository.Interface;
public interface ICarAdvertRepository
{
    Task<IEnumerable<CarAdvert>> GetAllAsync();
}
