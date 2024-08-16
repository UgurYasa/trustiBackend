using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class DeclarationPersonController : ControllerBase
	{
		private IDeclarationPersonService _dPersonService;
        public DeclarationPersonController(IDeclarationPersonService dPersonService)
        {
            _dPersonService = dPersonService;
		}

		[HttpGet("getall")]
		public IActionResult GetDeclarationPerson()
		{
			var result = _dPersonService.GetDeclarationPerson();
			if (result.IsSuccess)
			{
				return new OkObjectResult(result);
			}
			return new BadRequestObjectResult(result);
		}

		[HttpGet("getalldto")]
		public IActionResult GetDeclarationPersonDto()
		{
			var result = _dPersonService.GetDeclarationPersonDto();
			if (result.IsSuccess)
			{
				return new OkObjectResult(result);
			}
			return new BadRequestObjectResult(result);
		}

		[HttpGet("{customer_no}")]
		public IActionResult DeclarationPersonFilterById(int customer_no)
		{
			var result = _dPersonService.DeclarationPersonFilterById(customer_no);
			if (result.IsSuccess)
			{
				return new OkObjectResult(result);
			}
			return new BadRequestObjectResult(result);
		}

		[HttpPost("add")]
		public IActionResult AddDeclarationPerson(List<DeclarationPerson> declarationPersonDtos)
		{
			var result = _dPersonService.AddDeclarationPerson(declarationPersonDtos);
			if (result.IsSuccess)
			{
				return new OkObjectResult(result);
			}
			return new BadRequestObjectResult(result);
		}

		[HttpPut("update")]
		public IActionResult UpdateDeclarationPerson(List<DeclarationPerson> declarationPersonDtos)
		{
			var result = _dPersonService.UpdateDeclarationPerson(declarationPersonDtos);
			if (result.IsSuccess)
			{
				return new OkObjectResult(result);
			}
			return new BadRequestObjectResult(result);
		}
	}
}
