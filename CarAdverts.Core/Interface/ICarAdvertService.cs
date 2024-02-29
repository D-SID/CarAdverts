using CarAdverts.Core.Models;

namespace CarAdverts.Core.Interface;
public interface ICarAdvertService
{
    Task<IEnumerable<CarAdvertDto>> GetAllAsync(string sortBy);
    Task<CarAdvertDto> GetByIdAsync(int id);
    Task<CarAdvertDto> CreateAsync(CarAdvertDto carAdvertDto);
    Task UpdateAsync(CarAdvertDto carAdvertDto);
    Task DeleteAsync(int id);

}
