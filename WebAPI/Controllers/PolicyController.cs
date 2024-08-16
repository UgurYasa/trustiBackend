using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class PolicyController : ControllerBase
	{

		private IPolicyService _policyService;
		public PolicyController(IPolicyService policyService)
		{
			_policyService = policyService;
		}

		[HttpGet("getlist")]
		public IActionResult GetListPolicy()
		{
			var result = _policyService.GetListPolicy();
			if (result.IsSuccess)
			{
				return new OkObjectResult(result);
			}
			return new BadRequestObjectResult(result);
		}



	}
}
