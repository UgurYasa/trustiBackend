using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class PolicyCoverageController : ControllerBase
	{
		private IPolicyCoverageService _policyCoverageService;

        public PolicyCoverageController(IPolicyCoverageService policyCoverageService)
        {
            _policyCoverageService = policyCoverageService;
        }
        [HttpGet("getpolicycoveragelist")]
		public IActionResult getPolicyCoverageList()
		{
			var result = _policyCoverageService.getPolicyCoverageList();
			if (result.IsSuccess)
			{
				return new OkObjectResult(result);
			}
			return new BadRequestObjectResult(result);
		}

		[HttpPost("addpolicycoverage")]
		public IActionResult AddPolicyCoverage(PolicyCoverage policyCoverage)
		{
			var result = _policyCoverageService.AddPolicyCoverage(policyCoverage);
			if (result.IsSuccess)
			{
				return new OkObjectResult(result);
			}
			return new BadRequestObjectResult(result);
		}
	}
}
