using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class CityController : ControllerBase
	{
		ICityService _cityService;
        public CityController(ICityService cityService)
        {
			_cityService = cityService;
        }

        [HttpGet("{cityId}")]
		public IActionResult GetById(int cityId)
		{
			var result = _cityService.GetById(cityId);
			if (result.IsSuccess)
			{
				return new OkObjectResult(result);
			}
			return new BadRequestObjectResult(result);
		}

		[HttpGet("cities")]
		public IActionResult GetListCity()
		{
			var result = _cityService.GetListCity();
			if (result.IsSuccess)
			{
				return new OkObjectResult(result);
			}
			return new BadRequestObjectResult(result);
		}

		[HttpPost("add")]
		public IActionResult AddCity(City city)
		{
			var result = _cityService.AddCity(city);
			if (result.IsSuccess)
			{
				return new OkObjectResult(result);
			}
			return new BadRequestObjectResult(result);
		}

		[HttpPost("update")]
		public IActionResult Update(City city)
		{
			var result = _cityService.UpdateCity(city);
			if (result.IsSuccess)
			{
				return new OkObjectResult(result);
			}
			return new BadRequestObjectResult(result);
		}
	}
}
