using AutoMapper;
using MiastaMieścinyMiasteczka.Data.Interfaces;
using MiastaMieścinyMiasteczka.DTOs;
using MiastaMieścinyMiasteczka.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MiastaMieścinyMiasteczka.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CityController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICityRepository _cityRepository;


        public CityController(ICityRepository cityRepository, IMapper mapper)
        {
            this._mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
            this._cityRepository = cityRepository ??
                throw new ArgumentException(nameof(cityRepository));
        }
        [HttpGet]
        public ActionResult<CityDTO> GetRandCity()
        {
            var cities = _cityRepository.GetAllCities().ToList();
            Random random = new Random();
            return Ok(_mapper.Map<CityDTO>(cities[random.Next(0,cities.Count())]));
        }
        [HttpGet("CityId", Name ="GetById")]
        public ActionResult<CityDTO> GetCity(int CityId)
        {
            var city = _cityRepository.GetCityById(CityId);
            return city is null? NotFound(): Ok(_mapper.Map<CityDTO>(_cityRepository.GetCityById(CityId)));
        }
        [HttpPost]
        public ActionResult<CityDTO> CreateCity(CityCreationDTO cityCreationDTO)
        {
            var tmp = _mapper.Map<City>(cityCreationDTO);
            var createdCity = _cityRepository.AddCity(tmp);
            return CreatedAtRoute("GetById",
                new
                {
                    id = createdCity.Id
                }, _mapper.Map<CityDTO>(createdCity));
        }

    }
}