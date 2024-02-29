using AutoMapper;
using CarAdverts.Core.Interface;
using CarAdverts.Core.Models;
using CarAdverts.Repository.Interface;
using CarAdverts.Repository.Models;

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

    public async Task<IEnumerable<CarAdvertDto>> GetAllAsync(string? sortBy)
    {
        var adverts = await _repository.GetAllAsync(sortBy);
        return _mapper.Map<IEnumerable<CarAdvertDto>>(adverts);
    }

    public async Task<CarAdvertDto> GetByIdAsync(int id)
    {
        var advert = await _repository.GetByIdAsync(id);
        return _mapper.Map<CarAdvertDto>(advert);
    }

    public async Task<CarAdvertDto> CreateAsync(CarAdvertDto carAdvertDto)
    {
        var advert = _mapper.Map<CarAdvert>(carAdvertDto);
        advert = await _repository.AddAsync(advert);
        return _mapper.Map<CarAdvertDto>(advert);
    }

    public async Task UpdateAsync(CarAdvertDto carAdvertDto)
    {
        var advert = _mapper.Map<CarAdvert>(carAdvertDto);
        await _repository.UpdateAsync(advert);
    }

    public async Task DeleteAsync(int id)
    {
        await _repository.DeleteAsync(id);
    }
}
