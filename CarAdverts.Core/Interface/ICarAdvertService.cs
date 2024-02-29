using CarAdverts.Core.Models;

namespace CarAdverts.Core.Interface;
public interface ICarAdvertService
{
    Task<IEnumerable<CarAdvertDto>> GetAllAsync();
}
