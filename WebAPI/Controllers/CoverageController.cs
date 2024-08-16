using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class CoverageController : ControllerBase
	{

		ICoverageService _coverageService;

		public CoverageController(ICoverageService coverageService)
		{
			_coverageService = coverageService;
		}

		[HttpGet("getall")]
		public IActionResult GetAll()
		{
			var result = _coverageService.GetCoverageList();
			if (result.IsSuccess)
			{
				return new OkObjectResult(result);
			}
			return new BadRequestObjectResult(result);
		}

		[HttpGet("id/{coverageId}")]
		public IActionResult GetFilterByCoverageId(int coverageId)
		{
			var result = _coverageService.GetFilterByCoverageId(coverageId);
			if (result.IsSuccess)
			{
				return new OkObjectResult(result);
			}
			return new BadRequestObjectResult(result);
		}
		[HttpGet("{cityId}")]
		public IActionResult GetNetworkListByCity(int cityId)
		{
			var result = _coverageService.GetNetworkByCity(cityId);
			if (result.IsSuccess)
			{
				return new OkObjectResult(result);
			}
			return new BadRequestObjectResult(result);
		}

		[HttpPost("add")]
		public IActionResult AddCoverage(Coverage coverage)
		{
			var result = _coverageService.AddCoverage(coverage);
			if (result.IsSuccess)
			{
				return new OkObjectResult(result);
			}
			return new BadRequestObjectResult(result);
		}

		[HttpPut("update")]
		public IActionResult UpdateCoverage(Coverage coverage)
		{
			var result = _coverageService.UpdateCoverage(coverage);
			if (result.IsSuccess)
			{
				return new OkObjectResult(result);
			}
			return new BadRequestObjectResult(result);
		}

	}
}
