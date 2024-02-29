using AutoMapper;
using CarAdverts.Core.Interface;
using CarAdverts.Core.Models;
using CarAdverts.Repository.Interface;

namespace CarAdverts.Core.Services;

public class CarAdvertService : ICarAdvertService
{
    private readonly ICarAdvertRepository _repository;
    private readonly IMapper _mapper;

    public CarAdvertService(ICarAdvertRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public Task<IEnumerable<CarAdvertDto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }
}
